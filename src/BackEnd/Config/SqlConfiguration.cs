using System.Runtime.CompilerServices;

public class SqlConfiguration {
    public readonly string SqlSection = "SqlConfig";
    public readonly string SqlServerSection = "Server";

    public readonly string SqlDatabaseSection = "Database";
    public readonly string SqlUidSection = "Uid";
    public readonly string SqlPasswordSection = "Password";
    public readonly string SqlCharSetSection = "CharSet";
    public readonly string SqlPortSection = "Port";
    public readonly string SqlSslModeSection = "SslMode";

    public string _connectStr = "Server=localhost;database=IMS;Uid=root;Pwd=;Charset=utf8;Port=3306;SslMode=none";

}