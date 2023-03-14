namespace NeuroPlayClient.Models {
    public enum UserType {
        Elementary,
        Experienced,
        Advanced
    }

    public class User {
        public User(string id, string name, uint age, UserType userType) {
            Id = id;
            Name = name;
            Age = age;
            UserType = userType;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public uint Age { get; private set; }
        public UserType UserType { get; private set; }
    }
}
