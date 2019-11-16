using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DesignPatterns.GoF.Creational.AbstractFactory
{
    public class SqlDatabaseFactory : IDatabaseFactory
    {
        public IDbCommand CreateCommand()
        {
            return new SqlCommand();
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection();
        }

        public IDbConnectionStringBuilder CreateConnectionString()
        {
            return new SqlConnectionStringBuilder();
        }

        public IDbTransaction CreateTransaction()
        {
            return new SqlTransaction();
        }
    }
}
