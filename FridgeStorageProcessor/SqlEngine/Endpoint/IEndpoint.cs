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
}
