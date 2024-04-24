using System.Collections.Generic;

namespace Mongo.Application.Common.Responses
{
    public class ARSResponse
    {
        public string Id { get; set; }
        public string CAMERA_ID { get; set; }
        public int INTERVAL_TIME { get; set; }
        public string START_TIME { get; set; }
        public string SEND_TIME { get; set; }
        public int TOTAL_LANE_NUM { get; set; }
        public List<LANEResponse> LANES { get; set; }
    }
}
