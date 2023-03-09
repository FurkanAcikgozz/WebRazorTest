using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebRazorTest.Data;

namespace WebRazorTest.Pages
{
   // [BindProperties] //Bind properties �ok prat�k de�il. Burada kulland���m�z bir propu �n tarafa ba�lam�� olabiliyoruz.
    public class AddModel : PageModel
    {
        [BindProperty] // bunun yerine clas�n �zerine bindproperties yazabiliriz
        public string Title { get; set; }

        [BindProperty]
        public Book Book { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public AddModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        //Logger has a ili�kisi yap�yor.





        public void OnGet()
        {
            _logger.LogInformation("GET ISTEGI");

        //    var form = Request.Form.ToList(); //ne i�e yar�yor anlamad�m. Ara�t�racam. Request.form nedir?
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
