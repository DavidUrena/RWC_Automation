
using System.Configuration;

namespace Test.POM
{
    class StaticComponents
    {
        public static readonly string Url = ConfigurationManager.AppSettings["Url"];
    }
}
