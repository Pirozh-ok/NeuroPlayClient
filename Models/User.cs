namespace NeuroPlayClient.Models {
    enum UserType {
        Elementary,
        Experienced,
        Advanced
    }

    public class User {
        string Id { get; set; }
        string Name { get; set; }
        public uint Age { get; set; }
        UserType UserType { get; set; }
    }
}
