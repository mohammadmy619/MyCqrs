using AutoMapper;
using CoreLayear.Events.EventNotification;
using CoreLayear.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayear.Events.Eventhandler
{
    internal class ProductDeleteNotificationHandler : INotificationHandler<ProductDeleteNotification>
    {

        private IProductReposetores _ProductReposetores;

        

        private IProductReadReposetores _ProductReadReposetores;
        public ProductDeleteNotificationHandler(IProductReposetores ProductReposetores, IProductReadReposetores ProductReadReposetores)
        {
            _ProductReposetores = ProductReposetores;          
            _ProductReadReposetores = ProductReadReposetores;
        }
        public async Task Handle(ProductDeleteNotification notification, CancellationToken cancellationToken)
        {

                   await _ProductReadReposetores.DeletebyId(notification.ID);

        }
    }
}
