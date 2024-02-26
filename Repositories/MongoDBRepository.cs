using MongoDB.Driver;

namespace MongoDbAPI.Repositories
{
    public class MongoDBRepository
    {
        public MongoClient client;
        public IMongoDatabase db { get; set; }
        public MongoDBRepository() 
        {
            client = new MongoClient("mongodb://127.0.0.1:27017");

            db = client.GetDatabase("Inventory");
        }
    }
}
