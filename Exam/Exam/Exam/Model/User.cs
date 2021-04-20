using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Model
{
    public class User
    {
        public User(string name, string info)
        {
            Name = name;
            Info = info;
        }

        public string Name { get; set; }
        public string Info { get; set; }
    }
}
