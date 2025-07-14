using Gazprom.CarLeasing.Dto;

namespace Gazprom.CarLeasing.Application.StorageInterfaces
{
    /// <summary>
    /// Интерфейс репозитория для работы с поставщиком
    /// </summary>
    public interface ISupplierRepository
    {
        /// <summary>
        /// Получить топ-3 поставщиков.
        /// </summary>
        /// <param name="cancellationToken">Токен отмены.</param>
        /// <returns>Список топ поставщиков.</returns>
        Task<ICollection<SupplierShortDto>> GetTopSuppliersAsync(CancellationToken cancellationToken);
    }
}
