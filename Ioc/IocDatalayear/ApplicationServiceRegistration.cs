using CoreLayear.Interface;
using CoreLayear.Srevices;
using DataLayear.Context;
using DataLayear.Repositores;
using DominLayear.IRepositores;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IocDatalayear
{


    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MyAppContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("CQRS"));
            });

            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));

            services.AddScoped<IProductReposetores, ProductRepositores>();

            //services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddScoped(typeof(IAsyncReadRepository<>), typeof(ReadRepositoryBase<>));

            services.AddScoped<IProductReadReposetores, ProductReadRepositores>();


            services.AddSingleton<IMongoClient, MongoClient>(option =>
            {
                return new MongoClient("mongodb://localhost:27017");
            }
            
            );
            

            //services.AddAutoMapper(typeof(CoreLayear).Assembly.GetExecutingAssembly());


            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

            return services;
        }
    }


}
