using System.Web;
using System.Web.Mvc;

namespace HSMS_MVC_LandPage
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}