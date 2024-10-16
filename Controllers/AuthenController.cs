using Microsoft.AspNetCore.Mvc;
using PjAdminlte.Helpers;
using PjAdminlte.Models;

namespace PjAdminlte.Controllers
{
    public class AuthenController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AuthenController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: AuthController
        public ActionResult Index()
        {
            return View("~/Views/Authen/SignIn.cshtml");
        }

        // POST : AuthController
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
        
            var user = _context.Users
                .Where(u => u.Username == username)
                .FirstOrDefault();

            if (user == null)
            {
                return BadRequest("Invalid username");
            }
            else
            {
                if (PasswordHelper.VerifyPassword(password, user.Password))
                {
                    // SessionHelper.SetUser(user);
                    return Ok("Login success");
                }
                else
                {
                    return BadRequest("Invalid password");
                }
            }

        }

        [HttpGet]
        public ActionResult Register()
        {
            return View("~/Views/Authen/Register.cshtml");
        }

        [HttpPost]
        public ActionResult RegisterStore(UserEntity user)
        {
            if (ModelState.IsValid)
            {
                var userEntity = new UserEntity
                {
                    Name = user.Name,
                    Username = user.Username,
                    Password = PasswordHelper.HashPassword(user.Password),
                };

                _context.Users.Add(userEntity);
                _context.SaveChanges();
                // redirect back
                return RedirectToAction("Index", "Authen");
            }
            else
            {
                return BadRequest("Invalid data");
            }

        }

    }
}
