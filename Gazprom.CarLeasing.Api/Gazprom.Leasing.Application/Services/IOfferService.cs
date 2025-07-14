using Gazprom.CarLeasing.Application.Requests;
using Gazprom.CarLeasing.Dto;

namespace Gazprom.CarLeasing.Application.Services;

public interface IOfferService
{
    /// <summary>
    /// Создать оффер.
    /// </summary>
    /// <param name="request">Параметры запроса создания оффера.</param>
    /// <param name="cancellation">Токен отмены.</param>
    Task<int> CreateOfferAsync(CreateOfferRequest request, CancellationToken cancellation);

    /// <summary>
    /// Получить список офферов.
    /// </summary>
    /// <param name="filter">Данные фильтров.</param>
    /// <param name="cancellation">Токен отмены.</param>
    /// <returns>Список офферов.</returns>
    Task<ICollection<OfferView>> GetOfferViewAsync(OfferViewFilter filter, CancellationToken cancellation);
}
