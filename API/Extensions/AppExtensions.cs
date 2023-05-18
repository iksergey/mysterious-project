using Core.Infrastructure;
using Core.Interfaces;
using Mathematics.CalculateArea;

namespace API.Extensions
{
  public static class AppExtensions
  {
    public static IServiceCollection AddCalculateAreaModel(this IServiceCollection services)
    {
      services.AddScoped<IModel, CalcModel<CalculateArea, ShapeInformation>>();
      return services;
    }
  }
}