using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FlashCardsWebApp.Pages.Account
{
    [Authorize]
    public class LogoutModel : PageModel
    {
        public async void OnGetAsync()
        {
            await HttpContext.SignOutAsync("auth");
        }
    }
}
