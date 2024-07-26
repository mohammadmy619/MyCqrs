using DominLayear.Commen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominLayear.Models
{
    public class Products: EntityBase
    {
      

        [Required]
        [Display(Name ="عنوان گروه")]
        [MaxLength(200,ErrorMessage ="لطفا {0} را وارد کنید")]
        public string GroupName { get; set; }

        [Required]
        [Display(Name = "نام محصول")]
        public string Name { get; set; }

        [Required]
        [Display(Name = " جزییات")]
        [MaxLength(200, ErrorMessage = "لطفا {0} را وارد کنید")]
        public string   Discreptsion { get; set; }

        public string ImageName { get; set; }

        [Display(Name = " قیمت")]
        public long Price { get; set; }





    }
}
