using NeuroPlayClient.Models;
using System.Threading.Tasks;

namespace NeuroPlayClient.Services.Interfaces {
    public interface IFileSystemService {
        Task<ServiceResult> ReadUserSettingsFromFile();
        Task<ServiceResult> SaveUserSettingsToFile(UserSettings data);
        Task<ServiceResult> SaveUserExperimentToFile();
        Task<ServiceResult> WriteLogAsync(string message);
        ServiceResult OpenLoggerConnection();
        ServiceResult CloseLoggerConnection();
    }
}
