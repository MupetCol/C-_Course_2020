using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring an ArrayList with undefinied amount of objects
            ArrayList myArrayList = new ArrayList();
            //Declaring an ArrayList with definied amount of objects
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(25.25);
            myArrayList.Add(1);
            myArrayList.Add('c');
            myArrayList.Add('c');

            //delete element with specific value from arraylist
            myArrayList.Remove('c');

            //delete element at specific position
            myArrayList.RemoveAt(0);

            

            double sum = 0;
            foreach(object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if(obj is double)
                {
                    //You have tocast it anyways because even though it contains a doble it is still an object
                    sum += (double)obj;
                }
                else if(obj is string)
                {
                    Console.WriteLine(obj);
                }
                else if (obj is char)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine(sum);
            Console.WriteLine(myArrayList.Count);
            Console.ReadKey();
        }
    }
}
