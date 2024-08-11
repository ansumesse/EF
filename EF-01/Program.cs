namespace EF_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbcontext = new ApplicationDBContext();
            var emp = new Employee() { Name = "Anas" };
            dbcontext.Employees.Add(emp);
            dbcontext.SaveChanges();
        }
    }
}
