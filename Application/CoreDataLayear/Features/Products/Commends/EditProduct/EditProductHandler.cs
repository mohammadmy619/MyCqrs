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

namespace CoreLayear.Features.Products.Commends.EditProduct
{
    public class EditProductHandler : IRequestHandler<EditProductCommand>
    {
        private IProductReposetores _ProductReposetores;

        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public EditProductHandler(IProductReposetores productReposetores, IMapper mapper, IMediator mediator)
        {
            _ProductReposetores = productReposetores;
            _mapper = mapper;
            _mediator = mediator;
        }


        async Task<Unit> IRequestHandler<EditProductCommand, Unit>.Handle(EditProductCommand request, CancellationToken cancellationToken)
        {

            var GetProduct = await _ProductReposetores.GetProdcutDetial(request.ID);

            if (GetProduct != null)
            {
                //var record =_mapper.Map<Prodcuts>(request);

                _mapper.Map(request, GetProduct, typeof(EditProductCommand), typeof(DominLayear.Models.Products));

               

                await _ProductReposetores.UpdateAsync(GetProduct);

                
                //var productcreatednotification = _mapper.Map<ProductEditNotification>(request);

                var productcreatednotification = new ProductEditNotification
                {
                    CreatedBy = request.CreatedBy,
                    Discreptsion = request.Discreptsion,
                    GroupName = request.GroupName,
                    Productid = request.ID,
                    ImageName = request.ImageName,
                    Name = request.Name,
                    Price = request.Price

                };


                await _mediator.Publish(productcreatednotification);


            }
            return Unit.Value;


        }
    }
}
