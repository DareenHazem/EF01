using EF_Core_Assignment01.Contexts;

namespace EF_Core_Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (BookStoreDbContext db = new BookStoreDbContext())
            {
                Console.WriteLine("Database context created successfully!");
            }
        }
    }
}
