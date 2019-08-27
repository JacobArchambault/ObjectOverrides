using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with System.Object *****");
            Person p1 = new Person();

            // Use inherited members of SYstem.Object.
            Console.WriteLine("ToString: {0}", p1.ToString());
            Console.WriteLine("Hash code: {0}", p1.GetHashCode());
            Console.WriteLine("Type: {0}", p1.GetType());

            // Make some other references to p1.
            Person p2 = p1;
            object o = p2;
            // Are the references pointing to the same object in memory?
            if (o.Equals(p1) && p2.Equals(o))
            {
                Console.WriteLine("Same Instance!");
            }
            Console.ReadLine();
        }
    }
}
