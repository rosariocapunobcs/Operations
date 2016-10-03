using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Mvc;

using Newtonsoft.Json;

namespace BCS.DisruptOp.Models
{
    [DataContract(Name = "field", Namespace = "")]
    public class FieldJSONStructure
    {
        [Display(Name = "name")]
        [JsonProperty("name")]
        [DataMember(Order = 1)]
        public string Name { get; set; }

        [Display(Name = "title")]
        [JsonProperty("title")]
        [DataMember(Order = 2)]
        public string Title { get; set; }

        [Display(Name = "type")]
        [JsonProperty("type")]
        [DataMember(Order = 3)]
        public string Type { get; set; }

        [Display(Name = "validate")]
        [JsonProperty("validate")]
        [DataMember(Order = 4)]
        public string Validate { get; set; }
    }

    [DataContract(Name = "DisruptFieldOrder", Namespace = "")]
    public class FieldJSON
    {
        [DataMember(Order = 1, Name = "fields")]
        public List<FieldJSONStructure> FieldList { get; set; }
    }
}
