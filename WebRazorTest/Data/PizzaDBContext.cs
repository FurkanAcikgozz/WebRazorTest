//using Microsoft.EntityFrameworkCore; global yaptığımız için buna gerek kalmadı
using WebRazorTest.Model;

namespace WebRazorTest.Data
{
    public class PizzaDBContext : DbContext
    {
        public DbSet<PizzaOrder> Orders { get; set; }
        public PizzaDBContext(DbContextOptions<PizzaDBContext> options) : base(options)
        {

        }
    }
}
