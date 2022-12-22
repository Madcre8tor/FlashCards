using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace FlashCardsWebApp.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Credential Credential { get; set; }

        public void OnGet()
        {

        }

        public async void OnPostAsync()
        {
            if (!ModelState.IsValid) return;

            if (Credential.Username == "admin" && Credential.Password == "password")
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, "root"),
                    new Claim(ClaimTypes.Role, "admin")
                };

                var identity = new ClaimsIdentity(claims, "auth");
                var claimsPrincipal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync("auth", claimsPrincipal);

                RedirectToPage("/index");
            } else if (Credential.Username == "user" && Credential.Password == "password")
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, "user")
                };

                var identity = new ClaimsIdentity(claims, "auth");
                var claimsPrincipal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync("auth", claimsPrincipal);

                RedirectToPage("/index");
            }
        }
    }

    public class Credential
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
