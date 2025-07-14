using Gazprom.CarLeasing.Common;

namespace Gazprom.CarLeasing.Dto
{
    public class OfferView : BaseGuidModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string Brand { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        public string Model { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        public string SupplierName { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        public DateTime RegistrationDate { get; set; }
    }
}
