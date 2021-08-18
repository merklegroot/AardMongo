using MongoDB.Driver;
using System;

namespace AardMongo
{
    [Obsolete("Use IMongoCollectionContext instead")]
    public interface IMongoContext
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string CollectionName { get; set; }

        IMongoCollection<TEntity> GetCollection<TEntity>();
        void DropCollection();
    }
}
