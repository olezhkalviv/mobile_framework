using Mobile.Framework;
using Mobile.Framework.ManagerParts;

namespace API.Android.UI.ScreensParts
{
    public class ScreenApiDemos
    {
        public Element BtnAccessibility => Manager.Factory.GetMobileElement(Search.Name("Accessibility"));
        public Element BtnAnimation => Manager.Factory.GetMobileElement(Search.Name("Animation"));
        public Element BtnApp => Manager.Factory.GetMobileElement(Search.Name("App"));
        public Element BtnContent => Manager.Factory.GetMobileElement(Search.Name("Content"));
        public Element BtnGraphics => Manager.Factory.GetMobileElement(Search.Name("Graphics"));
        public Element BtnMedia => Manager.Factory.GetMobileElement(Search.Name("Media"));
        public Element BtnNfc => Manager.Factory.GetMobileElement(Search.Name("NFC"));
        public Element BtnOs => Manager.Factory.GetMobileElement(Search.Name("OS"));
        public Element BtnPreference => Manager.Factory.GetMobileElement(Search.Name("Preference"));
        public Element BtnText => Manager.Factory.GetMobileElement(Search.Name("Text"));
        public Element BtnViews => Manager.Factory.GetMobileElement(Search.Name("Views"));
    }
}
