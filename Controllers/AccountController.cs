using ContasApp.Data.Entities;
using ContasApp.Data.Repositories;
using ContasApp.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

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

        [HttpPost]
        public IActionResult Register(AccountRegisterViewModel model)
        {
            //verificar se todos os campos passaram nas regras de validação
            if (ModelState.IsValid)
            {
                try
                {
                    //capturado os dados o usuário
                        var usuario = new Usuario();

                        usuario.Id = Guid.NewGuid();
                        usuario.Nome = model.Nome;
                        usuario.Email = model.Email;
                        usuario.Senha = model.Senha;
                        usuario.DataHoraCriacao = DateTime.Now;

                    //gravando o usuário no banco de dados
                    var usuarioRepository = new UsuarioRepository();
                    usuarioRepository.Add(usuario);

                    TempData["Mensagem"] = "Parabéns, sua conta de usuário foi cadastrada com sucesso";

                }
                catch (Exception e) 
                {
                    TempData["Mensagem"] = e.Message;
                    
                }
           }

            return View();

        }


        //Método para abrir a página /Account/ForgotPassoword
        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
