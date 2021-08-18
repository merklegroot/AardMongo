namespace AardMongo
{
    public interface IMongoRepo<TEntity, TId>
    {
        void Insert(MongoCollectionContext context, TEntity entity);        
    }
}
