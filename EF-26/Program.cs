using EF_26.Models;

namespace EF_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new AppDbContext();

            var order = new Order() { Amount = 322 };
            context.Orders.Add(order);
            context.SaveChanges();
             
            var ordertea = new OrderTesty() { Amount = 322 };
            context.OrderTesties.Add(ordertea);
            context.SaveChanges();

        }
    }
}
