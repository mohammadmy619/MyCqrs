using DominLayear.ReadModels;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayear.ReadContext
{
    public class CatalogContext : ICatalogContext
    {

        //IMongoCollection<ProductReadModel> ProductReadModels { get; }



        //public CatalogContext(IConfiguration configuration)
        //{
        //    var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));

        //    var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));

        //    ProductReadModels = database.GetCollection<ProductReadModel>(configuration.GetValue<string>("DatabaseSettings:CollectionName"));
        //    CatalogContextSeed.SeedData(ProductReadModels);
        //}
        public IMongoCollection<ProductReadModel> ProductReadModel => throw new NotImplementedException();
    }
}
