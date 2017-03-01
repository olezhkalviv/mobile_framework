using System.Collections.Generic;

namespace Mobile.Framework.ManagerParts
{
    public class Factory
    {
        internal Factory() { }

        public Element GetElement(Search search)
        {
            Manager.Waiter.ForElementVisible(search);
            var element = Manager.Driver.FindElement(search);
            return element;
        }

        public IEnumerable<Element> GetElements(Search search)
        {
            Manager.Waiter.ForElementVisible(search);
            var elements = Manager.Driver.FindElements(search);
            return elements;
        }
    }
}