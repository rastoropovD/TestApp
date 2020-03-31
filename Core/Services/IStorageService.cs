using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IStorageService
    {
        void SaveData<TData>(TData toSave, string key);

        TData GetData<TData>(string key);
    }
}
