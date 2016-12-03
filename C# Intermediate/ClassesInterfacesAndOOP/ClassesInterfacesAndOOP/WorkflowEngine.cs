using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesInterfacesAndOOP
{
    class WorkflowEngine
    {
        //the Run method should only work on 
        //workflow objects that have the 
        //correct workflow interface; i.e.,
        //must have an ExecuteAllActivites method
        public void Run(IWorkflow workflow)
        {
            workflow.ExecuteAllActivities();
        }
    }
}
