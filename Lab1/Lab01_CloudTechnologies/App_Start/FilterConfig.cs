using System.Web;
using System.Web.Mvc;

namespace Lab01_CloudTechnologies
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
