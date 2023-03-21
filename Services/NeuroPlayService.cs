using NeuroPlayClient.Resources;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace NeuroPlayClient.Services {
    public class NeuroPlayService : INeuroPlayService {

        public Task AddMarkerAsync() {
            throw new System.NotImplementedException();
        }

        public async Task<bool> IsConnectedAsync() {
            using (var client = new HttpClient()) {
                var result = await client.GetAsync(Urls.GetCurrentDevice);
                var obj = JsonConvert.DeserializeObject(result.Content);
                if ((bool)obj.GetField("result")) {
                    return true;
                }
                return true;
            }
        }

        public Task StartRecordAsync() {
            throw new System.NotImplementedException();
        }

        public Task StopRecordAsync() {
            throw new System.NotImplementedException();
        }
    }
}
