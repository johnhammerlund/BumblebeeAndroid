using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Bumblebee.Setup;
using MbUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace BumblebeeAndroid
{
    internal class DeleteMe
    {
        private readonly ThreadLocal<Session> _threadLocalSession = new ThreadLocal<Session>();

        public Session Session
        {
            get { return _threadLocalSession.Value; }
            set { _threadLocalSession.Value = value; }
        }

        [SetUp]
        public void Setup()
        {
            Dictionary<string, object> map = new Dictionary<string, object>();

            map.Add("emulator", true);
            map.Add("locale", "en_US");
            map.Add("androidTarget", "ANDROID17");
            map.Add("aut", "io.selendroid.testapp:0.4-SNAPSHOT");

            var cap = new DesiredCapabilities(map);

            Session = new AndroidSession(new AndroidEnvironment(cap, "http://10.10.230.184:5555/wd/hub"));
        }

        [Test, Parallelizable]
        public void StartAvd()
        {
            Session.Driver.FindElement(By.Id("my_text_field")).SendKeys("Fuck yeah");
            Thread.Sleep(5000);
        }

        [Test, Parallelizable]
        public void ParallelTest()
        {
            Session.Driver.FindElement(By.Id("my_text_field")).SendKeys("More awesomeness");
            Thread.Sleep(5000);
        }


        [TearDown]
        public void TearDown()
        {
            Session.End();
        }
    }
}
