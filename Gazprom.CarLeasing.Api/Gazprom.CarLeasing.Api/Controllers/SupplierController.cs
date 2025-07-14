using Gazprom.CarLeasing.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Gazprom.CarLeasing.Api.Controllers;

/// <summary>
/// Контроллер для работы с поставщиком.
/// </summary>
/// <param name="supplierService">Сервис для работы с поставщиком.</param>
[ApiController]
[Route("api/[controller]")]
public class SupplierController(ISupplierService supplierService) : ControllerBase
{
    [HttpGet("top")]
    public async Task<IActionResult> GetTopSuppliersAsync(
        CancellationToken cancellationToken = default) =>
        Ok(await supplierService.GetTopSuppliersAsync(cancellationToken));
}
