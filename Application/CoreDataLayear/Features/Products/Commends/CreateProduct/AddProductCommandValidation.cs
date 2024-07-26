using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayear.Features.Products.Commends.CreateProduct
{
    public class AddProductCommandValidation : AbstractValidator<AddProduct>
    {

        public AddProductCommandValidation()
        {
            RuleFor(a => a.Name)
                .NotEmpty().WithMessage("{Name} is required")
                .NotNull()
                .MinimumLength(2).WithMessage("FOR TEST")
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
