﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MappingGenerator.Test.Splatting.TestCaseData
{
    class TestMapper
    {
        public void DoSomething()
        {
            var user = new UserDTO();
            new SampleClass(firstName: user.FirstName, lastName: user.LastName, age: user.Age);
        }
    }

    public class SampleClass
    {
        public SampleClass(string firstName, string lastName, int age)
        {

        }
    }


    public class UserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}