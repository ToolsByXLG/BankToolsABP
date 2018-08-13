using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using BankTools.Controllers;

namespace BankTools.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : BankToolsControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
