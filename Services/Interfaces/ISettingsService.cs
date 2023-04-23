using NeuroPlayClient.Models;
using System.Threading.Tasks;

namespace NeuroPlayClient.Services.Interfaces {
    public interface ISettingsService {
        ServiceResult SetUserSettings(UserSettings settings);
        ServiceResult IncrementIdExperiment();
        ServiceResult<string> GetExperimentId();
        ServiceResult<string> GetSettingsToString();
        ServiceResult<UserSettings> GetSettings();
    }
}
