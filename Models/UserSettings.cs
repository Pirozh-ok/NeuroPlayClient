namespace NeuroPlayClient.Models {
    public class UserSettings {
        public string ExperimentId { get; set; }
        public string Name { get; set; }
        public uint Age { get; set; }
        public UserType UserType { get; set; }
        public bool RememberMe { get; set; }
        public Cases Case { get; set; } = Cases.Figurs;
    }
}
