namespace Gazprom.CarLeasing.Application.Requests;

/// <summary>
/// Модель запроса создания оффера
/// </summary>
public class CreateOfferRequest
{
    /// <summary>
    /// Марка.
    /// </summary>
    public string Brand { get; set; } = string.Empty;

    /// <summary>
    /// Модель.
    /// </summary>
    public string Model { get; set; } = string.Empty;

    /// <summary>
    /// Id поставщика.
    /// </summary>
    public int SupplierId { get; set; }
}
