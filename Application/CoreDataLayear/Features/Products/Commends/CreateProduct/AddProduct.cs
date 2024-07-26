using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayear.Features.Products.Commends.CreateProduct
{
    public class AddProduct:IRequest<long>
    {
        //response

      
      
        public string GroupName { get; set; }

       
        public string Name { get; set; }


        public string Discreptsion { get; set; }

        public string ImageName { get; set; }

   
        public long Price { get; set; }
        public string CreatedBy { get; set; }
    }
}
