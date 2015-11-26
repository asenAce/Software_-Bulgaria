using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Person
{
   public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name,int age,string email)
        {
            this.Age = age;
            this.Name = name;
            this.Emai = email;
        }

        public Person(string name,int age) : this(name,age,null)
        {

        }

        public string Name 
        {
            get 
            { 
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) 
                {
                    throw new ArgumentException("Invalid name!");
                    this.name = value;
                }
            }
        }

        public int Age 
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException("The age is incorrect");
                }
                this.age = value;
            }
        }

        public string Emai 
        { 
            get
            {
                return this.email;
            }
            set
            {
                if (null != value && (value.Length == 0 || !value.Contains("@")))
                {
                    throw new ArgumentException("Invalid email!");
                }
                this.email = value;
            }
        }

        public override string ToString()
        {
            return string.Format("name: {0}, age: {1}", this.Name,this.Age) + (this.Emai == null?"":",email : " + this.Emai);
        }


    }
}
