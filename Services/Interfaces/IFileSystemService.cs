using NeuroPlayClient.Models;
using System.Threading.Tasks;

namespace NeuroPlayClient.Services.Interfaces {
    public interface IFileSystemService {
        Task<ServiceResult> ReadUserSettingsFromFile();
        Task<ServiceResult> SaveUserSettingsToFile(UserSettings data);
        Task<ServiceResult> SaveUserExperimentToFile();
    }
}
