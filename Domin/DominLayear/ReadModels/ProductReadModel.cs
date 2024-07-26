using DominLayear.Commen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominLayear.ReadModels
{
    public class ProductReadModel: ReadEntitybase
    {
        
        public string GroupName { get; set; }

      
        public string Name { get; set; }


        public string Discreptsion { get; set; }

        public string ImageName { get; set; }

       
        public long Price { get; set; }
    }
}
