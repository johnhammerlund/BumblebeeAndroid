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
            TouchScreen = new RemoteTouchScreen(this);
        }

        public DroidDriver(Uri remoteAddress, ICapabilities desiredCapabilities, TimeSpan commandTimeout) : base(remoteAddress, desiredCapabilities, commandTimeout)
        {
            TouchScreen = new RemoteTouchScreen(this);
        }

        public ITouchScreen TouchScreen { get; private set; }

        public Screenshot GetScreenshot()
        {
            String base64 = Execute(DriverCommand.Screenshot, null).Value.ToString();
            return new Screenshot(base64);
        }
    }
}
