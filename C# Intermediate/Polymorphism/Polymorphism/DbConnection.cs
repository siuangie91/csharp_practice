using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string cnxnString)
        {
            if(String.IsNullOrEmpty(cnxnString))
            {
                throw new InvalidOperationException("ConnectionString cannot be null.");
            }

            ConnectionString = cnxnString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
