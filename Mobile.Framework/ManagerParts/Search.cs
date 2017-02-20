using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace Mobile.Framework.ManagerParts
{
    public class Search
    {
        internal By Wrapper { get; private set; }

        // https://developer.android.com/intl/ru/training/accessibility/accessible-app.html (contentDescription or name)
        // https://developer.apple.com/reference/uikit/uiaccessibilityidentification (accessibilityIdentifier or name)
        public static Search AccessibilityId(string accessibilityId)
        {
            return new Search()
            {
                Wrapper = MobileBy.AccessibilityId(accessibilityId)
            };
        }

        // http://developer.android.com/intl/ru/tools/testing-support-library/index.html#uia-apis (e.g. "new UiSelector().text(\"REST URL\")")
        public static Search AndroidUiAutomator(string androidUiAutomator)
        {
            return new Search()
            {
                Wrapper = MobileBy.AndroidUIAutomator(androidUiAutomator)
            };
        }

        public static Search ClassName(string className)
        {
            return new Search()
            {
                Wrapper = By.ClassName(className)
            };
        }

        public static Search CssSelector(string cssSelector)
        {
            return new Search()
            {
                Wrapper = By.CssSelector(cssSelector)
            };
        }

        public static Search Id(string id)
        {
            return new Search()
            {
                Wrapper = By.Id(id)
            };
        }

        // This locator strategy is available in XCUITest Driver mode
        public static Search IosNsPredicate(string iosNsPredicate)
        {
            return new Search()
            {
                Wrapper = MobileBy.IosNSPredicate(iosNsPredicate)
            };
        }

        // Deprecated in XCode 7 - XCUITest framework
        public static Search IosUiAutomation(string iosUiAutomation)
        {
            return new Search()
            {
                Wrapper = MobileBy.IosUIAutomation(iosUiAutomation)
            };
        }

        public static Search LinkText(string linkText)
        {
            return new Search()
            {
                Wrapper = By.LinkText(linkText)
            };
        }

        public static Search Name(string name)
        {
            return new Search()
            {
                Wrapper = By.Name(name)
            };
        }

        public static Search PartialLinkText(string partialLinkText)
        {
            return new Search()
            {
                Wrapper = By.PartialLinkText(partialLinkText)
            };
        }

        public static Search TagName(string tagName)
        {
            return new Search()
            {
                Wrapper = By.TagName(tagName)
            };
        }

        public static Search XPath(string xPath)
        {
            return new Search()
            {
                Wrapper = By.XPath(xPath)
            };
        }

        public static Search WindowsAutomation(string windowsAutomation)
        {
            return new Search()
            {
                Wrapper = MobileBy.WindowsAutomation(windowsAutomation)
            };
        }
    }
}
