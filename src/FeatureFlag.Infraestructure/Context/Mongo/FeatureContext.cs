using FeatureFlag.Domain.Models;
using MongoDB.Driver;

namespace FeatureFlag.Context.Mongo
{
    public class FeatureContext
    {
        private static MongoClient _client;
        
        public IMongoDatabase GetDatabase(string database, MongoDatabaseSettings settings = null) => GetMongoClient().GetDatabase(database,settings);

        private MongoClient GetMongoClient() => _client is null ? new MongoClient() : _client;

        public IMongoCollection<Feature> Features() => GetDatabase("feature",null).GetCollection<Feature>("feature");
    }
}