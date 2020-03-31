
public interface ISettingsService
{
    void Update(SettingsType type);
    ApplicationConfig Get();
}
