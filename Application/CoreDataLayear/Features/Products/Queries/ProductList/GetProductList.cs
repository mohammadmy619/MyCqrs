using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayear.Features.Products.Queries.ProductList
{
    public class GetProductList: IRequest<List<ProductListDto>>
    {

    }
}
