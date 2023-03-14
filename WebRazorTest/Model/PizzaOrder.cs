using System.ComponentModel.DataAnnotations;

namespace WebRazorTest.Model
{
    public class PizzaOrder
    {
        [Key]
        public int PizId { get; set; }
        //[Required] 
        [StringLength(25)]
        public string? Name { get; set; }/* =string.Empty;*/
        public float Price { get; set; }

        public DateTime Date { get; set; }
    }
}
