using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace SismosAntioquiaAPI.Models
{
    public class Sismo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("region")]
        public string Region { get; set; } = null!;

        [BsonElement("fechaHora")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime FechaHora { get; set; }

        [BsonElement("magnitud")]
        public double Magnitud { get; set; }

        [BsonElement("profundidad")]
        public double Profundidad { get; set; }

        [BsonElement("longitud")]
        public double Longitud { get; set; }

        [BsonElement("latitud")]
        public double Latitud { get; set; }
    }
}
