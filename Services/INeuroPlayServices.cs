namespace NeuroPlayClient.Services {
    internal interface INeuroPlayServices {
        bool IsConnected();
        int GetCountDevices();
        void StartRecord();
        void StopRecord();
        void AddMarker();
    }
}
