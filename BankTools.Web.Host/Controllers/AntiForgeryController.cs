using Microsoft.AspNetCore.Antiforgery;
using BankTools.Controllers;

namespace BankTools.Web.Host.Controllers
{
    public class AntiForgeryController : BankToolsControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
