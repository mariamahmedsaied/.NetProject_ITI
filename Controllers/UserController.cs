using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolLibraryStore.Context;
using SchoolLibraryStore.Models;
using System.Threading.Tasks;

namespace SchoolLibraryStore.Controllers
{
    public class UserController : Controller
    {
        private readonly SchoolLibraryStoreContext db = new SchoolLibraryStoreContext();

        [HttpGet("register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(User user)
        {
            if (!ModelState.IsValid)
                return View(user);

            // Hash the password here (implement HashPassword method)
            user.Password = HashPassword(user.Password);

            db.Users.Add(user);
            await db.SaveChangesAsync();
            return RedirectToAction("Login");
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            if (!ModelState.IsValid)
                return View(loginRequest);

            var user = await db.Users.SingleOrDefaultAsync(u => u.Email == loginRequest.Email);
            if (user == null || !VerifyPassword(user.Password, loginRequest.Password)) // Implement VerifyPassword
                return Unauthorized();

            // Redirect or set session/cookie here
            return RedirectToAction("Index", "Product");
        }

        private string HashPassword(string password)
        {
            // Implement password hashing logic here
            return password; // Replace with actual hashing
        }

        private bool VerifyPassword(string storedPassword, string providedPassword)
        {
            // Implement password verification logic here
            return storedPassword == providedPassword; // Replace with actual verification
        }
    }

    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

