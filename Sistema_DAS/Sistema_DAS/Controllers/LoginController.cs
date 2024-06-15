using Microsoft.AspNetCore.Mvc;
using Sistema_DAS.Context;
namespace Sistema_DAS.Controllers
{
    public class LoginController : Controller
    {
        MiContext _context;
        public LoginController( MiContext context)
        {
            //inyeccion de dependencias
            this._context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Login(string email,string password )
        {
            var usuario = _context.Usuarios.Where(x => x.Email == email).Where(x=> x.Password == password).FirstOrDefault();
            if (usuario != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                //mandando mensajes a la vista
                TempData["LoginError"] = "Cuenta o password incorrectos";
                return RedirectToAction("Index", "Login");
            }
        }
        public async Task<ActionResult> Logout()
        {
            return RedirectToAction("Index", "Login");
        }

    }
}
