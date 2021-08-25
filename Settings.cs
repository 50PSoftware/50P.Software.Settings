using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50P.Software.Settings.Dialogs
{
    public class Settings : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        [DefaultSettingValue("false")]
        public bool UseDatabase
        {
            get
            {
                return (bool)this["UseDatabase"];
            }
            set
            {
                this["UseDatabase"] = (bool)value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue(null)]
        public string Filename
        {
            get
            {
                return (string)this["Filename"];
            }
            set
            {
                this["Filename"] = (string)value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue(null)]
        public string Server
        {
            get
            {
                return (string)this["Server"];
            }
            set
            {
                this["Server"] = (string)value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue(null)]
        public string DatabaseName
        {
            get
            {
                return (string)this["DatabaseName"];
            }
            set
            {
                this["DatabaseName"] = (string)value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue(null)]
        public string Username
        { 
            get
            {
                return (string)this["Username"];
            }
            set
            {
                this["Username"] = (string)value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue(null)]
        public byte[] Password
        {
            get
            {
                return (byte[])this["Password"];
            }
            set
            {
                this["Password"] = (byte[])value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue(null)]
        public string Type
        {
            get
            {
                return (string)this["Type"];
            }
            set
            {
                this["Type"] = (string)value;
            }
        }
    }
}
