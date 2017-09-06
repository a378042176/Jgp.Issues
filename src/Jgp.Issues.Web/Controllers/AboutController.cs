using System.Web.Mvc;

namespace Jgp.Issues.Web.Controllers
{
    public class AboutController : IssuesControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}