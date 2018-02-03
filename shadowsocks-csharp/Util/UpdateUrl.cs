using System;
using System.Diagnostics;
using System.IO;
using Shadowsocks.Controller;
using Shadowsocks.Properties;
using Shadowsocks.Model;
using System.Text;

namespace Shadowsocks.Util
{
    public  class UpdateUrl
    {
        private const string _updateUrlConfigFile = "update-url.json";

        private static UpdateUrlConfig _updateConifg = null;
        public static UpdateUrlConfig URLConfig
        {
            get
            {
                if (_updateConifg == null)
                    _updateConifg = new UpdateUrlConfig();
                return _updateConifg;
            }
        }
        public UpdateUrl()
        {
            
        }

        public void Save()
        {
            try
            {
                string _path = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, _updateUrlConfigFile);
                using (StreamWriter sw = new StreamWriter(File.Open(_path, FileMode.Create)))
                {
                    string jsonString = SimpleJson.SimpleJson.SerializeObject(_updateConifg);
                    sw.Write(jsonString);
                    sw.Flush();
                }
            }
            catch (IOException e)
            {
                Logging.LogUsefulException(e);
            }
        }

        public bool Load()
        {
            try
            {
                string _fullpath= System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, _updateUrlConfigFile);
                if (!File.Exists(_fullpath))
                {
                    if (_updateConifg == null)
                        _updateConifg = new UpdateUrlConfig();
                    Save();
                }
                else
                {
                    string configContent = File.ReadAllText(_fullpath);
                    _updateConifg = SimpleJson.SimpleJson.DeserializeObject<UpdateUrlConfig>(configContent);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        private static UpdateUrl _instance = null;
        public static UpdateUrl Instance()
        {
            if (_instance==null)
            {
                _instance = new UpdateUrl();
            }
            return _instance;
        }
    }
}
