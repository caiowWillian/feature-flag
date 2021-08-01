using System.Collections.Generic;
using System.Threading.Tasks;

namespace FeatureFlag.Domain.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<bool> Put(T item);
        Task<IList<T>> GetAll();
        Task<T> GetByName(string identifier); 
    }
}