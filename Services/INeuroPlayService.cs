using System.Threading.Tasks;

namespace NeuroPlayClient.Services {
    internal interface INeuroPlayService {
        bool IsConnected();
        Task<int> GetCountDevices();
        void StartRecord();
        void StopRecord();
        void AddMarker();
    }
}
