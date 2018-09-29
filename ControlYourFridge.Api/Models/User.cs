using System;
namespace ControlYourFridge.Api.Models
{
    /// <summary>
    /// DTO объект, пользователь
    /// </summary>
    public class User
    {
        /// <summary>
        /// Id пользователя
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Полное имя пользователя
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Логин пользователя
        /// </summary>
        /// <value>The login.</value>
        public string Login { get; set; }

        /// <summary>
        /// Электронная почта пользователя
        /// </summary>
        public string Email { get; set; }
    }
}
