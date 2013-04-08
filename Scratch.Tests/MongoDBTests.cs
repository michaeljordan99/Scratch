using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using System.Drawing;
using System.Linq;

namespace Scratch.Tests
{
    public class Entity
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
    }

    [TestClass]
    public class MongoDBTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //var connectionString = "mongodb://cip-mongo:Tex5JoPsJDbuNyVRdpu4smWeNLsLvsiKfyo@ds041177.mongolab.com:41177/MongoLab-5>mongolab.com:41177/MongoLab-5";
            var connectionString = "mongodb://cip-test:test@ds041177.mongolab.com:41177/MongoLab-5";

            var client = new MongoClient(connectionString);

            var server = client.GetServer();

            var database = server.GetDatabase("MongoLab-5"); // "test" is the name of the database

            Image image = Image.FromFile(@"c:\temp\signature.jpg");
            ImageConverter converter = new ImageConverter();
            var imageBytes = (byte[])converter.ConvertTo(image, typeof(byte[]));

            var collection = database.GetCollection<Entity>("entities");
            var entity = new Entity { Name = "Google", Image = imageBytes };
            collection.Insert(entity);
            var id = entity.Id; // Insert will set the Id if necessary (as it was in this example)
            var query = Query<Entity>.EQ(e => e.Id, id);
            var returnEntity = collection.FindOne(query);

        }

        [TestMethod]
        public void ImageTest()
        {
            Image image = Image.FromFile(@"c:\temp\google.png");

            ImageConverter converter = new ImageConverter();

            var bytes = (byte[])converter.ConvertTo(image, typeof(byte[]));
        }

        [TestMethod]
        public void BsonObjectTest()
        {
            var json = "{ 'TransactionType' : 'Sale', TransFields: { 'AmountFee' : 100.50 }, Customer : { Name : 'Michael' } }";
            var document = BsonDocument.Parse(json);
        }
    }
}
