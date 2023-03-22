using NeuroPlayClient.Resources;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace NeuroPlayClient.Services {
    public class NeuroPlayService : INeuroPlayService {

        public async Task<bool> IsConnectedAsync() {
            using (var client = new HttpClient()) {
                var result = await client.GetAsync(Urls.GetCurrentDevice);
                //var obj = JsonConvert.DeserializeObject(result.Content);
                //if ((bool)obj.GetField("result")) {
                //    return true;
                //}
                return true;
            }
        }

        public async Task StartRecordAsync() {
            using (var client = new HttpClient()) {
                await client.GetAsync(Urls.StartRecord);
            }
        }

        public async Task StopRecordAsync() {
            using (var client = new HttpClient()) {
                await client.GetAsync(Urls.StopRecord);
            }
        }

        public async Task AddMarkerAsync(string position, string text) {
            using (var client = new HttpClient()) {
                await client.GetAsync($"http://127.0.0.1:2336/AddEDFAnnotation?pos={position}&text={text}");
            }
        }
    }
}
