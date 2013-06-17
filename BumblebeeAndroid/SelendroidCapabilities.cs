using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;

namespace BumblebeeAndroid
{
    public class SelendroidCapabilities : DesiredCapabilities
    {
        /*map.Add("emulator", true);
            map.Add("locale", "en_US");
            map.Add("androidTarget", "ANDROID17");
            map.Add("aut", "io.selendroid.testapp:0.4-SNAPSHOT");*/

        public SelendroidCapabilities()
        {
            SetAndroidTarget(AndroidTarget.ANDROID17);
            SetLocale("en_US");
        }

        public SelendroidCapabilities SetEmulator(bool emulator)
        {
            SetCapability("emulator", emulator);
            return this;
        }

        public SelendroidCapabilities SetLocale(string locale)
        {
            SetCapability("locale", "en_US");
            return this;
        }

        public SelendroidCapabilities SetAndroidTarget(AndroidTarget target)
        {
            SetCapability("androidTarget", target.ToString());
            return this;
        }

        public SelendroidCapabilities SetApp(string app)
        {
            SetCapability("aut", app);
            return this;
        }
    }

    public enum AndroidTarget
    {
        ANDROID10,
        ANDROID11,
        ANDROID12,
        ANDROID13,
        ANDROID14,
        ANDROID15,
        ANDROID16,
        ANDROID17
    }
}
