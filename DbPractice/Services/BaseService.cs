using DbPractice.DataBase;
using DbPractice.Model;

namespace DbPractice.Services;

public abstract class BaseService
{
    protected StoreAppDataBase _context;
    public BaseService(StoreAppDataBase context)
    {
        _context = context;
    }

  
}
