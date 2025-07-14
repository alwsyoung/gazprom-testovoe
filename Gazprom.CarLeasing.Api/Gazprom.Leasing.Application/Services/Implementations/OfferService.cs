using Gazprom.CarLeasing.Application.Requests;
using Gazprom.CarLeasing.Dto;

namespace Gazprom.CarLeasing.Application.Services.Implementations;

public class OfferService : IOfferService
{
    public Task<int> CreateOfferAsync(
        CreateOfferRequest request,
        CancellationToken cancellation)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<OfferView>> GetOfferViewAsync(
        OfferViewFilter filter,
        CancellationToken cancellation)
    {
        throw new NotImplementedException();
    }
}
