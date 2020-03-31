
public interface IStorageService
{
    void SaveData<TData>(string key, TData data);

    TData GetData<TData>(string key);
}