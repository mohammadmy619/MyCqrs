using CoreLayear.Interface;
using DataLayear.Context;
using DataLayear.Repositores;
using DominLayear.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayear.Srevices
{
    public class ProductRepositores : RepositoryBase<Products>, IProductReposetores
    {
        public ProductRepositores(MyAppContext dbContext) : base(dbContext) { }
        

        

      
        public async Task<Products> GetProdcutDetial(long ID)
        {
            var entity = await _dbContext.Prodcuts.Where(s => s.ID == ID).SingleOrDefaultAsync();

                
            return entity;

        }
        public async Task<List<Products>> GetProdcutList()
        {
            var entity = await _dbContext.Prodcuts.ToListAsync();


            return entity;

        }
    }
}
