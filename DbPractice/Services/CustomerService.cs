using DbPractice.DataBase;
using DbPractice.Model;
using DbPractice.Services.Abstract;

namespace DbPractice.Services;

public class CustomerService : BaseService, ICustomerService
{
    public CustomerService(StoreAppDataBase context) : base(context)
    {
    }

    public void Add(Customer item)
    {
        _context.Customers.Add(item);
    }

    public List<Customer> GetAll()
    {
        return _context.Customers.ToList();
    }

    public Customer GetById(int id)
    {
        return _context.Customers.Find(id);
    }
    public void Remove(Customer item)
    {
       var customer = _context.Customers.Find(item.Id);
        if (customer != null)
        {
            customer.IsDeleted = true;
            customer.DeletedDate = DateTime.Now;
        }
    }
}
