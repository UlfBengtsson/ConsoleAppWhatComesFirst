using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppWhatComesFirst.Models
{
    public class ExampleSubClass : Example
    {
		public static int step_3 = Step(3);
		public int step_10 = Step(3);


		public ExampleSubClass()
		{
			Step(6);
		}
	}
}
