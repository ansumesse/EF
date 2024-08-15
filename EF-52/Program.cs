using EF_52.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new AppDbContext();

            //// inner join between 3 tables
            //{
            //    var Books = context.Books
            //        .Join(
            //        context.Authors,
            //        b => b.AuthorId,
            //        a => a.AuthorId,
            //        (b, a) => new { b.BookId, b.BookName, a.AuthorName, a.AuthorId }
            //        )
            //        .Join(
            //        context.Nationalities,
            //        b => b.AuthorId,
            //        n => n.AuthorId,
            //        (b, n) => new { b.BookId, b.BookName, b.AuthorName, n.NationalityName }
            //        );
            //    foreach (var book in Books)
            //        Console.WriteLine($"{book.BookId}, {book.BookName}, {book.AuthorName}, {book.NationalityName}");
            //}
            //// Left Join Ex
            //{
            //    var Books2 = context.Books
            //        .GroupJoin(
            //        context.Authors,
            //        b => b.AuthorId,
            //        a => a.AuthorId,
            //        (b, a) => new
            //        {
            //            Books = b,
            //            Authors = a
            //        }
            //        ).SelectMany(
            //        b => b.Authors.DefaultIfEmpty(),

            //        (b, a) => new { b.Books, Authors = a }
            //        );
            //    foreach (var book in Books2)
            //        Console.WriteLine($"{book.Books.BookId}, {book.Books.BookName}, {book.Authors?.AuthorId}");
            //}
            //// Eager Loading it lows the performance because it loads all the Enties even if i didnot use it
            //{
            //    var book3 = context.Books.Include(a => a.Author).Single(b => b.AuthorId == 1);
            //    Console.WriteLine(book3.Author.AuthorName);
            //    var book4 = context.Books
            //        .Include(x => x.Author)
            //        .ThenInclude(x => x.Nationalities)
            //        .Single(x => x.AuthorId == 1);
            //    foreach (var item in book4.Author.Nationalities)
            //    {
            //        Console.WriteLine($"{book4.Author.AuthorName}, {item.NationalityName}");
            //    }

            //}
            //// Explicit Loading
            //{
            //    var book = context.Books.First(x => x.AuthorId == 2);
            //    context.Entry(book).Reference(x => x.Author).Load();
            //    Console.WriteLine(book.Author.AuthorName);
            //}
            //// Ignoring global filter
            //{
            //    context.Books.IgnoreQueryFilters().Select(x => x.BookName);
            //}
            //// Add New Records and Related Data
            //{
            //    context.Authors.Add(
            //        new Author()
            //        {
            //            AuthorName = "Moaz Anas",
            //            Books = new List<Book>()
            //            {
            //                new Book()
            //                {
            //                    BookName = "franceais"
            //                }
            //            },
            //            Nationalities = new List<Nationality>()
            //            {
            //                new Nationality()
            //                {
            //                    NationalityName = "japanese"
            //                }
            //            }
            //        }
            //        );
            //    context.SaveChanges();
            //}
            //// Update Records
            //{
            //    var book = new Book() { BookId = 3, AuthorId = 5};
            //    context.Update(book); // update the specified columns only and set the rest to null
            //    var book2 = new Book() { BookId = 5, AuthorId = 5 };
            //    context.Update(book2);
            //    context.Entry(book2).Property(x => x.AuthorId).IsModified = true; // update the specified columns and the rest keep it as it is
            //    context.SaveChanges();
            //    Console.WriteLine("done");
            //}
            //// Remove Records
            //{
            //    context.Remove(new Book() { BookId = 11 });
            //    context.SaveChanges();
            //}

            // Remove Related Data
            {
                // Default Removing Behavior is Cascade : if we remove the Parent remove the children automatic
                // but if we change the behavior in dbContext to Restricted : will return exception when 
                // we try to delete parent that has children
                // the third behavior is SetNull : it sets the foriegn key and we should ensure that is nullabal in childrens to null when we delete the parent

                // to delete when it is restrictd remove the childrens first then parent


            }

            // Transactions
            {
                /*
                 * to use Transacions must use TryCatch Blocks
                 * each statement end with SaveChanges()
                 * transaction must ends with commit to save it in database if statemnts Excuted correct
                 * if no thro exception**/
                using var transaction = context.Database.BeginTransaction();
                try
                {
                    context.Books.Add(new Book() {  BookName = "transaction 1" });
                    context.SaveChanges();

                    transaction.CreateSavepoint("Save point"); // if I want to commit previous statement if it's correct

                    context.Books.Add(new Book() { BookId = 20, BookName = "transaction 2" });
                    context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.RollbackToSavepoint("Save point");
                    transaction.Commit();
                    transaction.Rollback(); // to return the databse to the stute before transaction happen
                }
                
            }
            Console.ReadKey();




        }
    }
}
