using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace newProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Problem1 inputString = new Problem1();
            Console.WriteLine(inputString.PrintListLength());
            Console.ReadLine();

            Problem2 pi = new Problem2();
            pi.PrintPi();
            Console.ReadLine();

            Problem3 adventure = new Problem3();
            adventure.addToComboMove();
            Console.ReadLine();

            Problem4 someList = new Problem4();
            someList.PrintFirstList();
            someList.PrintSecondList();
            someList.PrintThirdList();
            Console.ReadLine();

            Problem5 dancer = new Problem5();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(dancer.dance());
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine(dancer.danceAgain());
                Console.ReadLine();
                Console.Clear();
            }

            TriangleProblem shape = new TriangleProblem(5);
            shape.PrintTriangle();
            Console.WriteLine(" ");
            shape.PrintTriangleUpsideDown();
            Console.WriteLine(" ");
            shape.PrintTriangleReverse();
            Console.ReadLine();
            */
            InputCheckerProblem inputChecker = new InputCheckerProblem();
           
            inputChecker.CheckBadWordList();
            Console.ReadLine();


        }
    }
}
