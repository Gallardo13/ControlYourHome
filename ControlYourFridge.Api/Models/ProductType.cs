using System;
namespace ControlYourFridge.Api.Models
{
    /// <summary>
    /// DTO объект, тип продуктов
    /// </summary>
    public class ProductType
    {
        /// <summary>
        /// Id типа продуктов
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название типа продуктов
        /// </summary>
        public string Name { get; set; }
    }
}
