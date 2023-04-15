using NeuroPlayClient.Models;
using NeuroPlayClient.Resources;
using NeuroPlayClient.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace NeuroPlayClient.Services.Implementations {
    public class FileSystemService : IFileSystemService {
        private StreamWriter _logger;

        public ServiceResult CloseLoggerConnection() {
            try {
                _logger.Close();
                return new ServiceResult(true);
            }
            catch {
                return new ServiceResult(false, new List<string>() { Messages.LoggerConnectError });
            }
        } 

        public ServiceResult OpenLoggerConnection() {
            try {
                _logger = new StreamWriter("../../logs.txt", false);
                return new ServiceResult(true);
            }
            catch {
                return new ServiceResult(false, new List<string>() { Messages.LoggerCloseError });
            }
        }

        public async Task<ServiceResult> ReadUserSettingsFromFile() {
            try {
                using (var sr = new StreamReader(Messages.userDataPath)) {
                    var json = await sr.ReadToEndAsync();
                    var user = JsonConvert.DeserializeObject<UserSettings>(json);
                    return new ServiceResult<UserSettings>(true, user);
                }
            }
            catch (Exception ex){
                return new ServiceResult(false, new List<string>() { ex.Message });
            }
        }

        public async Task<ServiceResult> SaveUserExperimentToFile() {
            throw new System.NotImplementedException();
        }

        public async Task<ServiceResult> SaveUserSettingsToFile(UserSettings data) {
            try {
                var json = JsonConvert.SerializeObject(data);

                using (var sw = new StreamWriter(Messages.userDataPath)) {
                    await sw.WriteAsync(json);
                }

                return new ServiceResult(true);
            }
            catch (Exception ex) {
                return new ServiceResult(false, new List<string>() { ex.Message });
            }

        }

        public async Task<ServiceResult> WriteLogAsync(string message) {
            try {
                await _logger.WriteAsync(message);
                return new ServiceResult(true);
            }
            catch {
                return new ServiceResult(false);
            }
        }
    }
}
