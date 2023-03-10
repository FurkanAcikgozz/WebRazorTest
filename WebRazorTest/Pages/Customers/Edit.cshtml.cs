using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebRazorTest.Data;
using WebRazorTest.Model;

namespace WebRazorTest.Pages.Customers.NewFolder
{
    public class EditModel : PageModel
    {

        [BindProperty]
        public Customer? Customer { get; set; }

        private readonly CustomerDbContext _db;
        private readonly ILogger<EditModel> _logger;

        public EditModel(CustomerDbContext db, ILogger<EditModel> logger)
        {
            _db = db;
            _logger = logger;
        }


        public ActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = _db.Customer.FirstOrDefault(m => m.Id == id); //Bu Linq Konusudur
            //FirstOrDefault Birden fazla olduðunda 1.getiriyor bulamazsa defaylt deðer getiriyor.
            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }

        //Asekron hali ile onget metodu böyle tanýmlanýr.
        //public async Task< ActionResult> OnGetAsync(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    Customer = await _db.Customer.FirstOrDefaultAsync(m => m.Id == id); //Bu Linq Konusudur
        //    //FirstOrDefault Birden fazla olduðunda 1.getiriyor bulamazsa defaylt deðer getiriyor.
        //    if (Customer == null)
        //    {
        //        return NotFound();
        //    }
        //    return Page();
        //}


        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Customer != null)
            {
                _db.Attach(Customer).State = EntityState.Modified;

                try
                {
                    _db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException) //Ayný andalýk hatasý. Bir iþlemi ayný anda yapýlýyorsa
                {
                    if (!CustomerExists(Customer.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            return RedirectToPage("Index");
        }

        private bool CustomerExists(int id)
        {
            return _db.Customer.Any(e => e.Id == id);
        }


    }
}
