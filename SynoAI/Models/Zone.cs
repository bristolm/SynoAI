namespace SynoAI.Models
{
    public class Zone
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        public OverlapMode Mode { get; set; }
        public AIPrediction Prediction { get; set; }
        public int Detections { get; set; }
    }
}