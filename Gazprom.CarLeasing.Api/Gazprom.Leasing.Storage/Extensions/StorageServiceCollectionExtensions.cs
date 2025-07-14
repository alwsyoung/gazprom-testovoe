using Gazprom.CarLeasing.Application.StorageInterfaces;
using Gazprom.CarLeasing.Storage.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Gazprom.CarLeasing.Storage.Extensions;

/// <summary>
/// Методы расширения для <see cref="IServiceCollection"/>. Работа с уровнем хранилища.
/// </summary>
public static class StorageServiceCollectionExtensions
{
    public static IServiceCollection ConfigureRepositories(this IServiceCollection services) =>
        services
        .AddScoped<IOfferRepository, OfferRepository>()
        .AddScoped<ISupplierRepository, SupplierRepository>();
}

