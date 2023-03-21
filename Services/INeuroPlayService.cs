using System.Threading.Tasks;

namespace NeuroPlayClient.Services {
    internal interface INeuroPlayService {
        Task<bool> IsConnectedAsync();
        Task StartRecordAsync();
        Task StopRecordAsync();
        Task AddMarkerAsync();
    }
}
