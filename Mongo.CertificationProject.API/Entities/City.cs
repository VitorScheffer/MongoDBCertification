using Mongo.CertificationProject.API.DAL.Configuration;
using MongoDB.Bson.Serialization.Attributes;

namespace Mongo.CertificationProject.API.Entities
{
    [BsonCollection("cities")]
    public class City
    {
        [BsonElement("_id")]
        [BsonId]
        public string Id { get; set; }

        [BsonElement("country")]
        public string Country { get; set; }

        [BsonElement("position")]
        public double[] Position { get; set; }


    }
}
