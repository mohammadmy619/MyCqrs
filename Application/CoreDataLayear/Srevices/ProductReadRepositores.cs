using CoreLayear.Interface;
using DataLayear.Repositores;
using DominLayear.ReadModels;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayear.Srevices
{
    public class ProductReadRepositores : ReadRepositoryBase<ProductReadModel>, IProductReadReposetores
    {
        public ProductReadRepositores(IMongoClient client) : base(client)
        {
        }
    }
}
