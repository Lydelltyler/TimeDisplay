using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FourthMVP.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
       
    }
}