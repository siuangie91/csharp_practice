using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Stack
    {
        private List<object> objStack = new List<object>();

        public void Push(object obj)
        {
            if(obj != null)
            {
                objStack.Add(obj);
            }
            else
            {
                throw new InvalidCastException("Could not cast the param as an object.");
            }
        }

        public object Pop()
        {
            var lastItem = objStack[objStack.Count - 1];

            var tempStack = new List<object>();

            for (int i = 0; i < objStack.Count - 1; i++)
            {
                tempStack.Add(objStack[i]);
            }

            objStack.Clear();

            objStack = tempStack;

            return lastItem;
        }


        public void Clear()
        {
            objStack.Clear();
        }
    }
}
