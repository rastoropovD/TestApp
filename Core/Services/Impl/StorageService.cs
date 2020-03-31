using System;

namespace Core.Services.Impl
{
    public class StorageService : IStorageService
    {
        public TData GetData<TData>(string key)
        {
            throw new NotImplementedException();
        }

        public void SaveData<TData>(TData toSave, string key)
        {
            throw new NotImplementedException();
        }
    }
}
