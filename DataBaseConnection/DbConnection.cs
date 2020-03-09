using System;

namespace DataBaseConnection
{
    /// <summary>
    /// Abstract class that only holds the attributes of Connection and Timeout
    /// with the abstraction of opening and closing the connections. 
    /// </summary>
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        protected DbConnection(string connection)
        {
            this.ConnectionString = connection;
            this.Timeout = TimeSpan.FromMinutes(1);
            if (string.IsNullOrEmpty(connection))
            {
                throw new NullReferenceException("Connection access point cannot be null.");
            }
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}