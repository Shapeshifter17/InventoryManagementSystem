using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

public class SqlConnector: ISqlConnector{
    string _connectionString { get; set; } = string.Empty;
    private readonly IConfiguration _config;
    private ILogger _logger;
    public SqlConnector(string someConnectionStr, IConfiguration config, ILogger<SqlConnector> logger){
        _logger = logger;
        _config = config;
        
        _logger.LogInformation("Constructor initialised for SqlConnector with values" + someConnectionStr);
        Connect(_connectionString);
    }

    private void Connect(string connectionString)
    {
        try
        {
            
            Console.WriteLine("Attempting to Connect...");
       //Attempt to connect to SQL 
        }
        catch (System.Exception)
        {
            
            throw;
        }
    }
}