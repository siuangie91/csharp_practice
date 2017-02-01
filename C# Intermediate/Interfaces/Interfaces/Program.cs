using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var oracleActivity1 = new OracleActivity("OracleActivity_1");
            var oracleActivity2 = new OracleActivity("OracleActivity_2");
            var sqlActivity1 = new SqlActivity("SQLActivity_1");
            var sqlActivity2 = new SqlActivity("SQLActivity_2");

            var workflow = new Workflow();
            workflow.RegisterActivity(oracleActivity1);
            workflow.RegisterActivity(oracleActivity2);
            workflow.RegisterActivity(sqlActivity1);
            workflow.RegisterActivity(sqlActivity2);

            WorkflowEngine.Run(workflow);

            var mongoActivity = new MongoActivity("This Mongo Activity");
            workflow.RegisterActivity(mongoActivity);

            WorkflowEngine.Run(workflow);
        }
    }
}
