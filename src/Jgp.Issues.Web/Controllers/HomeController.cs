using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Jgp.Issues.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : IssuesControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}