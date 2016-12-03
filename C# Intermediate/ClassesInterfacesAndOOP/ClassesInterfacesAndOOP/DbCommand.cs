using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesInterfacesAndOOP
{
    class DbCommand
    {
        public string DbInstruction { get; set; }
        public DbConnection TheConnection { get; set; }
        public string Instruction { get; set; }

        public void Execute()
        {
            TheConnection.OpenConnection();
            Console.WriteLine(Instruction);
            TheConnection.CloseConnection();
        }

        public DbCommand(DbConnection dbCnxn, string instructionString)
        {
            if (dbCnxn == null)
                throw new InvalidOperationException("DbConnection cannot be null.");

            if (String.IsNullOrEmpty(instructionString))
                throw new InvalidOperationException("DbInstruction cannot be null or empty.");

            TheConnection = dbCnxn;
            Instruction = instructionString;

        }
    }
}
