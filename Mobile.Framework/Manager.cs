using System;
using Mobile.Framework.ManagerParts;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Remote;

namespace Mobile.Framework
{
    public class Manager
    {
        internal Manager() { }

        private const int WaitForDeviceSeconds = 300;
        private const int ImplicitTimeoutSeconds = 30;
        private const int WaiterTimeoutSeconds = 30;

        internal static DesiredCapabilities DesiredCapabilities { get; private set; }
        internal static Uri RemoteAddress { get; private set; }

        public static Driver Driver { get; private set; }
        public static Factory Factory { get; private set; }
        public static Waiter Waiter { get; private set; }

        public static void InitializeAndroid(int implicitTimeoutSeconds = ImplicitTimeoutSeconds, int waiterTimeoutSeconds = WaiterTimeoutSeconds)
        {
            Driver = new Driver(new AndroidDriver<AppiumWebElement>(RemoteAddress, DesiredCapabilities, TimeSpan.FromSeconds(WaitForDeviceSeconds)));
            Factory = new Factory();
            Waiter = new Waiter(Driver.Wrapper, TimeSpan.FromSeconds(waiterTimeoutSeconds));
            Driver.SetImplicitWait(ImplicitTimeoutSeconds);
        }

        public static void InitializeIos(int implicitTimeoutSeconds = ImplicitTimeoutSeconds, int waiterTimeoutSeconds = WaiterTimeoutSeconds)
        {
            Driver = new Driver(new IOSDriver<AppiumWebElement>(RemoteAddress, DesiredCapabilities, TimeSpan.FromSeconds(WaitForDeviceSeconds)));
            Factory = new Factory();
            Waiter = new Waiter(Driver.Wrapper, TimeSpan.FromSeconds(waiterTimeoutSeconds));
            Driver.SetImplicitWait(ImplicitTimeoutSeconds);
        }

        public static void SetCapability(string capability, object capabilityValue)
        {
            DesiredCapabilities = DesiredCapabilities ?? new DesiredCapabilities();
            DesiredCapabilities.SetCapability(capability, capabilityValue);
        }

        public static void SetRemoteAddress(Uri uri)
        {
            RemoteAddress = uri;
        }
    }
}
