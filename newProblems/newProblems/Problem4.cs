using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace newProblems
{


    class Problem4
    {
        List<int> firstList = new List<int> {1, 2, 3};
        private List<int> secondList = new List<int> {5, 11, 9};
        private List<int> thirdList = new List<int> {7, 0, 0, 4, 5, 6};


        public void PrintFirstList()
        {
            Console.WriteLine("Items in first List: " + firstList.Count + "\n");
            var newFirstList = firstList.Skip(1).Take(firstList.Count - 1).ToList();
            newFirstList.Add(firstList[0]);
            foreach(int i in newFirstList)
                Console.WriteLine(i + 5);
                Console.WriteLine("");

        }

        public void PrintSecondList()
        {
            Console.WriteLine("Items in second list: " + secondList.Count + "\n");
            var newSecondList = secondList.Skip(1).Take(secondList.Count() - 1).ToList();
            newSecondList.Add(secondList[0]);

            foreach (int i in newSecondList)
                Console.WriteLine(i + 5);
                Console.WriteLine("");
        }

        public void PrintThirdList()
        {
            Console.WriteLine("Items in third list: " + thirdList.Count + "\n");
            var newThirdList = thirdList.Skip(4).Take(thirdList.Count() - 1).ToList();
            newThirdList.Add(thirdList[0]);
            newThirdList.Add(thirdList[1]);
            newThirdList.Add(thirdList[2]);
            newThirdList.Add(thirdList[3]);

            foreach (int i in newThirdList)
                Console.WriteLine(i + 5);
                Console.WriteLine("");
        }


    }
}

