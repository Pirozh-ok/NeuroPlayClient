using System.Threading.Tasks;

namespace NeuroPlayClient.Services {
    public interface INeuroPlayService {
        Task<bool> IsConnectedAsync();
        Task StartRecordAsync();
        Task StopRecordAsync();
        Task AddMarkerAsync(string position, string text);
    }
}
