using Rush.Data;

namespace Rush.Services;

public static class ServicesRegister
{
    public static void AddServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddDbContext<DataContext>();
        serviceCollection.AddScoped<IRepo,Repo>();
        serviceCollection.AddScoped<IFileServing,FileServing>();
    }
}