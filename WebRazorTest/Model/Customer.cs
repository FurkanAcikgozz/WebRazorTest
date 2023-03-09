using System.ComponentModel.DataAnnotations;

namespace WebRazorTest.Model
{
    public class Customer
    {

        public int Id { get; set; }

        [Required, StringLength(10)] //Entity Framework attributeları 
        public string? Name { get; set; }


    }
}
