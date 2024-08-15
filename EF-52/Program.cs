using EF_52.Models;

namespace EF_52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new AppDbContext();

            var Books = context.Books
                .Join(
                context.Authors,
                b => b.AuthorId,
                a => a.AuthorId,
                (b, a) => new { b.BookId, b.BookName, a.AuthorName, a.AuthorId }
                )
                .Join(
                context.Nationalities,
                b => b.AuthorId,
                n => n.AuthorId,
                (b, n) => new { b.BookId, b.BookName, b.AuthorName, n.NationalityName }
                );
            foreach (var book in Books)
                Console.WriteLine($"{book.BookId}, {book.BookName}, {book.AuthorName}, {book.NationalityName}");

            // Left Join Ex
            var Books2 = context.Books
                .GroupJoin(
                context.Authors,
                b => b.AuthorId,
                a => a.AuthorId,
                (b, a) => new
                {
                    Books = b,
                    Authors = a
                }
                ).SelectMany(
                b => b.Authors.DefaultIfEmpty(),

                (b, a) => new { b.Books, Authors = a }
                );
            foreach (var book in Books2)
                Console.WriteLine($"{book.Books.BookId}, {book.Books.BookName}, {book.Authors?.AuthorId}");

            Console.ReadKey();




        }
    }
}
