using System.Web;
using System.Web.Mvc;

namespace LTCSDL_IM91_3Layer_Sub3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
