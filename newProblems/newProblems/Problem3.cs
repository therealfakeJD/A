using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace newProblems
{

   //Up, Down, Left, Left, Right, Right, Down, Spin, Down, Up, Left, Right, Left, Down, Spin, Up, Down, Jump.
    class Problem3
    {
        List<string> comboMove = new List<string>();

        public void addToComboMove()
        {
            comboMove.Add("Up");
            comboMove.Add("Down");
            comboMove.Add("Left");
            comboMove.Add("Left");
            comboMove.Add("Right");
            comboMove.Add("Right");
            comboMove.Add("Down");
            comboMove.Add("Spin");
            comboMove.Add("Down");
            comboMove.Add("Up");
            comboMove.Add("Left");
            comboMove.Add("Right");
            comboMove.Add("Left");
            comboMove.Add("Down");
            comboMove.Add("Spin");
            comboMove.Add("Up");
            comboMove.Add("Down");
            comboMove.Add("Jump");
            for (int i = 0; i < comboMove.Count; i++)
            {
                Console.WriteLine(comboMove[i]);
            }
        } 
    }
}
