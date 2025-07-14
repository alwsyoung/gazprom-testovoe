using Gazprom.CarLeasing.Application.StorageInterfaces;
using Gazprom.CarLeasing.Dto;

namespace Gazprom.CarLeasing.Storage.Repositories;

internal class SupplierRepository() : ISupplierRepository
{
    /// <inheritdoc/>
    public Task<ICollection<SupplierShortDto>> GetTopSuppliersAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
