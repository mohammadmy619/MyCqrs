using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominLayear.Commen
{
    public abstract class EntityBase
    {
        [Key]
        public long ID { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreateDate { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
