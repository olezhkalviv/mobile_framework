using System;
using Mobile.Framework;
using NUnit.Framework;
using Web.UI;

namespace Web.Test
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
            Manager.SetCapability("browserName", "Safari");
            Manager.SetCapability("fullReset", "true");
            // Manager.SetCapability("udid", ""); // only for real
            Manager.InitializeIos();
            Manager.Driver.GoToUrl("http://google.com/");
        }

        [Test]
        public void TestGoogle()
        {
            Pages.PageGoogle.TxtSearch.SendKeys("Appium");
            Pages.PageGoogle.BtnSearch.Click();
            Assert.AreEqual("Appium: Mobile App Automation Made Awesome.", Pages.PageGoogle.GetFirstLinkText());
        }

        [TearDown]
        public void TearDown()
        {
            Manager.Driver.Quit();
        }
    }
}
