using Microsoft.EntityFrameworkCore;
using PatikaFinal.Data.Context;

namespace PatikaFinal.Service.RestExtension
{
    public static class DbContextExtension
    {
        public static void AddDbContextExtension(this IServiceCollection services, IConfiguration Configuration)
        {
            var dbConfig = Configuration.GetConnectionString("MsSqlConnection");
            services.AddDbContext<PatikaDbContext>(opts =>
            opts.UseSqlServer(dbConfig));



        }
    }
}
