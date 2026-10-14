
using Microsoft.EntityFrameworkCore;
using Todo.Infrastructure.Persistence.Entities;

namespace Todo.api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<TodoAppDbContext>(options => options.UseSqlServer(connectionString));


            services.AddSwaggerGen();

            return services;
        }
}
