using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Mongo.Core.Entities
{
    public partial class ARS
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string CAMERA_ID { get; set; }
        public int INTERVAL_TIME { get; set; }
        public string START_TIME { get; set; }
        public string SEND_TIME { get; set; }
        public int TOTAL_LANE_NUM { get; set; }
        public List<LANE> LANES { get; set; }
    }
}
