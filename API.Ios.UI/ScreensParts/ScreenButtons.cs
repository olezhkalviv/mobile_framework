using Mobile.Framework;
using Mobile.Framework.ManagerParts;

namespace API.Ios.UI.ScreensParts
{
    public class ScreenButtons
    {
        internal Element Page => Manager.Factory.GetMobileElement(Search.AccessibilityId("Buttons")); // todo: need to integrate page checking before accessing any element
    }
}
