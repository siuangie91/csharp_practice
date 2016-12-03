using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesInterfacesAndOOP
{
    class Workflow : IWorkflow
    {
        private readonly IList<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        public void ExecuteAllActivities()
        {
            foreach(var activity in _activities)
            {
                activity.Execute();
            }
        }

        public void AddActivity(IActivity activity)
        {
            _activities.Add(activity);
        }
    }
}
