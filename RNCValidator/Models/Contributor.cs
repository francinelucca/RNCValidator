using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace RNCValidator.Models
{
    public class Contributor
    {
        [JsonProperty(PropertyName = "rnc")]
        public string RNC { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "commercial_name")]
        public string ComercialName { get; set; }

        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        [JsonProperty(PropertyName = "payment_regimen")]
        public string PaymentRegimen { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string PaymentStatus { get; set; }
    }
}
