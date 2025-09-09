using DbPractice.DataBase;
using DbPractice.Model;
using DbPractice.Services.Abstract;

namespace DbPractice.Services;

public class OrderService : BaseService, IOrderService
{
    public OrderService(StoreAppDataBase context) : base(context)
    {
    }

    public void Add(Order item)
    {
       _context.Orders.Add(item);
    }

    public List<Order> GetAll()
    {
       return _context.Orders.ToList();
    }

    public Order GetById(int id)
    {
        return _context.Orders.Find(id);
    }

    public void Remove(Order item)
    {
        var order = _context.Orders.Find(item.Id);
        if (order != null)
        {
            order.IsDeleted = true;
            order.DeletedDate = DateTime.Now;
        }
    }
}
