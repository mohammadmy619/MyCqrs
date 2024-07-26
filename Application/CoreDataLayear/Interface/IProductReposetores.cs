using DominLayear.IRepositores;
using DominLayear.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayear.Interface
{
    public interface IProductReposetores: IAsyncRepository<Products>
    {
        Task<Products> GetProdcutDetial(long ID);
        Task<List<Products>> GetProdcutList();
    }
}
