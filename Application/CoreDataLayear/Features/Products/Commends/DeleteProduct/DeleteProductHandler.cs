using AutoMapper;
using CoreLayear.Events.EventNotification;
using CoreLayear.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayear.Features.Products.Commends.DeleteProduct
{
    public class DeleteProductHandler : IRequestHandler<DeleteProductCommand>
    {

        private IProductReposetores _ProductReposetores;

        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public DeleteProductHandler(IProductReposetores productReposetores, IMapper mapper, IMediator mediator)
        {
            _ProductReposetores = productReposetores;
            _mapper = mapper;
            _mediator = mediator;
        }
        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var GetProduct = await _ProductReposetores.GetProdcutDetial(request.ID);

            if(GetProduct != null)
            {
                await _ProductReposetores.DeleteAsync(GetProduct);

                await _mediator.Publish(new ProductDeleteNotification {ID=GetProduct.ID } );

            }
            return Unit.Value;

        }
    }
}
