using System;
using Newtonsoft.Json;

namespace Mongo.CertificationProject.API.Dtos
{
    public class CargoDto
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("courier")]
        public string Courier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("received")]
        public DateTime? Received { get; set; }
    }
}
