﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditCard;
using Money;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 cl = new Class1();
           Console.WriteLine( cl.Add(55, 8));
            MoneyClass mc = new MoneyClass("Ivanochko",150);
        }
    }
}
