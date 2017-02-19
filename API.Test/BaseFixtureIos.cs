using System;
using API.Android.UI;
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
            Uri remoteAddress = new Uri("http://192.168.0.108:4723/wd/hub");
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
        public void TestAccessibility()
        {

        }

        [TearDown]
        public void TearDown()
        {
            Manager.Driver.Quit();
        }
    }
}
