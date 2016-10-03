using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using BCS.DisruptOp.Models;

namespace BCS.DisruptOp.Stubs
{
    public static class DisruptFlightStub
    {
        public static List<FlightModel> GetFlights()
        {
            List<FlightModel> flights = new List<FlightModel>();

            flights.Add(new FlightModel()
            { 
                  CarrierCode = "5J"
                , Number = 12
                , Origin = "Manila"
                , Destination = "Davao"
                , STD = DateTime.Now.ToShortDateString()
                , STA = DateTime.Now.AddDays(1).ToShortDateString()
                , SeverityLevel = "Critical"
                , PaxDLOriginal = 13
                , PaxDLLive = 09212016
                , DisruptReason = "DisruptReason"
                , RecoveryPolicy = "RecoveryPolicy"
                , RecoveryPlan = "RecoveryPlan"
                , StaffComms = "StaffComms"
                , CustomerComms = "CustomerComms"
            });

            flights.Add(new FlightModel()
            { 
                  CarrierCode = "TR"
                , Number = 12
                , Origin = "Manila"
                , Destination = "Singapore"
                , STD = DateTime.Now.ToShortDateString()
                , STA = DateTime.Now.AddDays(1).ToShortDateString()
                , SeverityLevel = "Low"
                , PaxDLOriginal = 13
                , PaxDLLive = 09212016
                , DisruptReason = "Cancel"
                , RecoveryPolicy = "None"
                , RecoveryPlan = "None"
                , StaffComms = "StaffComms"
                , CustomerComms = "CustomerComms"
            });

            return flights;
        }
    }
}