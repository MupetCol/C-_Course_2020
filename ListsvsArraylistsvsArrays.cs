 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //ARRAYS
            //immutable - limited to one type
            int[] scores = new int[] { 99, 96, 98, 97 };
            #endregion

            #region
            ////LISTS
            //List<int> list = new List<int> { 1, 2, 3, 5, 4};
            //list.Add(0);
            //list.Add(32);
            //list.Sort();

            ////STARTS FROM 1 NOT LIKE ARRAYS pos from where it starts to remove and number of deleted values
            //list.RemoveRange(2, 2);

            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            ////Returns a boolean, True if cointained False if not
            //Console.WriteLine(list.Contains(1));

            //int index = list.FindIndex(x => x == 4);
            //list.RemoveAt(index);
            //Console.WriteLine(index);
            //Console.WriteLine(list[index]);

            //list.ForEach(i => Console.WriteLine(i));
            #endregion

            #region
            //ARRAY LISTS   
            System.Collections.ArrayList arrayList = new System.Collections.ArrayList();
            arrayList.Add(1);
            arrayList.Add("two");
            arrayList.Add("3");
            arrayList.Add(new Number { n = 4 });

            foreach (Object o in arrayList)
            {
                Console.WriteLine(o);
            }
            Console.ReadKey();
        }
    }

    class Number
    {
        public int n { get; set; }

        public override string ToString()
        {
            return n.ToString();
        }
    }

    #endregion
}
