using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesInterfacesAndOOP
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string cnxnString) : base(cnxnString) { }
        public override void OpenConnection()
        {
            Console.WriteLine("Opened Oracle connection.");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Closed Oracle connection.");
        }
    }
}
