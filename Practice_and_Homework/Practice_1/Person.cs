using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice_1
{
    public class Person
    {
        public string FullName {get; set;}
        public decimal Money {get; set;}
        public int ID {get; set;}
        public override string ToString()
        {
            return "Name: " + FullName + " Money: "+ Money +"   ID: " + ID;
        }
        public override int GetHashCode()
        {
            return ID;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Person objAsPerson = obj as Person;
            if (objAsPerson == null) return false;
            else return Equals(objAsPerson);
        }
        public bool Equals(Person other)
        {
            if (other == null) return false;
            return (this.ID.Equals(other.ID));
        }

    }
}
