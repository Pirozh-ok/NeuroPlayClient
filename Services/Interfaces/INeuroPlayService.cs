using System.IO;
using System.Threading.Tasks;

namespace NeuroPlayClient.Services {
    public interface INeuroPlayService {
        Task<bool> IsConnectedAsync();
        Task StartRecordAsync();
        Task StopRecordAsync();
        //Task<bool> AddMarkerAsync(string position, string text);
        Task<string> AddMarkerAsync(string position, string text);
    }
}
