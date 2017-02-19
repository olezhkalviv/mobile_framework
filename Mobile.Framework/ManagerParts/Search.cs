using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace Mobile.Framework.ManagerParts
{
    public class MobileSearch
    {
        internal By Wrapper { get; private set; }

        public static MobileSearch AccessibilityId(string accessibilityId)
        {
            return new MobileSearch()
            {
                Wrapper = MobileBy.AccessibilityId(accessibilityId)
            };
        }

        public static MobileSearch AndroidUiAutomator(string androidUiAutomator)
        {
            return new MobileSearch()
            {
                Wrapper = MobileBy.AndroidUIAutomator(androidUiAutomator)
            };
        }

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

        public static MobileSearch IosNsPredicate(string iosNsPredicate)
        {
            return new MobileSearch()
            {
                Wrapper = MobileBy.IosNSPredicate(iosNsPredicate)
            };
        }

        public static MobileSearch IosUiAutomation(string iosUiAutomation)
        {
            return new MobileSearch()
            {
                Wrapper = MobileBy.IosUIAutomation(iosUiAutomation)
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

        public static MobileSearch WindowsAutomation(string windowsAutomation)
        {
            return new MobileSearch()
            {
                Wrapper = MobileBy.WindowsAutomation(windowsAutomation)
            };
        }
    }
}
