using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Employee
    {
        //Properties
        public int Age { get; set; }                 
        //private int age;                            

        //public int Age     //age field
        //{
        //    get { return age; }
        //    set { age = value; }
        //}

        private string name;  //backend variable                  
        public string Name
        {       
            get { return name; }  //name,age etc --- fields
            set { name = value; }
        }



        //access modifier---public,private
        //public int MyAge()          //Get method
        //{
        //    return age;
        //}



        //public void SetAge(int newAge)         //Set method     
        //{                                      
        //    age = newAge;            
        //}

        
    }
}
