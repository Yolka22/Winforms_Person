using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winforms_Person
{
    internal class Person
    {

        string surname;
        string salary;
        string place;


        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Place
        {
            get { return place; }
            set { place = value; }
        }
    }
}
