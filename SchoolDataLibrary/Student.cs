﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDataLibrary
{
    public class Student
    {
        public string Name { get; set; }
        public int GradeLevel { get; set; }

        public Student(string name, int gradeLevel)
        {
            Name = name;
            GradeLevel = gradeLevel;
        }

        public string GetStudentInfo()
        {
            return $"{Name} is in grade {GradeLevel}";
        }
    }
}
