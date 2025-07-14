using Gazprom.CarLeasing.Dto;

namespace Gazprom.CarLeasing.Application.Services;

public interface ISupplierService
{
    /// <summary>
    /// Получить топ-3 поставщиков.
    /// </summary>
    /// <param name="cancellation">Токен отмены.</param>
    /// <returns>Список топ-3 поставщиков.</returns>
    public Task<ICollection<SupplierShortDto>> GetTopSuppliersAsync(CancellationToken cancellation);
}
