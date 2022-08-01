using System;
using Mongo.CertificationProject.API.DAL.Configuration;
using MongoDB.Bson.Serialization.Attributes;

namespace Mongo.CertificationProject.API.Entities
{
    [BsonCollection("planes")]
    public class Plane
    {
        [BsonElement("_id")]
        [BsonId]
        public string Id { get; set; }

        [BsonElement("route")]
        public string[] Route { get; set; }

        [BsonElement("heading")]
        public float Heading { get; set; }

        [BsonElement("currentLocation")]
        public double[] CurrentLocation { get; set; }

        [BsonElement("landed")]
        public string Landed { get; set; }

        [BsonElement("maintenanceRequired")]
        public bool MaintenanceRequired { get; set; }

        [BsonElement("landedDate")]
        public DateTime LandedDate { get; set; }

    }
}
