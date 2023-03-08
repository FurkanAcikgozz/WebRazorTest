using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebRazorTest.Data;

namespace WebRazorTest.Pages
{
    public class BookListModel : PageModel
    {
        
        public Book? Book { get; private set; }
        

        public void OnGet(int id)
        {
            Book = BookDb.GetBookById(id);
        }
    }
}
