using Zenject;

public class SettingsService : ISettingsService
{
    private readonly IStorageService _storageService;
    private const string _key = "settings";

    [Inject]
    public SettingsService(IStorageService storageService)
    {
        _storageService = storageService;
        _storageService.SaveData(_key, new ApplicationConfig());
    }

    public ApplicationConfig Get()
    {
        return _storageService.GetData<ApplicationConfig>(_key);
    }

    public void Update(SettingsType type)
    {
        var _config = _storageService.GetData<ApplicationConfig>(_key);
        switch (type)
        {
            case SettingsType.Sound:
                _config.IsSoundEnabled.SetValueAndForceNotify(!_config.IsSoundEnabled.Value);
                break;
            case SettingsType.Music:
                _config.IsMusicEnabled.SetValueAndForceNotify(!_config.IsMusicEnabled.Value);
                break;
        }
        _storageService.SaveData(_key, _config);
    }
}
