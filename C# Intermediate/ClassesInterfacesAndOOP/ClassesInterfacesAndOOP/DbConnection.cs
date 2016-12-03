using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesInterfacesAndOOP
{
    abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public abstract void OpenConnection();

        public abstract void CloseConnection();

        public DbConnection(string cnxnString)
        {
            if (String.IsNullOrEmpty(cnxnString))
                throw new InvalidOperationException("Connection string cannot be null or empty.");

            ConnectionString = cnxnString;
        }
    }
}
