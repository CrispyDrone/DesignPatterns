using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DesignPatterns.GoF.Creational.AbstractFactory.OleDb
{
    public class OleDbDatabaseFactory : IDatabaseFactory
    {
        public IDbCommand CreateCommand()
        {
            return new OleDbCommand();
        }

        public IDbConnection CreateConnection()
        {
            return new OleDbConnection();
        }

        public IDbConnectionStringBuilder CreateConnectionString()
        {
            return new OleDbConnectionStringBuilder();
        }

        public IDbTransaction CreateTransaction()
        {
            return new OleDbTransaction();
        }
    }
}
