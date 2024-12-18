using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

public class SqlConnector: ISqlConnector{
    string _connectionString { get; set; } = string.Empty;
    private readonly IConfiguration _config;
    private ILogger _logger;
    public SqlConnector( IConfiguration config, ILogger<SqlConnector> logger){
        _logger = logger;
        _config = config;
        
        _logger.LogInformation("Constructor initialised for SqlConnector with values");
        //Connect(_connectionString);
    }

    private void Connect(string connectionString)
    {
        try
        {
            
            _logger.LogInformation("Attempting to Connect...");
       
        }
        catch (System.Exception)
        {
            
            throw;
        }
    }
}