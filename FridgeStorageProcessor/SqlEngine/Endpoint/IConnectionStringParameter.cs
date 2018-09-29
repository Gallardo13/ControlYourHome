namespace DBStore
{
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
}
