using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebRazorTest.Data;

namespace WebRazorTest.Pages
{
    public class RazorTestSayfaModel : PageModel
    {

        public List<Book> Books { get; set; }
        

        public RazorTestSayfaModel()
        {
            Books = BookDb.GetBooks().ToList(); // ToList ne yapar????

            //IEnumerable<Book> bookitap = BookDb.GetBooks();
            //Books = bookitap.Where(x => x.Title.Contains("Ýyi")).ToList();

        }


        public void OnGet(int id)
        {

        }
    }
}
