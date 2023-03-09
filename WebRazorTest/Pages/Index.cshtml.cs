using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebRazorTest.Data;
using WebRazorTest.Model;

namespace WebRazorTest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        //Logger has a ilişkisi yapıyor.

        //public List<Customer> Customers { get; set; }
        //private readonly CustomerDbContext _db;

        //public IndexModel(CustomerDbContext db)
        //{
        //    _db = db;

        //}


        public void OnGet()
        {
        }
    }
}