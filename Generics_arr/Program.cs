using Generic_class;
using MinAndMax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_arr
{
    class Program
    {
        static void Main(string[] args)
        {
            //adding an element, 
            try
            {
                var stringList = new GenericList<string>(3);
               stringList.Add("a");
                stringList.Add("b");
              stringList.Add("c");
                stringList.Add("d");
                stringList.Add("e");
                stringList.Add("f");
                stringList.Add("g");

                stringList.Print();
                //accessing an element by index, 
                Console.WriteLine(stringList.GetElement(2));

                //removing element by index
                stringList.RemoveElement(0);
                stringList.Print();

                //inserting an element at a given position
                stringList.InsertElement(0, "x");
                stringList.Print();

                //clearing the list
                //stringList.RemoveList();
                //stringList.Print();
                

                //finding element by its value and ToString().
                Console.WriteLine(stringList.FindIndex("b"));


                var MinMax = new MinAndMaxArr<int>();
                int[] intList = { 15, 2, 19, 100, 45 };
               
                MinMax.Max(intList);
                MinMax.Min(intList);

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            

            

            Console.ReadLine();
        }

    }
}
        
    
    

