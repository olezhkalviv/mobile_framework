using OpenQA.Selenium.Appium;

namespace Mobile.Framework.ManagerParts
{
    public class MobileElement
    {
        internal AppiumWebElement Wrapper { get; }

        public MobileElement(AppiumWebElement wrapper)
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
    }
}
