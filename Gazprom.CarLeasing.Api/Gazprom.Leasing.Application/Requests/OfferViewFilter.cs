namespace Gazprom.CarLeasing.Application.Requests;

/// <summary>
/// Модель запроса поиска офферов
/// </summary>
public class OfferViewFilter
{
    /// <summary>
    /// Марка.
    /// </summary>
    public string? Brand { get; set; }

    /// <summary>
    /// Модель.
    /// </summary>
    public string? Model { get; set; }

    /// <summary>
    /// Наименование поставщика.
    /// </summary>
    public string? SupplierName { get; set; }
}
