namespace DbPractice.Model;

public class Order : BaseModel
{
    public double TotalPrice { get; set; }


    public int CustomerId { get; set; }
    public Customer? Customer { get; set; }

    public List<Product> Products { get; set; }
}
