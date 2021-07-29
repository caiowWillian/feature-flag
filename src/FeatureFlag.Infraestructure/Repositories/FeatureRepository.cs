
using System.Collections.Generic;
using System.Threading.Tasks;
using FeatureFlag.Context.Mongo;
using FeatureFlag.Domain.Models;
using FeatureFlag.Domain.Repositories;
using MongoDB.Driver;
namespace FeatureFlag.Infraestructure.Repositories
{
    public class FeatureRepository: IRepository<Feature>
    {
        private FeatureContext _ctx;
        public FeatureRepository(FeatureContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<IList<Feature>> GetAll() => 
            await (await _ctx.Features()
                             .FindAsync(Builders<Feature>.Filter.Empty))
                             .ToListAsync();
        

        public Task<Feature> GetByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Put(Feature item)
        {
            throw new System.NotImplementedException();
        }
    }
}