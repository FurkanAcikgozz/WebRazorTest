using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using WebRazorTest.Model;

namespace WebRazorTest.Pages.Checkout
{
    [BindProperties(SupportsGet  = true)]
    public class ChecoutModel : PageModel
    {

        public string Name { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }

        //private readonly AppDbContext _context;

        //public CheckoutModel(AppDbContext context)
        //{
        //    _context = context;
        //}

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name)) //Birþey yazýlmamýþsa pizzaname custom olacak
                Name = "Custom";

            if (string.IsNullOrWhiteSpace(ImageTitle)) //Birþey yazýlmamýþsa imagetitle null olmasýný diye Create diye yazdýk
                ImageTitle = "Create";

            //PizzaOrder pizzaOrder = new PizzaOrder();
            //pizzaOrder.PizzaName = Name;
            //pizzaOrder.Price = PizzaPrice;

            //_context.PizzaOrders.Add(pizzaOrder);
            //_context.SaveChanges();

        }
    }
}
