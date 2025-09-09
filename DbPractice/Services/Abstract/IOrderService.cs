using DbPractice.Model;

namespace DbPractice.Services.Abstract;

public interface IOrderService
{
    public void Add(Order item);
    public void Remove(Order item);
    public Order GetById(int id);
    public List<Order> GetAll();
}
