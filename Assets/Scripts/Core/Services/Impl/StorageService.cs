using System.Collections.Generic;

public class StorageService : IStorageService
{
    private Dictionary<string, object> _memoryStorage = new Dictionary<string, object>();

    public TData GetData<TData>(string key)
    {
        return (TData)_memoryStorage[key];
    }

    public void SaveData<TData>(string key, TData data)
    {
        if (_memoryStorage.ContainsKey(key))
        {
            _memoryStorage[key] = data;
        }
        else
        {
            _memoryStorage.Add(key, data);
        }
    }
}
