using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Newtonsoft.Json;

namespace BCS.DisruptOp.Models
{
    public class FlightJSON
    {
        [JsonProperty("CarrierCode")]
        public string CarrierCode { get; set; }

        [JsonProperty("Number")]
        public string Number { get; set; }

        [JsonProperty("Origin")]
        public string Origin { get; set; }

        [JsonProperty("Destination")]
        public string Destination { get; set; }

        [JsonProperty("STD")]
        public string STD { get; set; }

        [JsonProperty("STA")]
        public string STA { get; set; }

        [JsonProperty("SeverityLevel")]
        public string SeverityLevel { get; set; }

        [JsonProperty("PaxDLOriginal")]
        public string PaxDLOriginal { get; set; }

        [JsonProperty("PaxDLLive")]
        public string PaxDLLive { get; set; }

        [JsonProperty("DisruptReason")]
        public string DisruptReason { get; set; }

        [JsonProperty("RecoveryPolicy")]
        public string RecoveryPolicy { get; set; }

        [JsonProperty("RecoveryPlan")]
        public string RecoveryPlan { get; set; }

        [JsonProperty("StaffComms")]
        public string StaffComms { get; set; }

        [JsonProperty("CustomerComms")]
        public string CustomerComms { get; set; }
    }
}
