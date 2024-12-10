using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    public class student
    {
        public string name;
        public string ID;
        public string apartment;
        public double score;

        public student(string ID, string name, string apartment, double score)
        {
            this.name = name;
            this.ID = ID;
            this.apartment = apartment;
            this.score = score;
        }
    }
}
