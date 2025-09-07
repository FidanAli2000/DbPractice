using DbPractice.Model;

namespace DbPractice.Services.Abstract;

public interface IProductService
{
    public void Add(Product item);
    public void Remove(Product item);
    public Product GetById(int id);
    public List<Product> GetAll();
}
