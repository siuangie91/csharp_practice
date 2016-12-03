using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesInterfacesAndOOP
{
    public interface IWorkflow
    {
        void ExecuteAllActivities();
        void AddActivity(IActivity activity);
    }
}
