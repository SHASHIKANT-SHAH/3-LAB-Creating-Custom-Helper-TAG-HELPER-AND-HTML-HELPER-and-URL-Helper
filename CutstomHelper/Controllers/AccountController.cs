using Microsoft.AspNetCore.Mvc;
using CutstomHelper.Models;

namespace CutstomHelper.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        
    }
}
