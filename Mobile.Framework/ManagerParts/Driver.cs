using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Appium;

namespace Mobile.Framework.ManagerParts
{
    public class Driver
    {
        internal Driver() { }

        internal Driver(AppiumDriver<AppiumWebElement> driver)
        {
            Wrapper = driver;
        }

        internal AppiumDriver<AppiumWebElement> Wrapper { get; }

        public string Title => Wrapper.Title;

        public void Back()
        {
            Wrapper.Navigate().Back();
        }

        public Element FindElement(Search locator)
        {
            Element element = new Element(Wrapper.FindElement(locator.Wrapper), this);
            return element;
        }

        public IEnumerable<Element> FindElements(Search locator)
        {
            return Wrapper.FindElements(locator.Wrapper).Select(e => new Element(e, this));
        }

        public void GoToUrl(string url)
        {
            Wrapper.Navigate().GoToUrl(url);
        }

        public void HideKeyboard()
        {
            Wrapper.HideKeyboard();
        }

        public void Quit()
        {
            Wrapper.Quit();
        }

        public void SetImplicitWait(int seconds)
        {
            Wrapper.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(seconds));
        }
    }
}
