using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCalculation
{
    /// <summary>
    /// problem caluclator calling abstractclass and interface  in new class
    /// </summary>
    
    //interface with methods
    interface IDemo
    {
        public void Add();
        public void Substract();
        const double pi = 3.146;
    }  
    /// <summary>
    /// abstract class with methods
    /// </summary>
    abstract class Calculator
    {
        public  void Multiplication()
        {
            int firstnum = 2;
            int secondnum = 3;
            int mul = firstnum * secondnum;
            Console.WriteLine(mul);
        }

        public void Division()
        {
            int firstnum = 10;
            int secondnum = 5;
            int div = firstnum / secondnum;
            Console.WriteLine(div);
        }
        public abstract void Increment(int firstnum);
        public abstract  void Mod(int firstNum);

    }    
    class Circular :Calculator , IDemo 
    {
        /// <summary>
        /// calculate area of a circle
        /// area = PI* Radius * Radius
       /// </summary>        
        public void Area()
        {
            int radius = 3;
            double area = IDemo.pi * Math.Pow(radius,2);
            Console.WriteLine(area);
        }
        /// <summary>
        /// Add method inherited from Interface
        /// </summary>
        public void Add()
        {
            int firstnum = 10;
            int secondnum = 20;
            int Add = firstnum + secondnum;
            Console.WriteLine(Add);
        }
        /// <summary>
        /// substract method inherited from interface
        /// </summary>
        public void Substract()
        {
            int firstnum = 20;
            int secondnum = 10;
            int sub = firstnum - secondnum;
            Console.WriteLine(sub);
        }      
        /// <summary>
        /// increment method inherited from abstract class
        /// </summary>
        /// <param name="firstnum"></param>
        public override void Increment(int firstnum)
        {
            int value1 = ++firstnum;
            Console.WriteLine("" + value1);
        }
        /// <summary>
        /// mod method inherited from abstract class
        /// </summary>
        /// <param name="firstnum"></param>
        public override void Mod(int firstnum)
        {            
            int value = firstnum % 2;
            Console.WriteLine(value);
        }
    }
        
}
