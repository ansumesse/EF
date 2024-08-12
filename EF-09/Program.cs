using EF_09.Models;

namespace EF_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new AppDbContext();
            var blog = new Blog() { Url = "google.com" };
            context.Blogs2.Add(blog);
            var author = new Author() { FirstName = "Mohamed", LastName = "Anas" };
            context.Authors.Add(author);
            context.SaveChanges();
        }
    }
}
