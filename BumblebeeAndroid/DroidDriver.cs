using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace BumblebeeAndroid
{
    public class DroidDriver : RemoteWebDriver, IHasTouchScreen, ITakesScreenshot
    {
        private string _remoteAddr = "http://127.0.0.1:4444/wd/hub";

        public DroidDriver(ICommandExecutor commandExecutor, ICapabilities desiredCapabilities) : base(commandExecutor, desiredCapabilities)
        {
            TouchScreen = new RemoteTouchScreen(this);
        }

        public DroidDriver(ICapabilities desiredCapabilities) : base(desiredCapabilities)
        {
            TouchScreen = new RemoteTouchScreen(this);
        }

        public DroidDriver(Uri remoteAddress, ICapabilities desiredCapabilities) : base(remoteAddress, desiredCapabilities)
        {
            _remoteAddr = remoteAddress.ToString();
            TouchScreen = new RemoteTouchScreen(this);
        }

        public DroidDriver(Uri remoteAddress, ICapabilities desiredCapabilities, TimeSpan commandTimeout) : base(remoteAddress, desiredCapabilities, commandTimeout)
        {
            _remoteAddr = remoteAddress.ToString();
            TouchScreen = new RemoteTouchScreen(this);
        }

        public ITouchScreen TouchScreen { get; private set; }

        public Screenshot GetScreenshot()
        {
            String base64 = Execute(DriverCommand.Screenshot, null).Value.ToString();
            return new Screenshot(base64);
        }

        public string GetSessionId()
        {
            return SessionId.ToString();
        }

        public string GetRemoteAddress()
        {
            return _remoteAddr;
        }
    }
}
