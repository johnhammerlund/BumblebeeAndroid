using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;

namespace BumblebeeAndroid
{
    public class AppiumDroidCapabilities : DesiredCapabilities
    {
        /*internal string DEVICE = "Android";
        internal string BROWSER_NAME = "";
        internal string PLATFORM = "MAC";
        internal string VERSION;
        internal string APP;
        internal string APP_PACKAGE;
        internal string APP_ACTIVITY;*/

        public AppiumDroidCapabilities()
        {
            SetDevice("Android");
            SetPlatform("MAC");
            SetBrowserName("");
        }

        public AppiumDroidCapabilities SetDevice(string device)
        {
            SetCapability("device", device);
            return this;
        }

        public AppiumDroidCapabilities SetBrowserName(string browserName)
        {
            SetCapability("browserName", browserName);
            return this;
        }

        public AppiumDroidCapabilities SetPlatform(string platform)
        {
            SetCapability("platform", platform);
            return this;
        }

        public AppiumDroidCapabilities SetVersion(string version)
        {
            SetCapability("version", version);
            return this;
        }

        public AppiumDroidCapabilities SetApp(string app)
        {
            SetCapability("app", app);
            return this;
        }

        public AppiumDroidCapabilities SetAppPackage(string appPackage)
        {
            SetCapability("app-package", appPackage);
            return this;
        }

        public AppiumDroidCapabilities SetAppActivity(string appActivity)
        {
            SetCapability("app-activity", appActivity);
            return this;
        }
    }
}
