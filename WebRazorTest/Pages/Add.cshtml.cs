using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebRazorTest.Data;

namespace WebRazorTest.Pages
{
   // [BindProperties] //Bind properties çok pratýk deðil. Burada kullandýðýmýz bir propu ön tarafa baðlamýþ olabiliyoruz.
    public class AddModel : PageModel
    {
        [BindProperty] // bunun yerine clasýn üzerine bindproperties yazabiliriz
        public string Title { get; set; }

        [BindProperty]
        public Book Book { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public AddModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        //Logger has a iliþkisi yapýyor.





        public void OnGet()
        {
            _logger.LogInformation("GET ISTEGI");

        //    var form = Request.Form.ToList(); //ne iþe yarýyor anlamadým. Araþtýracam. Request.form nedir?
        }

        //}  public void OnPost()
        //{

        //    _logger.LogInformation("POST ISTEGI");

        //}
        public ActionResult OnPost()
        {

            _logger.LogInformation("POST ISTEGI");

            return RedirectToPage("RazorTestSayfa");
        }
    }
}
