using System.Runtime.InteropServices;

namespace NeuroPlayClient.Models {
    public class Settings1Experiment {
        public bool IsTime { get; set; }
        public int TimeInSecondsOrCountIteration { get; set; }
        public double DelayInSeconds { get; set; }
    }
}
