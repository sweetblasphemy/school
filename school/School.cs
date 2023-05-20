using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    internal class School
    {

        private string gender;
        private int age;


        public string G
        {
            get { return gender; }
            set { gender = value; }
        }
        public School(string gender, int age)
        {
            this.gender = gender;
            this.age = age;
        }

        public void s(string gender, int age)
        {

            if (gender == "m" && age >= 16)
            {

                Console.WriteLine("Mr.");

            }
            else if (gender == "m" && age <= 15)
            {

                Console.WriteLine("Master");

            }

            if (gender == "f" && age >= 16)
            {

                Console.WriteLine("Ms.");

            }
            else if (gender == "f" && age <= 15)
            {

                Console.WriteLine("Miss");

            }

        }

    }
}
