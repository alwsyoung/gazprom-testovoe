namespace Gazprom.CarLeasing.Common
{
    public class BaseGuidModel
    {
        /// <summary>
        /// Id записи.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Уникальный идентификатор записи.
        /// </summary>
        public Guid Guid { get; set; }
    }
}
