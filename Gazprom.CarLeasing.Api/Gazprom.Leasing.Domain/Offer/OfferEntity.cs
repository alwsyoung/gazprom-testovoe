using Gazprom.CarLeasing.Common;
using Gazprom.CarLeasing.Domain.Supplier;

namespace Gazprom.CarLeasing.Domain.Offer
{
    public class OfferEntity : BaseGuidModel
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
        /// Дата регистрации.
        /// </summary>
        public DateTime RegistrationDate { get; set; }

        /// <summary>
        /// Id поставщика.
        /// </summary>
        public int SupplierId { get; set; }

        /// <summary>
        /// Поставщик.
        /// </summary>
        public SupplierEntity Supplier { get; set; } = null!;
    }
}
