using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace P3PraticeProjectUsingDocker.Pages
{
    public class DashBoardModel : PageModel
    {
        public void OnGet()
        {
            ViewData["User"] = TempData["User"];  
        }

        public IActionResult OnPost() 
        {
            
            return RedirectToPage("/Login");
        }
    }
}
