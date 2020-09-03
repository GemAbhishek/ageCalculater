using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculater
{
    public class Program       //DO NOT CHANGE the class name
    {
        public static void Main(string[] args)    //DO NOT CHANGE the 'Main' method signature
        {
            Console.WriteLine("Enter the date of birth (dd-mm-yyyy): ");
            //Implement code here
            string dob = Console.ReadLine();
            Console.WriteLine(calculateAge(dob));
        }

        public static int calculateAge(string dateOfBirth)
        {
            //Implement code here
            int age, month;

            DateTime dob = DateTime.ParseExact(dateOfBirth, "dd-MM-yyyy", null);

            age = DateTime.Now.Year - dob.Year - 1;

            if (DateTime.Now.Month > dob.Month)
                month = DateTime.Now.Month - dob.Month;
            else
                month = DateTime.Now.Month - dob.Month + 11;

            if (month > 6)
                age += 1;

            return age;
        }
    }
}