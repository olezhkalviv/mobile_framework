using Mobile.Framework;
using Mobile.Framework.ManagerParts;

namespace API.Android.UI.ScreensParts
{
    public class ScreenApiDemos
    {
        public MobileElement BtnAccessibility => Manager.Factory.GetMobileElement(MobileSearch.Name("Accessibility"));
        public MobileElement BtnAnimation => Manager.Factory.GetMobileElement(MobileSearch.Name("Animation"));
        public MobileElement BtnApp => Manager.Factory.GetMobileElement(MobileSearch.Name("App"));
        public MobileElement BtnContent => Manager.Factory.GetMobileElement(MobileSearch.Name("Content"));
        public MobileElement BtnGraphics => Manager.Factory.GetMobileElement(MobileSearch.Name("Graphics"));
        public MobileElement BtnMedia => Manager.Factory.GetMobileElement(MobileSearch.Name("Media"));
        public MobileElement BtnNfc => Manager.Factory.GetMobileElement(MobileSearch.Name("NFC"));
        public MobileElement BtnOs => Manager.Factory.GetMobileElement(MobileSearch.Name("OS"));
        public MobileElement BtnPreference => Manager.Factory.GetMobileElement(MobileSearch.Name("Preference"));
        public MobileElement BtnText => Manager.Factory.GetMobileElement(MobileSearch.Name("Text"));
        public MobileElement BtnViews => Manager.Factory.GetMobileElement(MobileSearch.Name("Views"));
    }
}
