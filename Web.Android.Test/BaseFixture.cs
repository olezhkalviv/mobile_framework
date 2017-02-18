using System;
using Mobile.Framework;
using NUnit.Framework;
using Web.Android.UI;

namespace Web.Android.Test
{
    [TestFixture]
    public class BaseFixture
    {
        [SetUp]
        public void SetUp()
        {
            Uri remoteAddress = new Uri("http://127.0.0.1:4723/wd/hub");
            Manager.SetRemoteAddress(remoteAddress);
            Manager.SetCapability("automationName", "Appium");
            Manager.SetCapability("platformName", "Android");
            Manager.SetCapability("platformVersion", "");
            Manager.SetCapability("deviceName", "Android Emulator");
            Manager.SetCapability("browserName", "Browser"); // or Chrome if it is installed
            Manager.SetCapability("udid", "emulator-5554"); // Baytrail132BC072 or emulator-5554 (my devices)
            Manager.InitializeAndroid();
            Manager.Driver.GoToUrl("http://google.com/");
        }

        [Test]
        public void TestWeb()
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
