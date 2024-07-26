using DominLayear.Commen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominLayear.IRepositores
{
    public interface IAsyncReadRepository<T> where T : ReadEntitybase
    {
        Task<T> GetbyIdAsync(long Id);    
        Task<IEnumerable<T>> GetAllAsync();
      
        Task DeletebyId(long Id);

        Task Insert(T entity);
        Task ListInsert(List<T> entity);


        Task Update(T entity);  




    }
}
