using DbPractice.DataBase;
using DbPractice.Model;

namespace DbPractice
{
   public  class Program
    {
        private static void Main(string[] args)
        {
           StoreAppDataBase context = new StoreAppDataBase();

            Product product = new Product
            {
                Name = "Iphone 14",
                Price = 1500,
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };
            Product product2 = new Product
            {
                Name = "Samsung S23",
                Price = 1400,
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };

            Product product3 = new Product
            {
                Name = "Xiaomi 13",
                Price = 1300,
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };

            context.Products.AddRange(product, product2, product3);

            Customer customer1 = new Customer
            {
                Name = "Laz",
                Surname = "Ziya",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            };

            Customer customer2 = new Customer
            {
                Name = "Polad",
                Surname = "Alemdar",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };
            Customer customer3 = new Customer
            {
                Name = "Memati",
                Surname = "Bas",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };

            context.Customers.AddRange(customer1, customer2, customer3);

            Order order1 = new Order
            {
                TotalPrice = 1500,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                Customer = customer3
            };
            Order order2 = new Order
            {
                TotalPrice = 1400,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                Customer = customer1
            };
            Order order3 = new Order
            {
                TotalPrice = 1300,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                Customer = customer2
            };

            context.Orders.AddRange(order1, order2, order3);

            context.SaveChanges();

            
            
        }
    }
}
