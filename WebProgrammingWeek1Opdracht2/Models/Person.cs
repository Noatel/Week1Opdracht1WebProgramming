using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgrammingWeek1Opdracht2.Models
{
    public class Person
    {
        

        public string name { get; set; }
        public string email { get; set; }

        public Person(string name, string email)
        {
            this.name = name;
            this.email = email;
        }


    }
}
