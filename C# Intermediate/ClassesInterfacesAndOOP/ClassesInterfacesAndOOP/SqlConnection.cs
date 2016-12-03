using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesInterfacesAndOOP
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(string cnxnString) : base(cnxnString) { }
        public override void OpenConnection()
        {
            Console.WriteLine("Opened SQL connection.");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Closed SQL connection.");
        }
    }
}
