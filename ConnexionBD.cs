using MySql.Data.MySqlClient;

public static class ConnexionBD
{
    private static string connStr = "server=localhost;user=root;password=amen123;database=cabinet_db";

    public static MySqlConnection GetConnection()
    {
        return new MySqlConnection(connStr);
    }
}