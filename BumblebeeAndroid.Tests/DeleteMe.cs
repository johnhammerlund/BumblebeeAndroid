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
            var capabilities = new AppiumDroidCapabilities().SetAppActivity("HomeScreenActivity")
                                                       .SetAppPackage("io.selendroid.testapp")
                                                       .SetPlatform("MAC")
                                                       .SetBrowserName("")
                                                       .SetDevice("Android");

            Session = new AndroidSession(new RemoteAndroidEnvironment(capabilities, "http://10.211.55.2:4724/wd/hub"));
        }

        [Test, Parallelizable]
        public void StartAvd()
        {
            Session.CurrentBlock<HomeView>()
                //.DebugPrint(homeView => Session.Driver.PageSource)
                   .AcceptAddsChk.Uncheck().AcceptAddsChk.Check()
                   .UserRegistrationBtn.Click().LanguageSelect.Options.Last().Click();
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
