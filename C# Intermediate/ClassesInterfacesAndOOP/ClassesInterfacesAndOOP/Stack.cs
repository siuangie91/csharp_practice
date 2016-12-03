using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesInterfacesAndOOP
{
    class Stack
    {
        private ArrayList stackList = new ArrayList();

        public void showStackList()
        {
            var readableStack = "";
            for(var i = 0; i < stackList.Count; i++)
            {
                readableStack += stackList[i].ToString();
                readableStack += ",";
            }

            Console.WriteLine("The stack is: " + readableStack);
        }
        public void Push(object obj)
        {
            if(obj == null)
                throw new InvalidOperationException("Cannot add a null object to the stack.");
            stackList.Add(obj);
        }

        public object Pop()
        {
            if (stackList[stackList.Count - 1] == null)
                throw new InvalidOperationException("The object at the top of the stack cannot be null.");
            else if (stackList.Count == 0)
                throw new InvalidOperationException("Cannot Pop anything off an empty stack.");

            //save the original stackList somewhere so you can return the popped object
            var origStackList = stackList;

            //create a temporary stackList that holds the rest of the objects from the original
            var tempStackList = new ArrayList();

            for(var i = 0; i < stackList.Count - 1; i++)
            {
                tempStackList.Add(stackList[i]);
            }

            //assign the temporary stackList as the class property
            stackList = tempStackList;

            return origStackList[origStackList.Count - 1];
        }

        public void Clear()
        {
            if(stackList.Count == 0)
                throw new InvalidOperationException("The stack is empty and there is nothing to clear.");
            stackList.Clear();
        }
    }
}
