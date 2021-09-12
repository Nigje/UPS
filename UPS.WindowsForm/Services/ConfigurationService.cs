using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPS.WindowsForm.Models;
using UPS.WindowsForm.Models.Enums;

namespace UPS.WindowsForm.Services
{
    public class ConfigurationService
    {
        //************************************************************************************************************************************
        //Variables:
        private static readonly ConfigurationService _configurationService;
        private static Dictionary<string, string> _cache = new Dictionary<string, string>();
        private static readonly List<PairValue<GenderEnum>> _genderList;
        private static readonly List<PairValue<StatusEnum>> _statusList;
        //************************************************************************************************************************************
        static ConfigurationService()
        {
            _configurationService = new ConfigurationService();

            _genderList = new List<PairValue<GenderEnum>>();
            _genderList.Add(new PairValue<GenderEnum> { Text = "Male", Value = GenderEnum.Male });
            _genderList.Add(new PairValue<GenderEnum> { Text = "Female", Value = GenderEnum.Female });

            _statusList = new List<PairValue<StatusEnum>>();
            _statusList.Add(new PairValue<StatusEnum> { Text = "Active", Value = StatusEnum.Active });
            _statusList.Add(new PairValue<StatusEnum> { Text = "InActive", Value = StatusEnum.InActive });

        }
        //************************************************************************************************************************************
        private ConfigurationService()
        {
            foreach (var key in ConfigurationManager.AppSettings.AllKeys)
            {
                if (!_cache.ContainsKey(key))
                    _cache.Add(key, ConfigurationManager.AppSettings[key]);
            }
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Return the ConfigurationService instance.
        /// </summary>
        /// <returns></returns>
        public static ConfigurationService GetInstance()
        {
            return _configurationService;
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Read and return value from app.config.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string Get(string key)
        {
            if (_cache.ContainsKey(key))
                return _cache[key];
            throw new KeyNotFoundException();
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Write the key and value in app.config and cache.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Set(string key, string value)
        {
            if (!_cache.ContainsKey(key))
                _cache.Add(key, value);
            else
                _cache[key] = value;
            AddOrUpdateAppSettings(key, value);
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Return gender list.
        /// </summary>
        /// <returns></returns>
        public List<PairValue<GenderEnum>> GetGenderList()
        {
            return _genderList;
        }
        //************************************************************************************************************************************
        /// <summary>
        /// return status list.
        /// </summary>
        /// <returns></returns>
        public List<PairValue<StatusEnum>> GetStatusList()
        {
            return _statusList;
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Update app.config.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void AddOrUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                throw new Exception("Error writing app settings");
            }
        }
        //************************************************************************************************************************************
    }
}
