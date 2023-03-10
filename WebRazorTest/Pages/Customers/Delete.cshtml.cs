using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebRazorTest.Data;
using WebRazorTest.Model;

namespace WebRazorTest.Pages.Customers.NewFolder
{
    public class DeleteModel : PageModel
    {
        public Customer Customer { get; set; }
        private readonly CustomerDbContext _db;

        public DeleteModel(CustomerDbContext db)
        {
            _db = db;
        }
        public ActionResult OnGet(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = _db.Customer.FirstOrDefault(item=> item.Id == id);

            if (Customer == null)
            {
                return NotFound();
            }

            return Page();
        }


        public ActionResult OnPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = _db.Customer.Find(id); //find pramirykey olan þeyler üzerinden çalýþýr. Yani id alýr tekli olarak kontrol eder. Arar

            if (Customer != null)
            {
                _db.Customer.Remove(Customer);
                _db.SaveChanges();
            }

            return RedirectToPage("Index");
        }

    }
}
