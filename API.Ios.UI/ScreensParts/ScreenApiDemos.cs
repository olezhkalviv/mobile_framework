using Mobile.Framework;
using Mobile.Framework.ManagerParts;

namespace API.Ios.UI.ScreensParts
{
    public class ScreenApiDemos
    {
        internal MobileElement Page => Manager.Factory.GetMobileElement(MobileSearch.AccessibilityId("UICatalog")); // todo: need to integrate page checking before accessing any element

        public MobileElement BtnButtons => Manager.Factory.GetMobileElement(MobileSearch.XPath("//UIAApplication[1]/UIAWindow[1]/UIATableView[1]/UIATableCell[1]"));
        public MobileElement BtnControls => Manager.Factory.GetMobileElement(MobileSearch.XPath("//UIAApplication[1]/UIAWindow[1]/UIATableView[1]/UIATableCell[2]"));
    }
}
