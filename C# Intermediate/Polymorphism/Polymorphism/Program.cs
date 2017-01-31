using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //useDbCnxn();
            //useDbCommand();
        }

        static void useDbCnxn()
        {
            var sqlCnxn = new SqlConnection("TheSQLConnectionString");
            var oracleCnxn = new OracleConnection("TheOracleConnectionString");

            sqlCnxn.OpenConnection();
            oracleCnxn.OpenConnection();

            sqlCnxn.CloseConnection();
            oracleCnxn.CloseConnection();
        }

        static void useDbCommand()
        {
            var sqlCnxn = new SqlConnection("anotherSqlConnectionstringhere");
            var oracleCnxn = new OracleConnection("thisistheoracleconnectionhere");
            var sqlCommander = new DbCommand(sqlCnxn);
            var oracleCommander = new DbCommand(oracleCnxn);

            sqlCommander.Execute("Execute this on the sql database.");

            oracleCommander.Execute("Execute this on the oracle database.");
        }
    }
}
