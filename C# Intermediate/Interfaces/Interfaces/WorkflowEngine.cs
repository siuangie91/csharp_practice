using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    static class WorkflowEngine
    {
        static public void Run(Workflow workflow)
        {
            workflow.Execute();
        }
    }
}
