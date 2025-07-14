using Gazprom.CarLeasing.Domain.Offer;
using Gazprom.CarLeasing.Dto;

namespace Gazprom.CarLeasing.Application.StorageInterfaces
{
    /// <summary>
    /// Интерфейс репозитория для работы с оффером
    /// </summary>
    public interface IOfferRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="offer"></param>
        /// <returns></returns>
        Task<int> AddAsync(OfferEntity offer);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="model"></param>
        /// <param name="supplierName"></param>
        /// <returns></returns>
        Task<List<OfferView>> SearchAsync(string? brand, string? model, string? supplierName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="model"></param>
        /// <param name="supplierName"></param>
        /// <returns></returns>
        Task<int> CountAsync(string? brand, string? model, string? supplierName);
    }
}
