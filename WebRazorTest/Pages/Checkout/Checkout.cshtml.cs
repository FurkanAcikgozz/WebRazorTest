using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using WebRazorTest.Data;
using WebRazorTest.Model;

namespace WebRazorTest.Pages.Checkout
{
    [BindProperties(SupportsGet  = true)]
    public class ChecoutModel : PageModel
    {

        public string Name { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }

        private readonly PizzaDBContext _context;

        public ChecoutModel(PizzaDBContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name)) //Birþey yazýlmamýþsa pizzaname custom olacak
                Name = "Custom";

            if (string.IsNullOrWhiteSpace(ImageTitle)) //Birþey yazýlmamýþsa imagetitle null olmasýný diye Create diye yazdýk
                ImageTitle = "Create";

            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.Name = Name;
            pizzaOrder.Price = PizzaPrice;
            pizzaOrder.Date = DateTime.Now;/*.ToUniversalTime()*/

            _context.Orders.Add(pizzaOrder); //orders sql tablo adý
            _context.SaveChanges();

        }
    }
}
