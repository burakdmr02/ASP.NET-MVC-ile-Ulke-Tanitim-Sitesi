using System.Web;
using System.Web.Mvc;

namespace odev_etiyopa_muhammet_burak_demir
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
