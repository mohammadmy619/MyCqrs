using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayear.Features.Products.Commends.EditProduct
{
    public class EditProductProductValidation:AbstractValidator<EditProductCommand>
    {

        public EditProductProductValidation()
        {
            RuleFor(a => a.ID)
              .NotEmpty().WithMessage("{ID} is required")
               .NotNull();


            RuleFor(a => a.Name)
               .NotEmpty().WithMessage("{Name} is required")
               .NotNull()
               .MaximumLength(50).WithMessage("{UserName} must not exceed 50 characters");

            RuleFor(a => a.GroupName)
                .NotEmpty().WithMessage("{Email} is required");


            RuleFor(a => a.Discreptsion)
             .NotEmpty().WithMessage("{Discreptsion} is required")
             .MaximumLength(200).WithMessage("{Discreptsion} must not exceed 200 characters");



            RuleFor(a => a.CreatedBy)
             .NotEmpty().WithMessage("{CreatedBy} is required")
            .MaximumLength(30).WithMessage("{CreatedBy} must not exceed 30 characters");


            RuleFor(a => a.Price)
             .NotEmpty().WithMessage("{Price} is required")
             .GreaterThan(0).WithMessage("{Price} should be greater than 0");
        }
    }
}
