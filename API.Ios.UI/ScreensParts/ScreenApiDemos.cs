using Mobile.Framework;
using Mobile.Framework.ManagerParts;

namespace API.Ios.UI.ScreensParts
{
    public class ScreenApiDemos
    {
        internal Element Page => Manager.Factory.GetMobileElement(Search.AccessibilityId("UICatalog")); // todo: need to integrate page checking before accessing any element

        public Element BtnButtons => Manager.Factory.GetMobileElement(Search.XPath("//UIAApplication[1]/UIAWindow[1]/UIATableView[1]/UIATableCell[1]"));
        public Element BtnControls => Manager.Factory.GetMobileElement(Search.XPath("//UIAApplication[1]/UIAWindow[1]/UIATableView[1]/UIATableCell[2]"));
    }
}
