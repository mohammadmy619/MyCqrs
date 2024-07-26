//using DominLayear.ReadModels;
//using MongoDB.Driver;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataLayear.ReadContext
//{
//    public class CatalogContextSeed
//    {

//        public static void SeedData(IMongoCollection<ProductReadModel> productCollection)
//        {
//            bool existProduct = productCollection.Find(p => true).Any();

//            if (!existProduct)
//            {
//                productCollection.InsertManyAsync(GetSeedData());
//            }
//        }


//        private static IEnumerable<ProductReadModel> GetSeedData()
//        {
//            return new List<ProductReadModel>()
//            {

//                new ProductReadModel()
//                {
//                   ID=1,
//                   CreateDate=DateTime.Now,
//                   CreatedBy="mohammad",
//                   GroupName="apple",
//                   Discreptsion="test",
//                   ImageName="test",
//                   LastModifiedBy="mohammad",
//                   Name="test",
//                   ModifiedDate=DateTime.Now,
//                   Price=1000,

//                },
//                new ProductReadModel()
//                {
//                   ID=2,
//                   CreateDate=DateTime.Now,
//                   CreatedBy="mohammad3",
//                   GroupName="apple3",
//                   Discreptsion="test3",
//                   ImageName="test3",
//                   LastModifiedBy="mohammad3",
//                   Name="test3",
//                   ModifiedDate=DateTime.Now,
//                   Price=1000,

//                },
//                new ProductReadModel()
//                {
//                   ID=3,
//                   CreateDate=DateTime.Now,
//                   CreatedBy="mohammad",
//                   GroupName="apple2",
//                   Discreptsion="test2",
//                   ImageName="test2",
//                   LastModifiedBy="mohammad",
//                   Name="test2",
//                   ModifiedDate=DateTime.Now,
//                   Price=1000,

//                }
//        };
//        }
//    }
    
//}



