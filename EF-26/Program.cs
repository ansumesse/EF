using EF_26.Models;

namespace EF_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var context = new AppDbContext();

            //var order = new Order() { Amount = 322 };
            //context.Orders.Add(order);
            //context.SaveChanges();

            //var ordertea = new OrderTesty() { Amount = 322 };
            //context.OrderTesties.Add(ordertea);
            //context.SaveChanges();
            SeedData();
        }
        // method to seed data in cars2
        public static void SeedData()
        {
            using(var context = new AppDbContext())
            {
                context.Database.EnsureCreated();

                var car = context.Cars2.FirstOrDefault(x => x.Make == "china");
                if (car is null)
                    context.Cars2.Add(new Car { Make = "chaina", LicensePlate = "nbvn", Model = "nnl", CarId = 7 });
                context.SaveChanges();
            }
        }
    }
}
