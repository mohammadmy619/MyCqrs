using AutoMapper;
using CoreLayear.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayear.Features.Products.Queries.ProductDetail
{
    public class GetProductDetailHandler : IRequestHandler<GetProductDetial, ProductDetailDto>
    {
        private IProductReposetores _ProductReposetores;

        private IProductReadReposetores _ProductReadReposetores;

        private readonly IMapper _mapper;


        public GetProductDetailHandler(IProductReposetores productReposetores, IMapper mapper, IProductReadReposetores productReadReposetores)
        {
            _ProductReposetores = productReposetores;
            _mapper = mapper;
            _ProductReadReposetores = productReadReposetores;
        }

        public async Task<ProductDetailDto> Handle(GetProductDetial request, CancellationToken cancellationToken)
        {
            //var res = await _ProductReposetores.GetProdcutDetial(request.ID);

            var res = await _ProductReadReposetores.GetbyIdAsync(request.ID);


            /*return _mapper.Map<ProductDetailDto>(res)*/

            return new ProductDetailDto
            {

                ID = res.productid,

                Discreptsion = res.Discreptsion,

                GroupName = res.GroupName,

                ImageName = res.ImageName,

                Name = res.Name,

                Price = res.Price,

            };
            //return new ProductDetailDto();

        }
    }
}
