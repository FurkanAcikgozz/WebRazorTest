using static System.Reflection.Metadata.BlobBuilder;

namespace WebRazorTest.Data
{
    public static class BookDb
    {
        private static readonly List<Book> Books = new List<Book>(); //readoly yaparak 1 kere initialyz edilir. Bir daha yeni bir liste oluşturulamaz. Sadece listenin içerisindeki verileri değiştiriebiliriz.

        public static void DbInitialize()
        {
            //Books = new List<Book>
            //{
            //    new Book {id = 1, Title = "İyi Kitap", Author = "İyi Yazar"},
            //    new Book {id = 2, Title = "Kötü Kitap", Author = "Kötü Yazar"},
            //    new Book {id = 3, Title = "Çirkin Kitap", Author = "Çirkin Yazar"}
            //};

            Books.Add(new Book { id = 1, Title = "İyi Kitap", Author = "İyi Yazar" });
            Books.Add(new Book { id = 2, Title = "Kötü Kitap", Author = "Kötü Yazar" });
            Books.Add(new Book { id = 3, Title = "Çirkin Kitap", Author = "Çirkin Yazar" });
            
      
               
            
        }
        public static List<Book> GetBooks()
        {
            return Books;
        }
        public static Book GetBookById(int id)
        {
            return new Book();
        }
    }
}
