using NeuroPlayClient.Resources;
using System.Net.Http;
using System.Threading.Tasks;

namespace NeuroPlayClient.Services {
    public class NeuroPlayServices : INeuroPlayServices {

        public void AddMarker() {
            throw new System.NotImplementedException();
        }

        public async Task<int> GetCountDevices() {
            using (var client = new HttpClient()) {
                var result = await client.GetAsync(Urls.GetCountDevices);
            };
        }

        public bool IsConnected() {
            throw new System.NotImplementedException();
        }

        public void StartRecord() {
            throw new System.NotImplementedException();
        }

        public void StopRecord() {
            throw new System.NotImplementedException();
        }
    }
}
