using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebRazorTest.Data;
using WebRazorTest.Model;

namespace WebRazorTest.Pages.Admin
{
    public class OrderListAdminModel : PageModel
    {
        private readonly WebRazorTest.Data.PizzaDBContext _context;

        public OrderListAdminModel(WebRazorTest.Data.PizzaDBContext context)
        {
            _context = context;
        }

        public IList<PizzaOrder> PizzaOrder { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Orders != null)
            {
                PizzaOrder = await _context.Orders.ToListAsync();
            }
        }
    }
}
