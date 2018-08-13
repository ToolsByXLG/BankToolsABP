using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using BankTools.Controllers;

namespace BankTools.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : BankToolsControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
