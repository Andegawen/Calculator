﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONP
{
    static class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator();
            calc.OperationToElements("3+2");
            Console.ReadLine();
        }
    }
}
