﻿using System;
using System.Collections.Generic;

namespace ControlYourFridge.Api.Models
{
    /// <summary>
    /// DTO объект, пользовательский рецепт
    /// </summary>
    public class UserRecipe
    {
        /// <summary>
        /// Id рецепта
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название рецепта
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание рецепта
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Id пользователя
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Словарь необходимых продуктов для приготовления и их количество
        /// </summary>
        /// <value>The products and counts.</value>
        public Dictionary<int, decimal> ProductsAndCounts { get; set; }
    }
}
