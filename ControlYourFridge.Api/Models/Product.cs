using System;
namespace ControlYourFridge.Api.Models
{
    /// <summary>
    /// DTO объект, продукт
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Id продукта
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Название продукта
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Тип продукта
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Количество дней со дня покупки, которые продукт можно употреблять
        /// </summary>
        public string StoredDaysCount { get; set; }
    }
}
