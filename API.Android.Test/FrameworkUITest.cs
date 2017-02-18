using System;
using API.Android.UI;
using Mobile.Framework;
using NUnit.Framework;

namespace API.Android.Test
{
    [TestFixture]
    public class FrameworkUiTest
    {
        [SetUp]
        public void SetUp()
        {
            Uri remoteAddress = new Uri("http://127.0.0.1:4723/wd/hub");
            string appiumVersion = "1.1.0";
            string platformName = "Android";
            string deviceName = "Android";
            string platformVersion = "4.3";
            string name = "C# Android tutorial";
            string app = @"P:\GitHub\appium_android\apps\api.apk";

            Manager.SetRemoteAddress(remoteAddress);
            Manager.SetCapability("appium-version", appiumVersion);
            Manager.SetCapability("platformName", platformName);
            Manager.SetCapability("deviceName", deviceName);
            Manager.SetCapability("platformVersion", platformVersion);
            Manager.SetCapability("name", name);
            Manager.SetCapability("app", app);
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
