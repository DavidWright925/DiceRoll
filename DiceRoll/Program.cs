﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoll
{
    class Program
    {
        //DiceRoll1 CHanges

		// STEP 1
		// STEP 2
		// STEP 3
		//
        //http://cs.dvc.edu/intro2programming/index.jsp?java#step1
        static void Main(string[] args)
        {
            Random random = new Random();
            int a; // the name of the first die
            int b; // the name of the second die
            int total; // the result
            a = random.Next(1, 7);
            b = random.Next(1, 7);
            total = a + b;

            Console.Write("Dice result: ");
            Console.Write(total);
            Console.Write(" (");
            Console.Write(a);
            Console.Write(" and ");
            Console.Write(b);
            Console.WriteLine(")");
        }
    }

    //DiceRoll2
}
