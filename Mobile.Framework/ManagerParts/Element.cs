using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Appium;

namespace Mobile.Framework.ManagerParts
{
    public class Element
    {
        internal Element() { }

        internal Element(AppiumWebElement wrapper, Driver driver)
        {
            Wrapper = wrapper;
            Driver = driver;
        }

        internal AppiumWebElement Wrapper { get; }
        internal Driver Driver { get; }

        public bool Checked => bool.Parse(Wrapper.GetAttribute("checked"));
        public bool Selected => Wrapper.Selected;
        public string Text => Wrapper.Text;

        public void Click()
        {
            Wrapper.Click();
        }

        public string GetAttribute(string attributeName)
        {
            return Wrapper.GetAttribute(attributeName);
        }

        public void SendKeys(string text)
        {
            Wrapper.SendKeys(text);
            Driver.HideKeyboard();
        }

        public Element FindChildElement(Search locator)
        {
            Element element = new Element(Wrapper.FindElement(locator.Wrapper), Driver);
            return element;
        }

        public IEnumerable<Element> FindChildElements(Search locator)
        {
            return Wrapper.FindElements(locator.Wrapper).Select(e => new Element(e, Driver));
        }
    }
}
