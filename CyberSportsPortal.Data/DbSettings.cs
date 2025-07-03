using Npgsql;

namespace CyberSportsPortal.Data;

public class DbSettings
{
    /// <summary>
    /// Хост.
    /// </summary>
    public required string Host { get; init; }

    /// <summary>
    /// Порт.
    /// </summary>
    public required int Port { get; init; }

    /// <summary>
    /// Название БД.
    /// </summary>
    public required string DbName { get; init; }

    /// <summary>
    /// Имя пользователя.
    /// </summary>
    public required string User { get; init; }

    /// <summary>
    /// Пароль.
    /// </summary>
    public required string Password { get; init; }

    /// <summary>
    /// Достать строку подключения.
    /// </summary>
    /// <returns></returns>
    public string GetConnectionString()
    {
        var connectionStringBuilder = new NpgsqlConnectionStringBuilder
        {
            Host = Host,
            Port = Port,
            Database = DbName,
            Username = User,
            Password = Password,
            NoResetOnClose = true,
        };

        return connectionStringBuilder.ConnectionString;
    }
}