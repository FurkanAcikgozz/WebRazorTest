using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebRazorTest.Data;
using WebRazorTest.Model;

namespace WebRazorTest.Pages.Customers
{
    public class CreateModel : PageModel
    {
        [BindProperty] //ön tarafa gönderiyoruz
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
        //} //// Bu Onget bu þekilde de kullanýlabilir.

        public ActionResult OnPost()
        {
            //Request.Form.ToList(); //bunu yapýyoruz ama bunun yeri [bindproperty] yaptýk customer üzerindeki 


            //if (!ModelState.IsValid) //burasý terminale geçersiz yazdýrýyor
            //{
            //    _logger.LogInformation("GEÇERSÝZ!!!! ");
            //    return Page();
            //}


            _db.Customer.Add(Customer);
            _db.SaveChanges();
            return RedirectToPage("index");
        }
    }
}
