using System;

namespace DataBaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
           DbCommand dbCommand = new DbCommand(new SqlConnection("SQL Database"));
           dbCommand.Execute();
           dbCommand = new DbCommand(new OracleConnection("Oracle Database"));
           dbCommand.Execute();
        }
    }
}
