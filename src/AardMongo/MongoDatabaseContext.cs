using MongoDB.Driver;

namespace AardMongo
{
    public class MongoDatabaseContext : IMongoDatabaseContext
    {
        public string ConnectionString { get; init; }
        public string DatabaseName { get; init; }
        
        public MongoDatabaseContext() { }

        public MongoDatabaseContext(string connectionString, string databaseName)
        {
            ConnectionString = connectionString;
            DatabaseName = databaseName;
        }

        public IMongoClient GetClient()
        {
            return new MongoClient(ConnectionString);
        }

        public IMongoDatabase GetDatabase()
        {
            return GetClient().GetDatabase(DatabaseName);
        }
    }
}
