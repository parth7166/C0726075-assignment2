//PARTH PATEL C0726075
//CSD3354 Section 1
//ASSIGNMENT 2
//March 7,2019
//LAB1
using System;

namespace ConsoleApp1
{
  class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class DelegateExcercises
    {
        public delegate void MyDelegate();

         void Method1()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate mydelegate = new MyDelegate(Method1);
            mydelegate();
        }
        
    }
}