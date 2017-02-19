using System.Collections.Generic;

namespace Mobile.Framework.ManagerParts
{
    public class Factory
    {
        public MobileElement GetMobileElement(MobileSearch search)
        {
            Manager.Waiter.ForElementVisible(search);
            var element = Manager.Driver.FindElement(search);
            return element;
        }

        public List<MobileElement> GetMobileElements(MobileSearch search)
        {
            Manager.Waiter.ForElementVisible(search);
            var elements = Manager.Driver.FindElements(search);
            return elements;
        }
    }
}
