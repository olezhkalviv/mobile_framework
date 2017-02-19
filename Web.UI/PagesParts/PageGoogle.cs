using System.Collections.Generic;
using Mobile.Framework;
using Mobile.Framework.ManagerParts;

namespace Web.UI.PagesParts
{
    public class PageGoogle
    {
        private List<MobileElement> LnkResults => Manager.Factory.GetMobileElements(MobileSearch.ClassName("_wSg"));

        public MobileElement TxtSearch => Manager.Factory.GetMobileElement(MobileSearch.Id("lst-ib"));
        public MobileElement BtnSearch => Manager.Factory.GetMobileElement(MobileSearch.XPath("//button[@name='btnG']"));

        public string GetFirstLinkText()
        {
            return LnkResults[0].Text;
        }
    }
}
