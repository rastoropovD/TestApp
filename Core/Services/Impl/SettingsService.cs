using Core.Models;
using Zenject;

namespace Core.Services.Impl
{
    public class SettingsService : ISettingsService
    {
        private readonly IStorageService _storageService;

        [Inject]
        public SettingsService(IStorageService storageService)
        {
            _storageService = storageService;
        }

        public ApplicationConfig Get()
        {
            return _storageService.GetData<ApplicationConfig>("settings");
        }

        public void Save(ApplicationConfig config)
        {
            _storageService.SaveData(config, "settings");
        }
    }
}
