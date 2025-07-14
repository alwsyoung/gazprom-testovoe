using Gazprom.CarLeasing.Application.StorageInterfaces;
using Gazprom.CarLeasing.Domain.Offer;
using Gazprom.CarLeasing.Dto;

namespace Gazprom.CarLeasing.Storage.Repositories
{
    internal class OfferRepository : IOfferRepository
    {
        /// <inheritdoc/>
        public Task<int> AddAsync(OfferEntity offer)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<List<OfferView>> SearchAsync(string? brand, string? model, string? supplierName)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<int> CountAsync(string? brand, string? model, string? supplierName)
        {
            throw new NotImplementedException();
        }
    }
}
