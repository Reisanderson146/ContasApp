using Microsoft.AspNetCore.Mvc;

namespace ContasApp.Presentation.Controllers
{
    public class AccountController : Controller
    {
        //Método para abrir a página /Account/Login
        public IActionResult Login()
        {
            return View();
        }

        //Método para abrir a página /Account/Register
        public IActionResult Register()
        {
            return View();
        }

        //Método para abrir a página /Account/ForgotPassoword
        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
