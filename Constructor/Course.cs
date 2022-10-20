using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Course
    {
        private int id;
        private string name;
        private float fees;

        public Course()
        {
            id = 101;
            name = "Java";
            fees = 20000;
        }

        public Course(int id, string name, float fees)
        {
            this.id = id;
            this.name = name;
            this.fees = fees;
        }

        public string GetValues()
        {
            return $"Course : {id}\n{name}\n{fees}";
        }
    }
}
