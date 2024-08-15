using EF_52.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new AppDbContext();

            // inner join between 3 tables
            {
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
            }
            // Left Join Ex
            {
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
            }
            // Eager Loading it lows the performance because it loads all the Enties even if i didnot use it
            {
                var book3 = context.Books.Include(a => a.Author).Single(b => b.AuthorId == 1);
                Console.WriteLine(book3.Author.AuthorName);
                var book4 = context.Books
                    .Include(x => x.Author)
                    .ThenInclude(x => x.Nationalities)
                    .Single(x => x.AuthorId == 1);
                foreach (var item in book4.Author.Nationalities)
                {
                    Console.WriteLine($"{book4.Author.AuthorName}, {item.NationalityName}");
                }
                    
            }
            // Explicit Loading
            {
                var book = context.Books.First(x => x.AuthorId == 2);
                context.Entry(book).Reference(x => x.Author).Load();
                Console.WriteLine(book.Author.AuthorName);
            }
            // Ignoring global filter
            {
                context.Books.IgnoreQueryFilters().Select(x => x.BookName);
            }
            Console.ReadKey();




        }
    }
}
