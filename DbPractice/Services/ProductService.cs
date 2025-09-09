using DbPractice.DataBase;
using DbPractice.Model;
using DbPractice.Services.Abstract;

namespace DbPractice.Services;

public class ProductService : BaseService, IProductService
{
    public ProductService(StoreAppDataBase context) : base(context)
    {
    }

    public void Add(Product item)
    {
        _context.Products.Add(item);
    }

    public List<Product> GetAll()
    {
        return _context.Products.ToList();
    }

    public Product GetById(int id)
    {
        return _context.Products.Find(id);
    }

    public void Remove(Product item)
    {
       var product =_context.Products.Find(item.Id);
        if (product != null)
        {
            product.IsDeleted = true;
            product.DeletedDate = DateTime.Now;
        }
    }
}
