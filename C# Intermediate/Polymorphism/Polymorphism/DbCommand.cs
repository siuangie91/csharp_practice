using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class DbCommand
    {
        public DbConnection theDbConnection { get; set; }

        public DbCommand(DbConnection dbCnxn)
        {
            if(dbCnxn == null)
            {
                throw new InvalidOperationException("dbCnxn cannot be null.");
            }
            theDbConnection = dbCnxn;
        }

        public void Execute(string instruction)
        {
            theDbConnection.OpenConnection();

            Console.WriteLine("Executing instruction: " + instruction);

            theDbConnection.CloseConnection();
        }
    }
}
