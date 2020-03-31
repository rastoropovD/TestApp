using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface ISettingsService
    {
        void Save(ApplicationConfig config);
        ApplicationConfig Get();
    }
}
