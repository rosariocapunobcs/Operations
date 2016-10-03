using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Newtonsoft.Json;

namespace BCS.DisruptOp.Models
{
    public class FlightModel
    {
        public string CarrierCode { get; set; }
        public int Number { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string STD { get; set; }
        public string STA { get; set; }
        public string SeverityLevel { get; set; }
        public int PaxDLOriginal { get; set; }
        public int PaxDLLive { get; set; }
        public string DisruptReason { get; set; }
        public string RecoveryPolicy { get; set; }
        public string RecoveryPlan { get; set; }
        public string StaffComms { get; set; }
        public string CustomerComms { get; set; }
        public string Event { get; set; }
    }
}
