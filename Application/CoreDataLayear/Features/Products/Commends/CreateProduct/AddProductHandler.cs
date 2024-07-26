using AutoMapper;
using CoreLayear.Events.EventNotification;
using CoreLayear.Interface;
using DominLayear.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayear.Features.Products.Commends.CreateProduct
{
    public class AddProductHandler : IRequestHandler<AddProduct, long>
    {

        private IProductReposetores _ProductReposetores;

        private readonly IMapper _mapper;

        private readonly IMediator _mediator;

        public AddProductHandler(IProductReposetores productReposetores, IMapper mapper,IMediator mediator)
        {
            _ProductReposetores = productReposetores;
            _mapper = mapper;
            _mediator = mediator;   
        }

        public async Task<long> Handle(AddProduct request, CancellationToken cancellationToken)
        {
            var productEntity = _mapper.Map<DominLayear.Models.Products>(request);

            var newproduct = await _ProductReposetores.AddAsync(productEntity);

            var productcreatednotification = _mapper.Map<ProductCreatedNotification>(productEntity);


            await _mediator.Publish(productcreatednotification);



            return newproduct.ID;

        }
    }
}
