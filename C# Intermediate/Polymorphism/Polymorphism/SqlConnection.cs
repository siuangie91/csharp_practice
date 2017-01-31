using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(string cnxnString)
            :base(cnxnString) {}

        public override void OpenConnection()
        {
            Console.WriteLine("Opening SQL Connection. Using ConnectionString " + ConnectionString);
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing SQL Connection with ConnectionString " + ConnectionString);
        }
    }
}
