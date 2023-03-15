using Backend.Data.IRepositories;
using Backend.Data.Repositories;
using Backend.Logic.ILogic;
using Backend.Logic;

namespace Backend.Helpers
{
    public static class Extensions
    {
        public static IServiceCollection InjectRepositories(this IServiceCollection services)
        {
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteLogic, ClienteLogic>();

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IBaseLogic<,>), typeof(BaseLogic<,>));

            return services;
        }

        public static IServiceCollection InjectServices(this IServiceCollection services)
        {
            return services;
        }


    }
}
