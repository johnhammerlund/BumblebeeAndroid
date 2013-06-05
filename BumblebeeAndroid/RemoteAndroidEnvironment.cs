using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bumblebee.Setup;
using OpenQA.Selenium;
using OpenQA.Selenium.Android;
using OpenQA.Selenium.Remote;

namespace BumblebeeAndroid
{
    public class RemoteAndroidEnvironment : IDriverEnvironment
    {
        public RemoteAndroidEnvironment(DesiredCapabilities capabilites, string url)
        {
            _cap = capabilites;
            _url = url;
        }

        private DesiredCapabilities _cap { get; set; }

        private string _url { get; set; }

        public IWebDriver CreateWebDriver()
        {
            return new DroidDriver(new Uri(_url), _cap, TimeSpan.FromSeconds(120));
        }
    }
}
