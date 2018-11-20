using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RefactorDemo.Interfaces
{
    public interface ISettingsService
    {
        string AuthToken { get; set; }

        bool GetValueOrDefault(string key, bool defaultValue);
        string GetValueOrDefault(string key, string defaultValue);
        Task AddOrUpdateValue(string key, bool value);
        Task AddOrUpdateValue(string key, string value);
    }
}
