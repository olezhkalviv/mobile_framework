using System.Collections.Generic;
using Mobile.Framework;
using Mobile.Framework.ManagerParts;

namespace Web.UI.PagesParts
{
    public class PageGoogle
    {
        private List<Element> LnkResults => Manager.Factory.GetMobileElements(Search.ClassName("_wSg"));

        public Element TxtSearch => Manager.Factory.GetMobileElement(Search.Id("lst-ib"));
        public Element BtnSearch => Manager.Factory.GetMobileElement(Search.XPath("//button[@name='btnG']"));

        public string GetFirstLinkText()
        {
            return LnkResults[0].Text;
        }
    }
}
