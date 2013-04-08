using System;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using System.Drawing;
using Scratch.Repositories;

namespace Scratch.Services
{
    public class ImageService
    {
        public byte[] GetImage(string id)
        {
            var repository = new MongoRepository();
            var entity = repository.Get(id);
            return entity.Image;
        }
    }
}