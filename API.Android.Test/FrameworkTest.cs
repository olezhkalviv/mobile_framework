using System;
using System.Collections.Generic;
using Mobile.Framework;
using Mobile.Framework.ManagerParts;
using NUnit.Framework;

namespace API.Android.Test
{
    [TestFixture]
    public class FrameworkTest
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
        public void LaunchSimpleApp()
        {
            List<string> cellNames = new List<string>();
            foreach (var cell in Manager.Driver.FindElements(MobileSearch.ClassName("android.widget.TextView")))
            {
                cellNames.Add(cell.GetAttribute("name"));
            }

            // delete title cell
            cellNames.RemoveAt(0);

            foreach (string cellName in cellNames)
            {
                Manager.Driver.SetImplicitWait(0);
                Manager.Driver.FindElement(MobileSearch.Name(cellName)).Click();
                Manager.Waiter.ForElementInvisible(MobileSearch.Name(cellName));
                Manager.Driver.Back();
                Manager.Waiter.ForElementVisible(MobileSearch.Name("Accessibility"));
                Manager.Waiter.ForElementVisible(MobileSearch.Name("Animation"));
                Manager.Driver.SetImplicitWait(30);
            }
        }

        [TearDown]
        public void TearDown()
        {
            Manager.Driver.Quit();
        }
    }
}
