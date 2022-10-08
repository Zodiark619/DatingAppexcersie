using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppdotnet5
{

    class Employee
    {
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }
        public string EmployeeOccupation { get; set; }
        public Employee()
        {
            this.EmployeeName = "Jaya";
            this.EmployeeAge = 24;
            this.EmployeeOccupation="Killleee";
        }
        public void Friendship(bool isFriend)
        {
            if (isFriend) Console.WriteLine(meong());
            else Console.WriteLine("Kmzway87aaa"); 
        }
        private string meong()
        {
            return $"Hi,I'm {EmployeeName}, age {EmployeeAge}, occupation {EmployeeOccupation}";
        }
    }


    class Box
    {
      
        public int Length { get; set; }
        public int Width { get; set; }

        public int Height { get; set; }
        public int Volume
        {
            get
            {
           return this.Length*this.Height*this.Width;
                
            }
        }
        public int FrontSize
        {
            get
            {
                return this.Length * this.Height;
            }
        }
        public void result()
        {
            Console.WriteLine("Length is {0} width {1} height {2} and volume {3} frontsize {4}",this.Length,this.Width,this.Height,this.Volume,this.FrontSize);
        }
    }

    internal class Human
    {
        private string firstname;
        private string lastname;
        private string eyecolor;
        private int age;
        public Human()
        {
            Console.WriteLine("-------------");
        }
        public Human(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            
        }
        public Human(string firstname, string lastname, string eyecolor)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.eyecolor = eyecolor;
           
        }
        public Human(string firstname, string lastname, string eyecolor, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.eyecolor = eyecolor;
            this.age = age;
        }

        public void Introduce()
        {
            if(age != 0 && firstname !=null &&lastname!=null&&eyecolor!=null)
               
                Console.WriteLine("Hi, I'm {0} {1} and I'm {2} years old. My eyecolor is {3}.", firstname, lastname, age, eyecolor);
            else if (firstname != null && lastname != null && eyecolor != null)

                Console.WriteLine("Hi, I'm {0} {1} and I'm {2} years old. ", firstname, lastname, age);
            else if ( firstname != null && lastname != null)

                Console.WriteLine("Hi, I'm {0} {1} just just ", firstname, lastname);
            else
                Console.WriteLine("Empty hhuuummaann");


        }

    }
}
