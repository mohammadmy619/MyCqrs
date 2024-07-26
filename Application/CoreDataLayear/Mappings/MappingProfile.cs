using AutoMapper;
using CoreLayear.Events.EventNotification;
using CoreLayear.Features.Products.Commends.CreateProduct;
using CoreLayear.Features.Products.Commends.EditProduct;
using CoreLayear.Features.Products.Queries.ProductDetail;
using CoreLayear.Features.Products.Queries.ProductList;
using DominLayear.Models;
using DominLayear.ReadModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayear.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Products, ProductDetailDto>().ReverseMap();

            CreateMap<ProductReadModel, ProductDetailDto>().ReverseMap();

            //CreateMap<ProductReadModel, ProductListDto>().ReverseMap();

            CreateMap<ProductReadModel, Products>().ReverseMap();
           

            CreateMap<Products, ProductListDto>().ReverseMap();

            CreateMap<Products, AddProduct>().ReverseMap();

            CreateMap<Products, EditProductCommand>().ReverseMap();


            CreateMap<ProductReadModel, ProductCreatedNotification>().ReverseMap();

            CreateMap<ProductReadModel, ProductEditNotification>().ReverseMap();


            CreateMap<EditProductCommand, ProductEditNotification>().ReverseMap();

            CreateMap<Products, ProductCreatedNotification>().ReverseMap();






        }
    }
}
