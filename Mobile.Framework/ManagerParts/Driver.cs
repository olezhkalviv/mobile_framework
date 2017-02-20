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

        public Element FindElement(Search locator)
        {
            Element element = new Element(Wrapper.FindElement(locator.Wrapper));
            return element;
        }

        public List<Element> FindElements(Search locator)
        {
            List<Element> elements = new List<Element>();
            Wrapper.FindElements(locator.Wrapper).ToList().ForEach(e => elements.Add(new Element(e)));
            return elements;
        }

        public void GoToUrl(string url)
        {
            Wrapper.Navigate().GoToUrl(url);
        }

        public void HideKeyboard()
        {
            Wrapper.HideKeyboard();
        }

        public void SetImplicitWait(int seconds)
        {
            Wrapper.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(seconds));
        }

        // todo: FOR TEST PURPOSES WHILE ADDING NEW MEMBERS
        private void TestPurposes()
        {
            
        }
    }
}
