﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesInterfacesAndOOP
{
    public class PasteActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Executing the PASTE activity.");
        }
    }
}
