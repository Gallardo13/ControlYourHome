using System;
namespace ControlYourFridge.Api.Models
{
    /// <summary>
    /// DTO объект, продукт в холодильнике
    /// </summary>
    public class FridgeProduct
    {
        /// <summary>
        /// Id продукта в холодильнике
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Id холодильника
        /// </summary>
        public int FridgeId { get; set; }

        /// <summary>
        /// Id продукта
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Дата покупки
        /// </summary>
        public DateTime PurchaseDate { get; set; }

        /// <summary>
        /// Дата окончания срока годности
        /// </summary>
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Количество продукта
        /// </summary>
        public Decimal Count { get; set; }
    }
}
