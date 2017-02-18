using OpenQA.Selenium;

namespace Mobile.Framework.ManagerParts
{
    public class MobileSearch
    {
        internal By Wrapper { get; private set; }

        public static MobileSearch ClassName(string className)
        {
            return new MobileSearch()
            {
                Wrapper = By.ClassName(className)
            };
        }

        public static MobileSearch CssSelector(string cssSelector)
        {
            return new MobileSearch()
            {
                Wrapper = By.CssSelector(cssSelector)
            };
        }

        public static MobileSearch Id(string id)
        {
            return new MobileSearch()
            {
                Wrapper = By.Id(id)
            };
        }

        public static MobileSearch LinkText(string linkText)
        {
            return new MobileSearch()
            {
                Wrapper = By.LinkText(linkText)
            };
        }

        public static MobileSearch Name(string name)
        {
            return new MobileSearch()
            {
                Wrapper = By.Name(name)
            };
        }

        public static MobileSearch PartialLinkText(string partialLinkText)
        {
            return new MobileSearch()
            {
                Wrapper = By.PartialLinkText(partialLinkText)
            };
        }

        public static MobileSearch TagName(string tagName)
        {
            return new MobileSearch()
            {
                Wrapper = By.TagName(tagName)
            };
        }

        public static MobileSearch XPath(string xPath)
        {
            return new MobileSearch()
            {
                Wrapper = By.XPath(xPath)
            };
        }
    }
}
