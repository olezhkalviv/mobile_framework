using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;

namespace Mobile.Framework.ManagerParts
{
    public class Waiter
    {
        internal WebDriverWait Wrapper;

        public Waiter(AppiumDriver<AppiumWebElement> driver, TimeSpan timeout)
        {
            Wrapper = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
        }

        public TimeSpan Timeout
        {
            get { return Wrapper.Timeout; }
            set { Wrapper.Timeout = value; }
        }

        public void ForElementVisible(Search locator)
        {
            Wrapper.Until(ExpectedConditions.ElementIsVisible(locator.Wrapper));
        }

        public void ForElementInvisible(Search locator)
        {
            Wrapper.Until(ExpectedConditions.InvisibilityOfElementLocated(locator.Wrapper));
        }
    }
}
