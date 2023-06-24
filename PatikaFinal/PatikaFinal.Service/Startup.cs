using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PatikaFinal.Data.Context;
using PatikaFinal.Data.Repository.Interfaces;
using PatikaFinal.Data.Repository.Repositories;
using PatikaFinal.Data.UnitOfWork;
using PatikaFinal.Operation.Managers;
using PatikaFinal.Operation.Services;
using PatikaFinal.Service.RestExtension;

namespace PatikaFinal.Service
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddCustomSwaggerExtension();
            services.AddDbContextExtension(Configuration);

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserManager>();

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductManager>();

            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            services.AddScoped<IOrderDetailService, OrderDetailManager>();

            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderService, OrderManager>();

            services.AddScoped<ICouponRepository, CouponRepository>();
            services.AddScoped<ICouponService, CouponManager>();

            services.AddScoped<IMMProductCategoryRepository, MMProductCategoryRepository>();
            services.AddScoped<IMMProductCategoryService, MMProductCategoryManager>();

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICategoryService, CategoryManager>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Service v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
