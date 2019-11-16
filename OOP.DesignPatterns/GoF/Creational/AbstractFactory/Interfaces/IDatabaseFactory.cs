using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DesignPatterns.GoF.Creational.AbstractFactory
{
    public interface IDatabaseFactory
    {
        IDbConnection CreateConnection();
        IDbCommand CreateCommand();
        IDbConnectionStringBuilder CreateConnectionString();
        IDbTransaction CreateTransaction();
    }
}
