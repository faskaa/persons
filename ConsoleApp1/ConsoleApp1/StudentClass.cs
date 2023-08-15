﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student : Person
    {
        public Student(string name , string surname , int age) : base (name , surname , age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public void Learn()
        {
           
            Console.WriteLine("Learning....");

        }

    }
}
