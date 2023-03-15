namespace NeuroPlayClient.Models {
    public class UserSettings {
        public string Id { get; set; }
        public string Name { get; set; }
        public uint Age { get; set; }
        public UserType UserType { get; set; }
        public bool RememberMe { get; set; }
    }
}
