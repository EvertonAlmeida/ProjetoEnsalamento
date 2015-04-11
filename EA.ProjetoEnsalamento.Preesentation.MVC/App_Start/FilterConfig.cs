using System.Web;
using System.Web.Mvc;

namespace EA.ProjetoEnsalamento.Preesentation.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
