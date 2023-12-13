using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace P3PraticeProjectUsingDocker.Pages
{
    [BindProperties]
    public class LoginModel : PageModel
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public void OnGet()
        {
        }
           public IActionResult OnPost() 
        {

            if (Username=="vika" && Password=="1234")
            {
                TempData["User"] = Username;
                return RedirectToPage("/DashBoard");
            }
            else 
            {
                return Page();
            }
        }
    }
}
