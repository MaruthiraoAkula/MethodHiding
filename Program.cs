using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    public class Baseclass
    {
        public virtual void print()
        {
            Console.WriteLine("I'm a Base Class");
        }
    }
    public class Derivedclass : Baseclass
    {
        public new void print()
        {
            //base.print();
            Console.WriteLine("I'm a Derived Class and class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Baseclass obj = new Derivedclass();
            // Derivedclass obj = new Derivedclass();
            obj.print();
            //  ((Baseclass)obj).print();



        }
    }
}
