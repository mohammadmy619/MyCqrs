using AutoMapper;
using CoreLayear.Interface;
using DominLayear.ReadModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayear.Features.Products.Queries.ProductList
{
    public class GetProductListHandler : IRequestHandler<GetProductList, List<ProductListDto>>
    {
        private IProductReposetores _ProductReposetores;

        private readonly IMapper _mapper;

        private IProductReadReposetores _ProductReadReposetores;
        public GetProductListHandler(IProductReposetores ProductReposetores, IMapper mapper, IProductReadReposetores ProductReadReposetores)
        {
            _ProductReposetores = ProductReposetores;
            _mapper = mapper;
            _ProductReadReposetores = ProductReadReposetores;
        }

        async Task<List<ProductListDto>> IRequestHandler<GetProductList, List<ProductListDto>>.Handle(GetProductList request, CancellationToken cancellationToken)
        {
            //var res = await _ProductReposetores.GetAllAsync();
            var res = await _ProductReadReposetores.GetAllAsync();

            if (res.Count() == 0)
            {
                var getAllproducts = await _ProductReposetores.GetAllAsync();

                if (getAllproducts != null)
                {
                    //var ListInsert= _mapper.Map<List<ProductReadModel>>(getAllproducts);

                  

                    foreach (var item in getAllproducts)
                    {

                        await _ProductReadReposetores.Insert(new ProductReadModel
                        {
                            CreateDate = DateTime.Now,
                            Discreptsion = item.Discreptsion,
                            GroupName = item.GroupName,
                            ImageName = item.ImageName,
                            Name = item.Name,
                            LastModifiedBy = "nall",
                            CreatedBy = item.CreatedBy,
                            Price = item.Price,
                            productid = item.ID,
                           
                        });

                    }

                    //await _ProductReadReposetores.ListInsert(ListInsert);

                    var NewProducts = await _ProductReadReposetores.GetAllAsync();

                    var NewMapproducts = new List<ProductListDto>();

                    foreach (var item in NewProducts)
                    {
                        NewMapproducts.Add(new ProductListDto
                        {

                            Discreptsion = item.Discreptsion,
                            GroupName = item.GroupName,
                            ID = item.productid,
                            ImageName = item.ImageName,
                            Name = item.Name,
                            Price = item.Price



                        });
                    }


                    return NewMapproducts;

                    //var NewMapproducts = _mapper.Map<List<ProductListDto>>(NewProducts);

                    //return NewMapproducts.ToList();
                }

            }

            //var products = _mapper.Map<List<ProductListDto>>(res);


            var products = new List<ProductListDto>();

            foreach (var item in res)
            {
                products.Add(new ProductListDto
                {

                    Discreptsion = item.Discreptsion,
                    GroupName = item.GroupName,
                    ID = item.productid,
                    ImageName = item.ImageName,
                    Name = item.Name,
                    Price = item.Price



                });
            }


            return products;




        }
    }
}
