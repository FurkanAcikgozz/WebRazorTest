using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebRazorTest.Data;
using WebRazorTest.Model;

namespace WebRazorTest.Pages.Customers
{
    public class CreateModel : PageModel
    {
        [BindProperty] //�n tarafa g�nderiyoruz
        public Customer Customer { get; set; }
        private readonly CustomerDbContext _db;
        private readonly ILogger<CreateModel> _logger;

        public CreateModel(CustomerDbContext db, ILogger<CreateModel> logger)
        {
            _db = db;
            _logger = logger;
        }


        public void OnGet()
        {
        }
        //public ActionResult OnGet()
        //{
        //    return Page();
        //} //// Bu Onget bu �ekilde de kullan�labilir.

        public ActionResult OnPost()
        {
            //Request.Form.ToList(); //bunu yap�yoruz ama bunun yeri [bindproperty] yapt�k customer �zerindeki 


            //if (!ModelState.IsValid) //buras� terminale ge�ersiz yazd�r�yor
            //{
            //    _logger.LogInformation("GE�ERS�Z!!!! ");
            //    return Page();
            //}


            _db.Customer.Add(Customer);
            _db.SaveChanges();
            return RedirectToPage("index");
        }
    }
}
