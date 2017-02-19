using System;
using System.Threading;
using API.Ios.UI;
using Mobile.Framework;
using NUnit.Framework;

namespace API.Test
{
    [TestFixture]
    public class BaseFixtureIos
    {
        [SetUp]
        public void SetUp()
        {
            Uri remoteAddress = new Uri("http://192.168.0.107:4723/wd/hub");
            Manager.SetRemoteAddress(remoteAddress);
            Manager.SetCapability("platformName", "ios");
            Manager.SetCapability("platformVersion", "9.3");
            Manager.SetCapability("deviceName", "iPhone 5s");
            Manager.SetCapability("app", @"https://github.com/appium/tutorial/raw/master/projects/ruby_ios/UICatalog6.1.app.zip");
            Manager.SetCapability("fullReset", "true");
            // Manager.SetCapability("udid", "iPhone 5"); // only for real
            Manager.InitializeIos();
        }

        [Test]
        public void TestButtons()
        {
            Screens.ScreenApiDemos.BtnButtons.Click();
            Manager.Driver.Back();
        }

        [Test]
        public void TestControls()
        {
            Screens.ScreenApiDemos.BtnControls.Click();
            Manager.Driver.Back();
        }

        [TearDown]
        public void TearDown()
        {
            //Manager.Driver.Quit();
        }
    }
}
