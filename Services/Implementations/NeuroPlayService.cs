﻿using NeuroPlayClient.Models.JsonResponseModels;
using NeuroPlayClient.Resources;
using Newtonsoft.Json;
using System;
using System.Linq.Expressions;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace NeuroPlayClient.Services {
    public class NeuroPlayService : INeuroPlayService {

        public async Task<bool> IsConnectedAsync() {
            using (var client = new HttpClient()) {
                var response = await client.GetAsync(Urls.GetCurrentDevice);
                var result = JsonConvert.DeserializeObject<CurrentDeviceResponse>(await response.Content.ReadAsStringAsync());
                return result.result;
            }
        }

        public async Task StartRecordAsync() {
            using (var client = new HttpClient()) {
                var response = await client.GetAsync(Urls.StartRecord);
                var result = JsonConvert.DeserializeObject<StartRecordResponse>(await response.Content.ReadAsStringAsync());
            }
        }

        public async Task StopRecordAsync() {
            try {
                using (var client = new HttpClient()) {
                    var response = await client.GetAsync(@"http://127.0.0.1:2336/stopRecord");
                    var result = JsonConvert.DeserializeObject<StopRecordResponse>(await response.Content.ReadAsStringAsync());
                }
            }
            catch { }
        }

        public async Task<string> AddMarkerAsync(string position, string text) {
            using (var client = new HttpClient()) {
                //var response = await client.SendAsync(new HttpRequestMessage(HttpMethod.Get, $"http://127.0.0.1:2336/AddEDFAnnotation?text={text}&pos={position}"));
                var response = await client.GetAsync($"http://127.0.0.1:2336/AddEDFAnnotation?text={text}&pos={position}");
                //var result = JsonConvert.DeserializeObject<AddMarkerResponse>(await response.Content.ReadAsStringAsync());
                //return result.result;
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
