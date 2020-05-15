using System;
using System.Collections.Generic;
using System.Text;

namespace Reboot
{
    //blueprint
    class Human
    {
        private string firstName;
        private string lastName;
        public string FirstName 
        {
            set
            {
                if (value == "")
                {
                    throw new Exception();
                }
                else
                {
                    this.firstName = value;
                }
            } 
        }
        public string LastName 
        {
            set 
            {
                if (value == "")
                {
                    throw new Exception();
                }
                else
                {
                    this.lastName = value;
                }
            } 
        }
        public string FullName 
        {
            get
            {
                return firstName +" "+ lastName;
            }
        }
    }
}