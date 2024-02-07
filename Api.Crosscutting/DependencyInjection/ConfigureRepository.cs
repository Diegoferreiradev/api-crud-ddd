using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Crosscutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependeciesRepository(IServiceCollection servicesCollection)
        {
            servicesCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

            servicesCollection.AddDbContext<MyContext>(
           options => options.UseSqlServer("Server=DESKTOP-UHLS283;Database=dbAPI;Trusted_Connection=True;"));
        }
    }
}
