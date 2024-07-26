using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoreLayear.Behaviours
{
    public class ValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationBehaviour(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }


        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            if (_validators.Any())
            {


                var validationContext = new ValidationContext<TRequest>(request);

                var validationResult = await Task.WhenAll(_validators.Select(x => x.ValidateAsync(validationContext, cancellationToken)));
                var errors = validationResult.SelectMany(x => x.Errors).Where(x => x != null).ToList();
                if (errors.Count != 0)
                {
                    //string error = "";
                    //foreach (var item in errors)
                    //    error += item.ErrorMessage + "\n";
                    throw new System.ComponentModel.DataAnnotations.ValidationException(errors.ToString());
                }


                //    var context = new ValidationContext<TRequest>(request);


                //    var validationResults = await Task.WhenAll(_validators.Select(v => v.ValidateAsync(context, cancellationToken)));


                //    var failures = validationResults.SelectMany(r => r.Errors).Where(a => a != null).ToList();


                //    if (failures.Count > 0)
                //        //throw new System.ComponentModel.DataAnnotations.ValidationException(failures.ToString());
                //        throw new ValidationException(failures.ToString());
             }

                return await next();
        }
    }
}
