using System.Collections.Generic;
using Mobile.Framework;
using Mobile.Framework.ManagerParts;

namespace Web.Android.UI.PagesParts
{
    public class PageGoogle
    {
        private List<MobileElement> LnkResults
        {
            get
            {
                Manager.Waiter.ForElementVisible(MobileSearch.ClassName("_wSg"));
                return Manager.Driver.FindElements(MobileSearch.ClassName("_wSg"));
            }
        }

        public MobileElement TxtSearch
        {
            get
            {
                Manager.Waiter.ForElementVisible(MobileSearch.Id("lst-ib"));
                return Manager.Driver.FindElement(MobileSearch.Id("lst-ib"));
            }
        }
        public MobileElement BtnSearch
        {
            get
            {
                Manager.Waiter.ForElementVisible(MobileSearch.Name("btnG"));
                return Manager.Driver.FindElement(MobileSearch.Name("btnG"));
            }
        }

        public string GetFirstLinkText()
        {
            return LnkResults[0].Text;
        }
    }
}
