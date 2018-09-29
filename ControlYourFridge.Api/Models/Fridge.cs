using System;
namespace ControlYourFridge.Api.Models
{
    /// <summary>
    /// DTO объект, холодильник
    /// </summary>
    public class Fridge
    {
        /// <summary>
        /// Id холодильника
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Id пользователя
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Название холодильника
        /// </summary>
        public string Name { get; set; }
    }
}
