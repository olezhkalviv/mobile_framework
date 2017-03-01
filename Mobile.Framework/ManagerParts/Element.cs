using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
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
        public bool Displayed => Wrapper.Displayed;
        public bool Enabled => Wrapper.Enabled;
        public string Id => Wrapper.Id;
        public bool Selected => Wrapper.Selected;
        public string TagName => Wrapper.TagName;
        public string Text => Wrapper.Text;

        public void Clear()
        {
            Wrapper.Clear();
        }

        public void Click()
        {
            Wrapper.Click();
        }

        public string GetAttribute(string attributeName)
        {
            return Wrapper.GetAttribute(attributeName);
        }

        public void GetScreenshot()
        {
            Screenshot s = Wrapper.GetScreenshot(); // TODO: something
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

        public void Pinch()
        {
            Wrapper.Pinch();
        }

        public void Rotate(Dictionary<string, int> opts)
        {
            Wrapper.Rotate(opts);
        }

        public void SetImmediateValue(string value)
        {
            Wrapper.SetImmediateValue(value);
        }

        public void Tap(int fingers, int duration)
        {
            Wrapper.Tap(fingers, duration);
        }

        public void Zoom()
        {
            Wrapper.Zoom();
        }
    }
}
