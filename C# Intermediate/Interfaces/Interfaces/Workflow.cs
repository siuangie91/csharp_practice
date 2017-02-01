using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Workflow
    {
        private List<IExecutable> _activities;

        public Workflow()
        {
            _activities = new List<IExecutable>();
        }

        public void Execute()
        {
            foreach(var activity in _activities)
            {
                activity.Execute();
            }

            _activities.Clear();
        }

        public void RegisterActivity(IExecutable executable)
        {
            _activities.Add(executable);
        }
    }
}