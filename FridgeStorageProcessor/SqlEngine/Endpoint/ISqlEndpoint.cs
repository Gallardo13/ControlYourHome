using System;
namespace DBStore
{
    /// <summary>
    /// Интерфейс точки доступа откуда можно считать данные или сохранить данные
    /// </summary>
    public interface IEndpoint 
    {
        /// <summary>
        /// Признак, что Endpoint открыт
        /// </summary>
        bool Opened { get; }

        /// <summary>
        /// Инициализация Endpoint перед началом работы
        /// </summary>
        void Open();
    }

    /// <summary>
    /// Реализуется объектами, которые имеют параметр ConnectionString
    /// </summary>
    public interface IConnectionStringParameter 
    {
        /// <summary>
        /// Строка соединения с БД
        /// </summary>
        /// <value>The connection string.</value>
        string ConnectionString { get; set; }
    }

    /// <summary>
    /// Общий интерфейс для Endpoint-ов БД
    /// </summary>
    public interface ISqlEndpoint
    {
        void ExecuteNonQuery()
    }
}
