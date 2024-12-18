using System.Runtime.CompilerServices;

public class Configuration : IConfiguration{
    private readonly string SqlSection = "SqlConfig";
    private readonly string SqlServerSection = "Server";

    private readonly string SqlDatabaseSection = "Database";
    private readonly string SqlUidSection = "Uid";
    private readonly string SqlPasswordSection = "Password";
    private readonly string SqlCharSetSection = "CharSet";
    private readonly string SqlPortSection = "Port";
    private readonly string SqlSslModeSection = "SslMode";

}