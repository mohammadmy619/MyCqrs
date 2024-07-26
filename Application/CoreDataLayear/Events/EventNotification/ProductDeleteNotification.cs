using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayear.Events.EventNotification
{
    public class ProductDeleteNotification: INotification
    {
        public long ID { get; set; }
    }
}
