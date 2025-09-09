namespace DbPractice.Model;

public class Product: BaseModel
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public double Price { get; set; }


    public List<Customer>? Customers { get; set; }

    public List<Order>? Orders { get; set; }


}
