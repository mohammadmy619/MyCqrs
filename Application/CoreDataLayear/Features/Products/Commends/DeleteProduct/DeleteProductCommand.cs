using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayear.Features.Products.Commends.DeleteProduct
{
    public class DeleteProductCommand:IRequest
    {

        public long ID { get; set; }
        public DeleteProductCommand(long iD)
        {
            ID = iD;
        }
    }
}
