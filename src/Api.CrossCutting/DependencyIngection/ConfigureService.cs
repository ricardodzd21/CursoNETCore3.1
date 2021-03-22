using Api.Domain.Interfaces.Services.User;
using Api.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyIngection
{
  public class ConfigureService
  {
    public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
    {
      serviceCollection.AddTransient<IUserService, UserService>();
    }

  }
}
