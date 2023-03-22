using System;
using System.Runtime.InteropServices;

namespace NeuroPlayClient.Models {
    public class Settings1Experiment {
        public int TimeInSeconds { get; set; }
        public int CountIteration { get => (int)Math.Floor(TimeInSeconds / DelayInSeconds); }
        public double DelayInSeconds { get; set; }
    }
}
