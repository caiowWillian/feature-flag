
using System.Collections.Generic;
using System.Threading.Tasks;
using FeatureFlag.Domain.Infraestructure;

namespace FeatureFlag.Infraestructure.Repositories
{
    public class MongoRepository<T> : IRepository<T>
    {
        public Task<IList<T>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<T> GetByIdentifier(string identifier)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Put(T item)
        {
            throw new System.NotImplementedException();
        }
    }
}