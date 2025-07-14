using Gazprom.CarLeasing.Common;
using Gazprom.CarLeasing.Domain.Offer;

namespace Gazprom.CarLeasing.Domain.Supplier
{
    public class SupplierEntity : BaseGuidModel
    {
        /// <summary>
        /// Наименование.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Дата создания.
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Офферы.
        /// </summary>
        public ICollection<OfferEntity> Offers { get; set; } = [];
    }
}
