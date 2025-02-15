using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
﻿using Microsoft.AspNetCore.Builder;

namespace Basket;

public static class BasketModule
{
    public static IServiceCollection AddBasketModule(this IServiceCollection services, 
        IConfiguration configuration)
    {
        // Add services to the container.
        //services
        //    .AddApplicationServices()
        //    .AddInfrastructureServices(configuration)
        //    .AddApiServices(configuration);

        return services;
    }

    public static IApplicationBuilder UseBasketModule(this IApplicationBuilder app)
    {
        // Configure the HTTP request pipeline.
        //app
        //    .UseApplicationServices()
        //    .UseInfrastructureServices()
        //    .UseApiServices();

        return app;
    }
}