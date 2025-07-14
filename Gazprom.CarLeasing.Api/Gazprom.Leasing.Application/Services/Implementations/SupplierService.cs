using Gazprom.CarLeasing.Application.StorageInterfaces;
using Gazprom.CarLeasing.Dto;

namespace Gazprom.CarLeasing.Application.Services.Implementations;

public class SupplierService(ISupplierRepository supplierRepository) : ISupplierService
{
    public async Task<ICollection<SupplierShortDto>> GetTopSuppliersAsync(
        CancellationToken cancellation)
    {
        return await supplierRepository.GetTopSuppliersAsync(cancellation);
    }
}
