using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Program
    {
        static void StaticMembersOfObject()
        {
            Person p3 = new Person("Sally", "Jones", 4);
            Person p4 = new Person("Sally", "Jones", 4);
            Console.WriteLine("p3 and p4 have the same state: {0}", object.Equals(p3, p4));
            Console.WriteLine("p3 and p4 are pointing to the same object: {0}", object.ReferenceEquals(p3, p4));
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with System.Object *****");
            Person p1 = new Person("Homer", "Simpson", 50);
            Person p2 = new Person("Homer", "Simpson", 50);


            // Get stringified version of objects.
            Console.WriteLine("p1.ToString() = {0}", p1.ToString());
            Console.WriteLine("p2.ToString() = {0}", p2.ToString());
            
            // Test overriden Equals().
            Console.WriteLine("p1 = p2?: {0}", p1.Equals(p2));

            // Test hash codes.
            Console.WriteLine("Same hash codes?: {0}", p1.GetHashCode() == p2.GetHashCode());
            Console.WriteLine();


            // Change age of p2 and test again.
            p2.Age = 45;
            Console.WriteLine("p1.ToString() = {0}", p1.ToString());
            Console.WriteLine("p2.ToString() = {0}", p2.ToString());
            Console.WriteLine("p1 = p2?: {0}", p1.Equals(p2));
            Console.WriteLine("Same hash codes?: {0}", p1.GetHashCode() == p2.GetHashCode());
            StaticMembersOfObject();
            Console.ReadLine();
        }
    }
}
