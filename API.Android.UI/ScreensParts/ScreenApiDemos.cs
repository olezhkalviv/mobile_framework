using System.Runtime.Remoting.Messaging;
using Mobile.Framework;
using Mobile.Framework.ManagerParts;

namespace API.Android.UI.ScreensParts
{
    public class ScreenApiDemos
    {
        public MobileElement BtnAccessibility => Manager.Driver.FindElement(MobileSearch.Name("Accessibility"));
        public MobileElement BtnAnimation => Manager.Driver.FindElement(MobileSearch.Name("Animation"));
        public MobileElement BtnApp => Manager.Driver.FindElement(MobileSearch.Name("App"));
        public MobileElement BtnContent => Manager.Driver.FindElement(MobileSearch.Name("Content"));
        public MobileElement BtnGraphics => Manager.Driver.FindElement(MobileSearch.Name("Graphics"));
        public MobileElement BtnMedia => Manager.Driver.FindElement(MobileSearch.Name("Media"));
        public MobileElement BtnNfc => Manager.Driver.FindElement(MobileSearch.Name("NFC"));
        public MobileElement BtnOs => Manager.Driver.FindElement(MobileSearch.Name("OS"));
        public MobileElement BtnPreference => Manager.Driver.FindElement(MobileSearch.Name("Preference"));
        public MobileElement BtnText => Manager.Driver.FindElement(MobileSearch.Name("Text"));
        public MobileElement BtnViews => Manager.Driver.FindElement(MobileSearch.Name("Views"));
    }
}
