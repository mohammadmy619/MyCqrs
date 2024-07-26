using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayear.Features.Products.Commends.EditProduct
{
    public class EditProductCommand:IRequest
    {
        public long ID { get; set; }
        public string GroupName { get; set; }


        public string Name { get; set; }


        public string Discreptsion { get; set; }

        public string ImageName { get; set; }


        public long Price { get; set; }
        public string CreatedBy { get; set; }
    }
}
