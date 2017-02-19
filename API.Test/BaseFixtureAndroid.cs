using System;
using API.Android.UI;
using Mobile.Framework;
using NUnit.Framework;

namespace API.Test
{
    [TestFixture]
    public class BaseFixtureAndroid
    {
        [SetUp]
        public void SetUp()
        {
            Uri remoteAddress = new Uri("http://127.0.0.1:4723/wd/hub");
            Manager.SetRemoteAddress(remoteAddress);
            Manager.SetCapability("platformName", "Android");
            Manager.SetCapability("platformVersion", "");
            Manager.SetCapability("deviceName", "Android Emulator");
            Manager.SetCapability("app", @"P:\GitHub\mobile_framework\apps\api.apk");
            Manager.SetCapability("fullReset", "true");
            //Manager.SetCapability("avd", "Nex7_6_32"); // for emulator
            Manager.SetCapability("udid", "emulator-5554"); // Baytrail132BC072 or emulator-5554 (my devices)
            Manager.InitializeAndroid();
        }

        [Test]
        public void TestAccessibility()
        {
            Screens.ScreenApiDemos.BtnAccessibility.Click();
            Manager.Driver.Back();
        }

        [Test]
        public void TestAnimation()
        {
            Screens.ScreenApiDemos.BtnAnimation.Click();
            Manager.Driver.Back();
        }

        [Test]
        public void TestApp()
        {
            Screens.ScreenApiDemos.BtnApp.Click();
            Manager.Driver.Back();
        }

        [Test]
        public void TestContent()
        {
            Screens.ScreenApiDemos.BtnContent.Click();
            Manager.Driver.Back();
        }

        [Test]
        public void TestGraphics()
        {
            Screens.ScreenApiDemos.BtnGraphics.Click();
            Manager.Driver.Back();
        }

        [Test]
        public void TestMedia()
        {
            Screens.ScreenApiDemos.BtnMedia.Click();
            Manager.Driver.Back();
        }

        [Test]
        public void TestNfc()
        {
            Screens.ScreenApiDemos.BtnNfc.Click();
            Manager.Driver.Back();
        }

        [Test]
        public void TestOs()
        {
            Screens.ScreenApiDemos.BtnOs.Click();
            Manager.Driver.Back();
        }

        [Test]
        public void TestPreference()
        {
            Screens.ScreenApiDemos.BtnPreference.Click();
            Manager.Driver.Back();
        }

        [Test]
        public void TestText()
        {
            Screens.ScreenApiDemos.BtnText.Click();
            Manager.Driver.Back();
        }

        [Test]
        public void TestViews()
        {
            Screens.ScreenApiDemos.BtnViews.Click();
            Manager.Driver.Back();
        }

        [TearDown]
        public void TearDown()
        {
            Manager.Driver.Quit();
        }
    }
}
