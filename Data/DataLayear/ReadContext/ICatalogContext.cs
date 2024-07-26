using DominLayear.ReadModels;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayear.ReadContext
{
   public interface ICatalogContext
    {
        IMongoCollection<ProductReadModel> ProductReadModel { get; }
    
    }
}
