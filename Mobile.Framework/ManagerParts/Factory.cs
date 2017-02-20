using System.Collections.Generic;

namespace Mobile.Framework.ManagerParts
{
    public class Factory
    {
        public Element GetMobileElement(Search search)
        {
            Manager.Waiter.ForElementVisible(search);
            var element = Manager.Driver.FindElement(search);
            return element;
        }

        public List<Element> GetMobileElements(Search search)
        {
            Manager.Waiter.ForElementVisible(search);
            var elements = Manager.Driver.FindElements(search);
            return elements;
        }
    }
}
