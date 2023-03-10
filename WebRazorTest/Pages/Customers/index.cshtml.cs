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

        public indexModel(CustomerDbContext db) //depenced incection yap�l�yor. Ctor kod blo�unda
        {
            _db = db;
        }
        
        public void OnGet() // bunun ad�n handler method
        {
            Customers = _db.Customer.OrderBy(c => c.Id).ToList(); //Customer = CustomerDbContext.cs i�erisindeki custormerd�r

        }
    }
}
