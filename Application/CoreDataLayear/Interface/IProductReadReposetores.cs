using DominLayear.IRepositores;
using DominLayear.ReadModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayear.Interface
{
    public interface IProductReadReposetores : IAsyncReadRepository<ProductReadModel>
    {
    }
}
