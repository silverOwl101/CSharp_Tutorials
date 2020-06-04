﻿using CSharp_Tutorials.Class;
using CSharp_Tutorials.Exercises;
//using CSharp_Tutorials.Object_Oriented_Programming;
using CSharp_Tutorials.Object_Oriented_Programming.Holding_a_Class_Responsible;
using CSharp_Tutorials.Object_Oriented_Programming.Let_Me_Say_About_this;
using CSharp_Tutorials.Object_Oriented_Programming.We_Have_Our_Methods;
using InheritanceExample;
using System;
using System.Runtime.InteropServices;
using SimpleSavingsAccount;
using IS_A_And_HAS_A;
using InheritingAConstructor;
using PassingArgsNameSpace;

namespace MyNameSpace
{
    class MyClass
    {
        //This is where your program starts.
        static void Main(string[] args)
        {
            //string s = Console.ReadLine();
            //int.TryParse(s, out int x);
            //string t = Console.ReadLine();
            //int.TryParse(t, out int y);                              
            //Console.WriteLine(CodeExecises.Specifiedord("Hello how are you?", "Hi"));
            #region For Introduction Class Example
            //string[] s = new string[1];
            //s[0] = "D:\\Teaching Purposes\\dmc\\Other Projects 2019-2020\\Graduation Design";
            //MoreCollectionExample.IteratingThroughADirectoryOfFiles(s);

            #endregion

            #region For KeyedArray Example
            //// Create an array with enough room.
            //KeyedArray ma = new KeyedArray(100);

            //// Save the ages of the Simpson kids.
            //ma["Bart"] = 8;
            //ma["Lisa"] = 10;
            //ma["Maggie"] = 2;            

            //// Look up the age of Lisa.
            //Console.WriteLine("Let’s find Lisa’s age");
            //int age = (int)ma["Maggie"];
            //Console.WriteLine("Lisa is {0}",age);

            //// Wait for user to acknowledge the results.
            //Console.WriteLine("Press Enter to terminate...");
            //Console.Read();
            #endregion

            #region For Object Oriented Programming
            ////Methods example = new Methods();
            ////example.InstanceMethod();       // Invoke the instance method
            ////                                // with that instance.
            ////Methods.ClassMethod();          // Invoke the class method with the class.
            ////                                // If the method is static
            ////CalculateInterestTableWithMethods.CalculateInterestTableWithMethodsMain();
            //double x = Convert.ToDouble(Console.ReadLine());
            //double y = Convert.ToDouble(Console.ReadLine());
            //Methods.DisplayRation(x,y);
            //SimpleSavingsAccountClass.SimpleSavingsAccountClassMain();
            PassingArgsWithbase.PassingArgsMain();
            #endregion
        } 
    }
}
