using System.Reflection;

namespace DbPractice.Model;

public class Customer : BaseModel
{
    public string? Name { get; set; }
    public string? Surname { get; set; }

    public List<Product>? Products { get; set; }

    public List<Order>? Orders { get; set; }

}
