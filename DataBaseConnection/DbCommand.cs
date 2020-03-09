using System;

namespace DataBaseConnection
{
    public class DbCommand
    {
        /// <summary>
    
        /// Allows for polymorphic behaviors for connection to either SQL or Oracle Servers  
    
        /// </summary>
        private readonly DbConnection _connection;
        public DbCommand(DbConnection connection)
        {
            // if the connection is null throws a null exception 
            if (connection.Equals(null))
            {
                throw new NullReferenceException("This cannot be null.");
            }
            this._connection = connection;
        }

        public void Execute()
        {
            //this is where the polymorphism comes into play since Execute doesn't care what kind of connection just that it has one.
            _connection.OpenConnection();
            Console.WriteLine("Writing to " + _connection);
            _connection.CloseConnection();
        }
    }
}