using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

public class SqlConnector: ISqlConnector{
    private readonly IConfiguration _config;
    private ILogger _logger;
    public SqlConnector(IConfiguration config, ILogger<SqlConnector> logger){
        _logger = logger;
        _config = config;
        
        _logger.LogInformation("Constructor initialised for SqlConnector with values");
        
    }

    private void Connect(string connectionString)
    {
        try
        {
            _logger.LogInformation("Testing the Connection");
       
        }
        catch (System.Exception)
        {
            
            throw;
        }
    }
}