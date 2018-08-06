using System.Web;
using System.Web.Mvc;

namespace Autofac.Demo.ConcatWebApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
