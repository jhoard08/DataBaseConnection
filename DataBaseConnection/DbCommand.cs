using System;

namespace DataBaseConnection
{
    public class DbCommand
    {
        private readonly DbConnection _connection;
        public DbCommand(DbConnection connection)
        {
            if (connection.Equals(null))
            {
                throw new NullReferenceException("This cannot be null.");
            }
            this._connection = connection;
        }

        public void Execute()
        {
            _connection.OpenConnection();
            Console.WriteLine("Writing to " + _connection);
            _connection.CloseConnection();
        }
    }
}