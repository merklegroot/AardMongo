using MongoDB.Driver;

namespace AardMongo
{
    public interface IMongoDatabaseContext
    {
        string DatabaseName { get; }
        string ConnectionString { get; }
        IMongoClient GetClient();
        IMongoDatabase GetDatabase();
    }
}
