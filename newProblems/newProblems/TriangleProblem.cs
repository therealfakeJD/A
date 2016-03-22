using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace newProblems
{
    class ShapeShifter
    {
        List<List<string>> shape = new List<List<string>>();

        private string dot = ".";

        public ShapeShifter(int rowCount)
        {

            for (int outerIndex = 0; outerIndex < rowCount; outerIndex++)
            {

                shape.Add(new List<string>());
                for (int innerIndex = 0; innerIndex < rowCount; innerIndex++)
                {
                    
                    shape[outerIndex].Add(dot);

                }

            }

        }

        public void PrintTriangle()
        {
            for (int outerIndex = 0; outerIndex < shape.Count; outerIndex++)
            {
                Console.WriteLine();
                for (int innerIndex = 0; innerIndex < outerIndex + 1; innerIndex++)
                {
                    Console.Write(shape[outerIndex][innerIndex]);


                }
            }
        }

        public void PrintTriangleUpsideDown()
        {
            for (int outerIndex = 0; outerIndex < shape.Count; outerIndex++)
            {
                Console.WriteLine("");
                for (int innerIndex = 0; innerIndex < shape.Count - outerIndex; innerIndex++)
                {
                    Console.Write(shape[outerIndex][innerIndex]);
                }
                
                
            }
        }

        public void PrintTriangleReverse()
        {
            for (int outerIndex = 0; outerIndex < shape.Count; outerIndex++)
            {

                
                for (int innerIndex = 0; innerIndex < shape.Count - outerIndex;innerIndex++)
                {
                    
                    
                    Console.Write(" ");
                }
                for (int innerIndex = 0; innerIndex < outerIndex + 1; innerIndex++)
                {
                    Console.Write(shape[outerIndex][innerIndex]);
                }
                Console.WriteLine("");
            }
        }
    }
}
