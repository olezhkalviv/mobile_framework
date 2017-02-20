﻿using OpenQA.Selenium.Appium;

namespace Mobile.Framework.ManagerParts
{
    public class Element
    {
        internal AppiumWebElement Wrapper { get; }

        public string Text => Wrapper.Text;

        public Element(AppiumWebElement wrapper)
        {
            Wrapper = wrapper;
        }

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
        }

        // todo: FOR TEST PURPOSES WHILE ADDING NEW MEMBERS
        private void TestPurposes()
        {
            
        }
    }
}
