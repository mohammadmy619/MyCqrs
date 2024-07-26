using AutoMapper;
using CoreLayear.Events.EventNotification;
using CoreLayear.Interface;
using DominLayear.ReadModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayear.Events.Eventhandler
{
    public class ProductEditNotificationHandler : INotificationHandler<ProductEditNotification>
    {
        private IProductReposetores _ProductReposetores;

        private readonly IMapper _mapper;

        private IProductReadReposetores _ProductReadReposetores;
        public ProductEditNotificationHandler(IProductReposetores ProductReposetores, IMapper mapper, IProductReadReposetores ProductReadReposetores)
        {
            _ProductReposetores = ProductReposetores;
            _mapper = mapper;
            _ProductReadReposetores = ProductReadReposetores;
        }

        public async Task Handle(ProductEditNotification notification, CancellationToken cancellationToken)
        {
            await _ProductReadReposetores.Update(new ProductReadModel
            {
                CreateDate = DateTime.Now,
                Discreptsion = notification.Discreptsion,
                GroupName = notification.GroupName,
                ImageName = notification.ImageName,
                Name = notification.Name,
                LastModifiedBy = "nall",
                CreatedBy = notification.CreatedBy,
                Price = notification.Price,
                productid = notification.Productid
            });
           
        }
    }
}
