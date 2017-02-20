using Mobile.Framework;
using Mobile.Framework.ManagerParts;

namespace API.Ios.UI.ScreensParts
{
    public class ScreenControls
    {
        internal Element Page => Manager.Factory.GetMobileElement(Search.AccessibilityId("Controls")); // todo: need to integrate page checking before accessing any element
    }
}
