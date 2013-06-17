using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading;
using Bumblebee.Setup;
using BumblebeeAndroid.Tests.PageObjects;
using MbUnit.Framework;
using OpenQA.Selenium;
using Bumblebee.Extensions;
using BumblebeeAndroid.Exentions;
using OpenQA.Selenium.Remote;

namespace BumblebeeAndroid.Tests
{
    public class DeleteMe
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

            /*map.Add("emulator", true);
            map.Add("locale", "en_US");
            map.Add("androidTarget", "ANDROID17");
            map.Add("aut", "io.selendroid.testapp:0.4-SNAPSHOT");*/

            map.Add("device", "Android");
            map.Add("browserName", "");
            map.Add("platform", "MAC");
            //map.Add("app", "/Users/john.hammerlund/Desktop/AndroidAutomation/selendroid-test-app-0.4-SNAPSHOT.apk");
            map.Add("app-package", "io.selendroid.testapp");
            map.Add("app-activity", "HomeScreenActivity");

            var capabilities = new AppiumDroidCapabilities().SetAppActivity("HomeScreenActivity")
                                                       .SetAppPackage("io.selendroid.testapp")
                                                       .SetPlatform("MAC")
                                                       .SetBrowserName("")
                                                       .SetDevice("Android");

            Session = new AndroidSession(new RemoteAndroidEnvironment(capabilities, "http://10.211.55.2:4723/wd/hub"));
        }

        [Test, Parallelizable]
        public void StartAvd()
        {
            Session.Driver.FindElement(By.Name("my_text_fieldCD")).SendKeys("Aw yis");
            Session.CurrentBlock<HomeView>().ChangeOrientation().ToPortrait();
            Console.WriteLine(Session.Driver.PageSource);
            Thread.Sleep(5000);
        }

        [TearDown]
        public void TearDown()
        {
            Session.End();
        }
    }
}
