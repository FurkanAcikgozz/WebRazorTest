using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebRazorTest.Data;
using WebRazorTest.Model;

namespace WebRazorTest.Pages.Customers
{
    public class indexModel : PageModel
    {
        public List<Customer> Customers { get; set; }
        private readonly CustomerDbContext _db;

        public indexModel(CustomerDbContext db)
        {
            _db = db;

        }

        public void OnGet()
        {
            Customers = _db.Customer.ToList(); //Customer = CustomerDbContext.cs içerisindeki custormerdýr

        }
    }
}
