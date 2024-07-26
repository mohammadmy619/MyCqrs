using CoreLayear.Behaviors;
using CoreLayear.Behaviours;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayear
{
    public static class ApplicationServiceIoc
    {

        
       
        public static IServiceCollection AddApplicationIoc(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            //services.AddStackExchangeRedisCache(options =>
            //{
            //    options.Configuration = configuration.GetValue<string>("CacheSettings:ConnectionString");


            //});
            return services;

        }
    }
}
