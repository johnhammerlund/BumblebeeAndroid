using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading;
using Bumblebee.Setup;
using MbUnit.Framework;
using OpenQA.Selenium;
using Bumblebee.Extensions;
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

            var capabilities = new AppiumCapabilities().SetAppActivity("HomeScreenActivity")
                                                       .SetAppPackage("io.selendroid.testapp")
                                                       .SetPlatform("MAC")
                                                       .SetBrowserName("")
                                                       .SetDevice("Android");

            var cap = new DesiredCapabilities(map);

            Session = new AndroidSession(new RemoteAndroidEnvironment(capabilities, "http://10.211.55.2:4723/wd/hub"));
        }

        [Test, Parallelizable]
        public void StartAvd()
        {
            Session.Driver.FindElement(By.Name("my_text_fieldCD")).SendKeys("Aw yis");

            Console.WriteLine(Session.Driver.PageSource);
            Thread.Sleep(5000);
        }

        [Test, Parallelizable]
        public void ParallelTest()
        {
            Session.Driver.FindElement(By.Id("my_text_field")).SendKeys("More awesomeness");

            long start = System.DateTime.Now.Millisecond;
            Console.Write(AsHexString(((ITakesScreenshot) Session.Driver).GetScreenshot().AsByteArray));
            long end = System.DateTime.Now.Millisecond;

            Console.WriteLine("This extremely efficient method took " + (end - start) + " seconds");
            Thread.Sleep(5000);
        }

        public string AsHexString(byte[] arr)
        {
            string values = "0123456789abcdef";

            int count = 1;
            string output = "";

            foreach(byte b in arr)
            {
                var first = b >> 4;
                var second = b & 15;

                output += values[first];
                output += values[second];
                if (count%16 == 0)
                {
                    output += "\n";
                } else if (count%2 == 0)
                {
                    output += " ";
                }
                count++;
            }

            return output;
        }


        [TearDown]
        public void TearDown()
        {
            Session.End();
        }
    }
}
