using Gazprom.CarLeasing.Application.Requests;
using Gazprom.CarLeasing.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Gazprom.CarLeasing.Api.Controllers;

/// <summary>
/// Контроллер для работы с оффером.
/// </summary>
/// <param name="offerService">Сервис для работы с оффером.</param>
[ApiController]
[Route("api/[controller]")]
public class OfferController(IOfferService offerService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreatOfferAsync(
        CreateOfferRequest request,
        CancellationToken cancellationToken = default) =>
         StatusCode(
             StatusCodes.Status201Created,
             await offerService.CreateOfferAsync(request, cancellationToken));

    [HttpGet("view")]
    public async Task<IActionResult> GetOfferViewAsync(
        OfferViewFilter filter,
        CancellationToken cancellationToken = default) =>
        Ok(await offerService.GetOfferViewAsync(filter, cancellationToken));

}
