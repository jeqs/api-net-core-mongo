namespace Mongo.Application.Common.Responses
{
    public class LANEResponse
    {
        public int LANE_NO { get; set; }
        public int LANE_VOLUME { get; set; }
        public int LANE_VELOCITY { get; set; }
        public int HEADWAY_TIME { get; set; }
        public int HEADWAY_DISTANCE { get; set; }
        public decimal SPACE_OCCUPANCY { get; set; }
        public decimal TIME_OCCYPANCY { get; set; }
        public int MOTORCYCLE { get; set; }
        public int LIGHT_VEHICLE { get; set; }
        public int MIDDLE_VEHICLE { get; set; }
        public int HEAVY_VEHICLE { get; set; }
        public int STATE { get; set; }
        public int QUEUE_LENGHT { get; set; }
    }
}
