using DominLayear.Commen;
using DominLayear.IRepositores;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayear.Repositores
{
    public class ReadRepositoryBase<T> : IAsyncReadRepository<T> where T : ReadEntitybase
    {
        private readonly IMongoCollection<T> _Collection;

        public ReadRepositoryBase(IMongoClient client)
        {
            var Database = client.GetDatabase("MyCqrs4");
            _Collection = Database.GetCollection<T>(nameof(T));
            
        }

        public async  Task<T> GetbyIdAsync(long Id)
        { 
            var res = await _Collection.Find(p => p.productid == Id).FirstOrDefaultAsync();
            return res;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var  res=  _Collection.Find(new BsonDocument()).ToList();


            return  res;


            //return await _Collection.FindAsync(p=>true)
        }

        public async Task DeletebyId(long Id)
        {
            await _Collection.DeleteOneAsync(d => d.productid == Id);
        }
        public async Task ListInsert(List<T> entity)
        {
            await _Collection.InsertManyAsync(entity);
        }
        public async Task Insert(T entity)
        {
            await _Collection.InsertOneAsync(entity);

        }

        public async Task Update(T entity)
        {
            var getentityid = await GetbyIdAsync(entity.productid);

            entity.id = getentityid.id;
            //await _Collection.
           await _Collection.ReplaceOneAsync(filter: p => p.productid == entity.productid, replacement: entity);
        }

    
    }
}
