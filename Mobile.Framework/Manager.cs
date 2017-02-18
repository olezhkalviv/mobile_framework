﻿using System;
using Mobile.Framework.ManagerParts;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Remote;

namespace Mobile.Framework
{
    public class Manager
    {
        private const int ImplicitTimeoutSeconds = 60;
        private const int WaiterTimeoutSeconds = 5;

        internal static DesiredCapabilities DesiredCapabilities { get; private set; }
        internal static Uri RemoteAddress { get; private set; }
        internal static string AppPath { get; private set; }

        public static Driver Driver { get; private set; }
        public static Waiter Waiter { get; private set; }

        public static void InitializeAndroid(int implicitTimeoutSeconds = ImplicitTimeoutSeconds, int waiterTimeoutSeconds = WaiterTimeoutSeconds)
        {
            Driver = new Driver(new AndroidDriver<AppiumWebElement>(RemoteAddress, DesiredCapabilities, TimeSpan.FromSeconds(implicitTimeoutSeconds)));
            Waiter = new Waiter(Driver.Wrapper, TimeSpan.FromSeconds(waiterTimeoutSeconds));
        }

        public static void InitializeIos(int implicitTimeoutSeconds = ImplicitTimeoutSeconds, int waiterTimeoutSeconds = WaiterTimeoutSeconds)
        {
            Driver = new Driver(new IOSDriver<AppiumWebElement>(RemoteAddress, DesiredCapabilities, TimeSpan.FromSeconds(implicitTimeoutSeconds)));
            Waiter = new Waiter(Driver.Wrapper, TimeSpan.FromSeconds(waiterTimeoutSeconds));
        }

        public static void SetAppPath(string appPath)
        {
            AppPath = appPath;
        }

        public static void SetCapability(string capability, object capabilityValue)
        {
            if (DesiredCapabilities == null)
            {
                DesiredCapabilities = new DesiredCapabilities();
            }

            DesiredCapabilities.SetCapability(capability, capabilityValue);
        }

        public static void SetRemoteAddress(Uri uri)
        {
            RemoteAddress = uri;
        }
    }
}