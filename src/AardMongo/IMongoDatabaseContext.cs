using MongoDB.Driver;

namespace AardMongo
{
    public interface IMongoDatabaseContext
    {
        string DatabaseName { get; set; }
        string ConnectionString { get; set; }
        IMongoClient GetClient();
        IMongoDatabase GetDatabase();
    }
}
