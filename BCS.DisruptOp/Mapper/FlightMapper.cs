using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using BCS.DisruptOp.Manager;
using BCS.DisruptOp.Models;

using Newtonsoft.Json;

namespace BCS.DisruptOp.Mapper
{
    public static class FlightMapper
    {
        private static FlightsEntities _flightsEntities = new FlightsEntities();
        private static DisruptManager disruptManager = new DisruptManager();

        public static FlightModel GetFlight()
        {
            FlightModel flightModel = new FlightModel();
            flightModel.CarrierCode = "5J";
            flightModel.Number = 12;
            flightModel.Origin = "Manila";
            flightModel.Destination = "Davao";
            flightModel.STD = DateTime.Now.ToShortDateString();
            flightModel.STA = DateTime.Now.AddDays(1).ToShortDateString();
            flightModel.SeverityLevel = "Critical";
            flightModel.PaxDLOriginal = 13;
            flightModel.PaxDLLive = 09212016;
            flightModel.DisruptReason = "DisruptReason";
            flightModel.RecoveryPolicy = "RecoveryPolicy";
            flightModel.RecoveryPlan = "RecoveryPlan";
            flightModel.StaffComms = "StaffComms";
            flightModel.CustomerComms = "CustomerComms";
            return flightModel;
        }

        public static string GetFlightJSON()
        {
            string flights = "";
            FlightModel flightModel = GetFlight();

            flights = JsonConvert.SerializeObject(new FlightJSON()
            {
                  CarrierCode       = flightModel.CarrierCode
                , Number            = flightModel.Number.ToString()
                , Origin            = flightModel.Origin
                , Destination       = flightModel.Destination
                , STD               = flightModel.STD.ToString()
                , STA               = flightModel.STA.ToString()
                , SeverityLevel     = flightModel.SeverityLevel
                , PaxDLOriginal     = flightModel.PaxDLOriginal.ToString()
                , PaxDLLive         = flightModel.PaxDLLive.ToString()
                , DisruptReason     = flightModel.DisruptReason
                , RecoveryPolicy    = flightModel.RecoveryPolicy
                , RecoveryPlan      = flightModel.RecoveryPlan
                , StaffComms        = flightModel.StaffComms
                , CustomerComms     = flightModel.CustomerComms
            });

            return flights;
        }

        public static List<FlightModel> EntityToModelFlights()
        {
            List<FlightModel> flights = new List<FlightModel>();

            if (_flightsEntities != null)
            {
                if (_flightsEntities.Disrupts.Count() != 0)
                {
                    foreach (Disrupt disrupt in _flightsEntities.Disrupts)
                    {
                        FlightModel flightModel = new FlightModel();
                        flightModel.CarrierCode = disrupt.CarrierCode;

                        int flightNumber;
                        Int32.TryParse(disrupt.Number, out flightNumber);
                        flightModel.Number = flightNumber;

                        flightModel.Origin = disrupt.Origin;
                        flightModel.Destination = disrupt.Destination;
                        flightModel.STD = disrupt.STD.ToShortDateString();
                        flightModel.STA = disrupt.STA.ToShortDateString();
                        flightModel.SeverityLevel = disrupt.Severity;

                        int paxDLOriginal;
                        Int32.TryParse(disrupt.PaxDLOriginal.ToString(), out paxDLOriginal);
                        flightModel.PaxDLOriginal = paxDLOriginal;

                        int paxDLLive;
                        Int32.TryParse(disrupt.PaxDLLive.ToString(), out paxDLLive);
                        flightModel.PaxDLLive = paxDLLive;

                        flightModel.DisruptReason = disrupt.Reason;

                        Recovery recovery = new Recovery();

                        if (_flightsEntities.Recoveries.Count() != 0)
                        {
                            recovery = _flightsEntities.Recoveries.Where(rec => rec.Id == disrupt.Recovery).First();
                        }

                        flightModel.RecoveryPolicy = recovery.Policy;
                        flightModel.RecoveryPlan = recovery.Plan;

                        flightModel.StaffComms = disrupt.StaffComms;
                        flightModel.CustomerComms = disrupt.CustomerComms;
                        flightModel.Event = disrupt.Event;

                        flights.Add(flightModel);
                    }
                }
            }

            return flights;
        }

        public static Disrupt ExtractDisrupt(FlightModel flight)
        {
            Disrupt disrupt = new Disrupt();

            disrupt.CarrierCode = flight.CarrierCode;
            disrupt.CustomerComms = flight.CustomerComms;
            disrupt.Destination = flight.Destination;
            disrupt.Event = flight.Event;
            disrupt.Number = flight.Number.ToString();
            disrupt.Origin = flight.Origin;
            disrupt.PaxDLLive = flight.PaxDLLive;
            disrupt.PaxDLOriginal = flight.PaxDLOriginal;
            disrupt.Reason = flight.DisruptReason;

            Recovery recovery = new Recovery();
            recovery.Plan = flight.RecoveryPlan;
            recovery.Policy = flight.RecoveryPolicy;

            if (disruptManager.ExistsRecovery(recovery) == 0)
            {
                Recovery newRecovery = disruptManager.CreateRecovery(recovery);
                disrupt.Recovery = newRecovery.Id;
            }
            else
            {
                disrupt.Recovery = disruptManager.GetRecovery(recovery).Id;
            }

            disrupt.Severity = flight.SeverityLevel;
            DateTime sta = new DateTime();
            DateTime.TryParse(flight.STA, out sta);
            disrupt.STA = sta;
            disrupt.StaffComms = flight.StaffComms;
            DateTime std = new DateTime();
            DateTime.TryParse(flight.STA, out std);
            disrupt.STD = std;
            return disrupt;
        }

        //public static string XMLtoJSONDisruptFieldOrder()
        //{
        //    disruptManager.SerializeDisruptFieldOrder();

        //    List<FieldJSONStructure> fields = new List<FieldJSONStructure>();

        //    if (disruptManager.SerializeDisruptFieldOrder().FieldList.Count() != 0)
        //    {
        //        foreach (FieldJSONStructure field in disruptManager.SerializeDisruptFieldOrder().FieldList)
        //        {
        //            fields.Add(new FieldJSONStructure()
        //            {
        //                  Name = field.Name
        //                , Title = field.Title
        //                , Type = field.Type
        //                , Validate = field.Validate
        //            });
        //        }
        //    }

        //    return JsonConvert.SerializeObject(fields.ToArray());
        //}
    }
}