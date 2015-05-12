using Windows.Storage;
using Windows.ApplicationModel;
using System;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Threading.Tasks;
using System.IO;

namespace Slack.Common
{
    public abstract class AppSettingsBase
    {
        protected ApplicationDataContainer localSettings { get { return ApplicationData.Current.LocalSettings; } }
        protected ApplicationDataContainer roamingSettings { get { return ApplicationData.Current.RoamingSettings; } }

        protected StorageFolder localFolder { get { return ApplicationData.Current.LocalFolder; } }
        protected StorageFolder roamingFolder { get { return ApplicationData.Current.RoamingFolder; } }

        public abstract uint Version { get; }

        protected AppSettingsBase() { }

        public abstract void Up();
        public abstract void Down();

        protected T GetValueOrDefault<T>(string key, T defaultValue, bool isRoaming = false)
        {
            try
            {
                var settings = isRoaming ? roamingSettings : localSettings;
                var value = settings.Values[key];

                //Debug.WriteLine("Value of {0} is {1}", key, value.ToString());
                if (value == null || String.IsNullOrEmpty(value.ToString())) return defaultValue;

                return value?.GetType() == typeof(string) ? (T)value : JsonConvert.DeserializeObject<T>(value.ToString());
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        protected bool SetValue<T>(string key, T value, bool isRoaming = false)
        {
            try
            {
                string content = value == null || value.GetType() == typeof(string) ? value?.ToString() : JsonConvert.SerializeObject(value);
                //Debug.WriteLine("SetValue of {0} to {1}", key, content);

                var settings = isRoaming ? roamingSettings : localSettings;
                settings.Values[key] = content;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        protected async Task<T> ReadFileOrDefault<T>(string fileName, T defaultValue, bool isRoaming = false)
        {
            try
            {
                var folder = isRoaming ? roamingFolder : localFolder;
                StorageFile file = await folder.CreateFileAsync(fileName, CreationCollisionOption.OpenIfExists);
                string json = await FileIO.ReadTextAsync(file);
                Debug.WriteLine("Content of {0} is {1}", fileName, json);

                if (String.IsNullOrEmpty(json)) return defaultValue;
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        protected async Task<bool> SaveFile<T>(string fileName, T value, bool isRoaming = false)
        {
            try
            {
                var folder = isRoaming ? roamingFolder : localFolder;
                StorageFile file = await folder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);

                string json = JsonConvert.SerializeObject(value);
                Debug.WriteLine("SaveFile {0} with {1}", fileName, json);

                await FileIO.WriteTextAsync(file, json);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}