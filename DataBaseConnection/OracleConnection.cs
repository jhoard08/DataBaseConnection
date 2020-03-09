using System;

namespace DataBaseConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connection) : base(connection)
        {
        }

        public override void OpenConnection()
        {

            Console.WriteLine("Oracle Database connection is Open!");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Oracle database connection is closed!");
        }
    }
}