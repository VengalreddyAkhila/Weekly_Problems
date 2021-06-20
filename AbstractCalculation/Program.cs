using InterfaceCalculation;
using System;

namespace AbstractCalculation
{
    class Program
    {
        /// <summary>
        /// problem calculator
        /// interface
        /// methods
        /// 1.add
        /// 2.substract
        /// const is const double pi = 3.146
        /// 
        /// Abstract class
        /// 1.multiplication//normal method
        /// 2.division    //normal method
        /// 3.abstract mod  //abstract method
        /// 4.abstract increment //abstract method
        /// 
        /// New class
        /// that inherit both abstract and interface and implement methods,
        /// 1.circular area (int radius)//normal method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {         

            Console.WriteLine("Welcome to problem caluclator");
             //output for interface
             IDemo  demo = new Circular();
             demo.Add();
             demo.Substract();

             //output for abstract class
             Calculator cal = new Circular();
             cal.Division();
             cal.Multiplication();
             cal.Mod(100);
             cal.Increment(5);
             //output for circle class
             Circular circle = new Circular();
             circle.Area();
        }
    }
}
