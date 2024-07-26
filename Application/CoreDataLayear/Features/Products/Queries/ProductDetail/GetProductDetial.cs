using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayear.Features.Products.Queries.ProductDetail
{
    public class GetProductDetial : IRequest<ProductDetailDto>
    {
        public long ID { get; set; }

        public GetProductDetial(long iD)
        {
            ID = iD;
        }
    }
}
