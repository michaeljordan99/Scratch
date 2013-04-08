using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scratch.Repositories
{
    public class Entity
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
    }

    public class MongoRepository
    {
        const string _connectionString = "mongodb://cip-test:test@ds041177.mongolab.com:41177/MongoLab-5";
        MongoDatabase _database;

        public MongoRepository()
        {
            _database = new MongoClient(_connectionString).GetServer().GetDatabase("MongoLab-5"); 
        }

        public Entity Get(string id)
        {
            //var id = new ObjectId("516058af1b5a6f0c88c7491b");
            var objectId = new ObjectId(id);
            var query = Query<Entity>.EQ(e => e.Id, objectId);
            var entity = _database.GetCollection<Entity>("entities").FindOne(query);

            return entity;
        }
    }
}