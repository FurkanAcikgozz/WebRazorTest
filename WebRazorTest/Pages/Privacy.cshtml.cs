using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebRazorTest.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public ActionResult OnGet() //IActionResult yaparsak, I = interface yapıyor. Iile yapmanın avantajı...
        {
            _logger.LogInformation("Privacyden Geçti");
            //return RedirectToPage("RazorTestSayfa");
            return NotFound("RazorTestSayfa");


        }

        //public ActionResult OnPosta()
        //{
        //    return RedirectToPage("RazorTestSayfa");
        //}
    }
}