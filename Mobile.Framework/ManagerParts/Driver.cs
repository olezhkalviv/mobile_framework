using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Appium;

namespace Mobile.Framework.ManagerParts
{
    public class Driver
    {
        internal AppiumDriver<AppiumWebElement> Wrapper { get; private set; }

        public Driver(AppiumDriver<AppiumWebElement> driver)
        {
            Wrapper = driver;
        }

        public void Quit()
        {
            Wrapper.Quit();
        }

        public void Back()
        {
            Wrapper.Navigate().Back();
        }

        public MobileElement FindElement(MobileSearch locator)
        {
            MobileElement element = new MobileElement(Wrapper.FindElement(locator.Wrapper));
            return element;
        }

        public List<MobileElement> FindElements(MobileSearch locator)
        {
            List<MobileElement> elements = new List<MobileElement>();
            Wrapper.FindElements(locator.Wrapper).ToList().ForEach(e => elements.Add(new MobileElement(e)));
            return elements;
        }

        public void SetImplicitWait(int seconds)
        {
            Wrapper.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(seconds));
        }
    }
}
