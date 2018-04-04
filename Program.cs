using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingAGlass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Glass
            List<int> glass = new List<int>();
            Console.WriteLine("The glass's current capacity is: " + glass.Capacity);
            Console.WriteLine("Adding water . . . ");
            bool overflows = false;
            //Pour water into it until it overflows
            for(int water = 0; !overflows; water++)
            {
                //Try to add water
                try
                {
                    glass.Add(water);
                }
                catch(Exception e)
                {
                    overflows = true;
                    Console.WriteLine("There were exactly {0} elements of water added to the glass until it overflowed.", water);
                }
            }
            Console.WriteLine("The glass's current capacity is: " + glass.Capacity);
            Console.WriteLine("The glass's element count is: " + glass.Count);
            Console.ReadLine();
        }
    }
}
