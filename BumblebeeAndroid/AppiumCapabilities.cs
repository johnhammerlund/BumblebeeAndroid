using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;

namespace BumblebeeAndroid
{
    public class AppiumCapabilities : DesiredCapabilities
    {
        /*internal string DEVICE = "Android";
        internal string BROWSER_NAME = "";
        internal string PLATFORM = "MAC";
        internal string VERSION;
        internal string APP;
        internal string APP_PACKAGE;
        internal string APP_ACTIVITY;*/

        public AppiumCapabilities()
        {
            SetCapability("device", "Android");
            SetCapability("platform", "MAC");
            SetCapability("browserName", "");
        }

        public AppiumCapabilities SetDevice(string device)
        {
            SetCapability("device", device);
            return this;
        }

        public AppiumCapabilities SetBrowserName(string browserName)
        {
            SetCapability("browserName", browserName);
            return this;
        }

        public AppiumCapabilities SetPlatform(string platform)
        {
            SetCapability("platform", platform);
            return this;
        }

        public AppiumCapabilities SetVersion(string version)
        {
            SetCapability("version", version);
            return this;
        }

        public AppiumCapabilities SetApp(string app)
        {
            SetCapability("app", app);
            return this;
        }

        public AppiumCapabilities SetAppPackage(string appPackage)
        {
            SetCapability("app-package", appPackage);
            return this;
        }

        public AppiumCapabilities SetAppActivity(string appActivity)
        {
            SetCapability("app-activity", appActivity);
            return this;
        }
    }
}
