using DbPractice.DataBase;
using DbPractice.Model;

namespace DbPractice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            StoreAppDataBase context = new StoreAppDataBase();

            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. All Product");
                Console.WriteLine("3. Remove Product");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice : ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddProduct(context);
                        break;
                    case "2":
                        ShowProducts(context);
                        break;
                    case "3":
                        DeleteProduct(context);
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
            }
        }

        private static void AddProduct(StoreAppDataBase context)
        {
            Console.Write("Product Name : ");
            string name = Console.ReadLine();

            Console.Write("Product Price : ");
            double price = double.Parse(Console.ReadLine());

            Product product = new Product
            {
                Name = name,
                Price = price,
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };

            context.Products.Add(product);
            context.SaveChanges();

            Console.WriteLine("Add Product ");
            Console.ReadKey();
        }

        private static void ShowProducts(StoreAppDataBase context)
        {
            var products = context.Products.Where(p => !p.IsDeleted).ToList();

            Console.WriteLine("\nAll Product ");
            foreach (var p in products)
            {
                Console.WriteLine($"{p.Id} - {p.Name} - {p.Price}$");
            }
            Console.ReadKey();
        }

        private static void DeleteProduct(StoreAppDataBase context)
        {
            Console.Write("Remove Product ID : ");
            int id = int.Parse(Console.ReadLine());

            var product = context.Products.Find(id);
            if (product != null)
            {
                product.IsDeleted = true;
                product.DeletedDate = DateTime.Now;
                context.SaveChanges();
                Console.WriteLine("Remove");
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.ReadKey();
        }
    }
}
