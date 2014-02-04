using System.Collections.Generic;

namespace BusinessLayer.Repository
{
    public interface IMainRepository<TRepository>
    {
        string Save(TRepository obj);
        string Update(TRepository obj);
        string Delete(TRepository obj);
        List<TRepository> Get();
        TRepository GetSingle<T>(T t);
    }
}
