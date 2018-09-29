using System;

namespace ControlYourFridge.Api.Database
{
    /// <summary>
    /// Класс хранящий строки запросов к БД
    /// </summary>
    public class SqlStrings : ISqlStrings
    {
        #region Запросы по таблице пользователей 

        /// <summary>
        /// Запрос на получение всех пользователей
        /// </summary>
        public string GetAllUsers => "SELECT * FROM USERS";

        #endregion

        #region Запросы по таблице холодильников

        /// <summary>
        /// Запрос на получение всех холодильников
        /// </summary>
        public string GetAllFridges => "SELECT * FROM FRIDGES";

        #endregion

        #region Запросы по таблице типов продуктов

        /// <summary>
        /// Запрос на получение всех типов продуктов
        /// </summary>
        public string GetAllProductTypes => "SELECT * FROM PRODUCTTYPES";

        #endregion

        #region Запросы по таблице продуктов

        /// <summary>
        /// Запрос на получение всех продуктов 
        /// </summary>
        public string GetAllProducts => "SELECT * FROM PRODUCTS";

        #endregion

        #region Запросы по таблице продуктов в холодильниках

        /// <summary>
        /// Запрос на получение всех продуктов в холодильниках
        /// </summary>
        public string GetAllFridgeProducts => "SELECT * FROM FRIDGEPRODUCTS";

        #endregion

        #region Запросы по таблице общих рецептов

        /// <summary>
        /// Запрос на получение всех общих рецептов
        /// </summary>
        public string GetAllRecipes => "SELECT * FROM RECIPES";

        #endregion

        #region Запросы по таблице пользовательских рецептов

        /// <summary>
        /// Запрос на получение всех пользовательских рецептов
        /// </summary>
        public string GetAllUserRecipes => "SELECT * FROM USERSRECIPES";

        #endregion
    }
}
