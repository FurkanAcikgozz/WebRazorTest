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
            if (string.IsNullOrWhiteSpace(Name)) //Bir�ey yaz�lmam��sa pizzaname custom olacak
                Name = "Custom";

            if (string.IsNullOrWhiteSpace(ImageTitle)) //Bir�ey yaz�lmam��sa imagetitle null olmas�n� diye Create diye yazd�k
                ImageTitle = "Create";

            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.Name = Name;
            pizzaOrder.Price = PizzaPrice;
            pizzaOrder.Date = DateTime.Now;/*.ToUniversalTime()*/

            _context.Orders.Add(pizzaOrder); //orders sql tablo ad�
            _context.SaveChanges();

        }
    }
}
