using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppWhatComesFirst.Models
{
    public class Example
    {

		public static int step_1 = Step(2);
		public int step_6 = Step(4);

		public Example()
		{
			Step(5);
		}

		// Just for demonstration purposes:
		public static int Step(int step)
		{
            Console.WriteLine("Step " + step);
			return step;
		}
    }
}
