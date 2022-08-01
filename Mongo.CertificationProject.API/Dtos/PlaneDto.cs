using Newtonsoft.Json;

namespace Mongo.CertificationProject.API.Dtos
{
    public class PlaneDto
    {
        [JsonProperty("callsign")]
        public string Callsign { get; set; }

        [JsonProperty("currentLocation")]
        public double[] CurrentLocation { get; set; }

        [JsonProperty("heading")]
        public float Heading { get; set; }

        [JsonProperty("landed")]
        public string Landed { get; set; }

        [JsonProperty("route")]
        public string[] Route { get; set; }

        [JsonProperty("maintenanceRequired")]
        public bool MaintenanceRequired { get; set; }
    }
}
