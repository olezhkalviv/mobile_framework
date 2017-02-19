﻿using Mobile.Framework;
using Mobile.Framework.ManagerParts;

namespace API.Ios.UI.ScreensParts
{
    public class ScreenControls
    {
        internal MobileElement Page => Manager.Factory.GetMobileElement(MobileSearch.AccessibilityId("Controls")); // todo: need to integrate page checking before accessing any element
    }
}