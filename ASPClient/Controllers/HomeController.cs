using System.Web.Mvc;

namespace ASPClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var wcfService = new WCFServiceReference.CurrentTimeContractClient();
            var result = wcfService?.GetData();
            if (result != null)
            {
                ViewBag.Time = result;
            }
            return View();
        }
    }
}