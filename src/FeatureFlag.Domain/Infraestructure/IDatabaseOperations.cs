using System.Collections.Generic;
using System.Threading.Tasks;

namespace FeatureFlag.Domain.Infraestructure
{
    public interface IDatabaseOperations<T> where T : class
    {
        Task<bool> Put(T item);
        Task<IList<T>> GetAll();
        Task<T> GetByIdentifier(string identifier); 
    }
}