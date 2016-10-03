using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

using BCS.DisruptOp.Manager;
using BCS.DisruptOp.Mapper;
using BCS.DisruptOp.Models;
using BCS.DisruptOp.Stubs;

namespace BCS.DisruptOp.Controllers
{
    public class DisruptController : Controller
    {
        #region Declarations
        DisruptManager disruptManager = new DisruptManager();

        #endregion

        public DisruptController()
        {

        }

        #region Create
        public ActionResult CreateFlight(FlightModel flight)
        {
            #region CreateFlight stub
            //STUB
            //ModelState.IsValid = false
            //        CarrierCode	"DG"	string
            //        CustomerComms	"fixed"	string
            //        Destination	"KLO"	string
            //        DisruptReason	"test insert"	string
            //        Event	"cancellation"	string
            //        Number	320	int
            //        Origin	"MNL"	string
            //        PaxDLLive	17	int
            //        PaxDLOriginal	15	int
            //        RecoveryPlan	"complete"	string
            //        RecoveryPolicy	"1"	string
            //        SeverityLevel	"low"	string
            //+		STA	{1/1/0001 12:00:00 AM}	System.DateTime
            //        StaffComms	"fixed"	string
            //+		STD	{1/1/0001 12:00:00 AM}	System.DateTime

            FlightModel flightStub = new FlightModel();
            flightStub.CarrierCode = "DG";
            flightStub.CustomerComms = "fixed";
            flightStub.Destination = "KLO";
            flightStub.DisruptReason = "test insert";
            flightStub.Event = "cancellation";
            flightStub.Number = 320;
            flightStub.Origin = "MNL";
            flightStub.PaxDLLive = 17;
            flightStub.PaxDLOriginal = 15;
            flightStub.RecoveryPlan = "complete";
            flightStub.RecoveryPolicy = "1";
            flightStub.SeverityLevel = "low";
            flightStub.STA = System.DateTime.Now.ToShortDateString();
            flightStub.StaffComms = "fixed";
            flightStub.STD = System.DateTime.Now.ToShortDateString();

            //disruptManager.CreateFlight(flightStub);
            #endregion

            var error = ModelState.Values.SelectMany(v => v.Errors);

            if (ModelState.IsValid)
            {
                disruptManager.CreateFlight(flight);
            }

            return View();
        }

        public ActionResult CreateFlights(List<FlightModel> flight)
        {
            return null;
        } 
        #endregion

        #region Read
        public JsonResult GetFlightJSON()
        {
            return Json(FlightMapper.GetFlightJSON(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetFlights()
        {
            //STUB
            //return Json(DisruptFlightStub.GetFlights(), JsonRequestBehavior.AllowGet);

            return Json(FlightMapper.EntityToModelFlights(), JsonRequestBehavior.AllowGet);
        }

        //public JsonResult GetDisruptFieldOrder()
        //{
        //    return Json(FlightMapper.XMLtoJSONDisruptFieldOrder(), JsonRequestBehavior.AllowGet);
        //}

        public JsonResult GetDisruptFieldOrder()
        {
            return Json(disruptManager.SerializeDisruptFieldOrder(), JsonRequestBehavior.AllowGet);
        } 
        #endregion

        public ActionResult UpdateFlight(FlightModel flight)
        {
            if (ModelState.IsValid)
            {
                disruptManager.UpdateFlight(flight);
            }

            return View();
        } 
    }
}
