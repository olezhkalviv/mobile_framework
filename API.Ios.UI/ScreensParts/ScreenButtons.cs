using Mobile.Framework;
using Mobile.Framework.ManagerParts;

namespace API.Ios.UI.ScreensParts
{
    public class ScreenButtons
    {
        internal MobileElement Page => Manager.Factory.GetMobileElement(MobileSearch.AccessibilityId("Buttons")); // todo: need to integrate page checking before accessing any element
    }
}
