using Newtonsoft.Json;

namespace Mobile.Framework.UtilsParts
{
    public class Json
    {
        internal Json()
        {

        }

        public void PopulateJson(string value, object target)
        {
            JsonConvert.PopulateObject(value, target);
        }
    }
}
