using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Polymorphism
{
    internal abstract class Person // abstract class that serves as a base template, it cannot be instantiated
    // we write the abstract classes to build class hierarchy and not allow object creation
    {
        private string firstName;
        // auto properties will create their own backing fields
        public string FirstName
        {
            get { return this.firstName.ToUpper(); }

            set // validation
            {
                if(value.Length<=50)
                {
                    this.firstName = value;
                }
                else
                {
                    // for trim the value and make it fit to 50 characters
                }
            }
        }

        public string LastName { get; set; } // these are auto properties

        public int Age { get; set; }

        public string Address { get; set; }
        public void Communicate()
        {
            Console.WriteLine("I use language to communicate");
        }
        // normal classes can have virtual methods
        // virtual function allow to change the functionality if needed in derived classes
        //polymorphism
        public virtual void DoWork()
        {
            Console.WriteLine("I do some work");
        }
        // abstract methods only belong to abstract classes 
        // you must implement the abstract method in derived class 
        public abstract void FollowSchedule();
        // normal classes = instance classes : those which can be instantiaded
    }
}
