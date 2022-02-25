using ConsoleAppWhatComesFirst.Models;
using System;

namespace ConsoleAppWhatComesFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            Example.Step(1);
            ExampleSubClass.Step(2);
            new ExampleSubClass();
            Example.Step(7);
            
            //See how Static fields and methods a triggerd first
            //and then none-static are are triggerd after.
        }
    }
}
