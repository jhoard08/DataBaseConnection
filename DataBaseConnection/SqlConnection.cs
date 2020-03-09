using System;

namespace DataBaseConnection
{
    public class SqlConnection : DbConnection
    {

        public SqlConnection(string connection) : base(connection)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("SQL connection is open!");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("SQL connection is closed!");
        }
    }
}