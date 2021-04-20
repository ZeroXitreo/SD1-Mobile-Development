using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Model
{
    public class Exercise
    {
        public Exercise(string name, string info)
        {
            Name = name;
            Info = info;
        }

        public string Name { get; set; }
        public string Info { get; set; }
    }
}
