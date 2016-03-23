using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace newProblems
{
    class InputCheckerProblem
    {
        private List<string> badWords = new List<string>();
        private string input;
        
        

        public InputCheckerProblem()
        {

        }

       

        public void CheckBadWordList()
        {
            
            badWords.Add("");

            while (input != "exit")
            {
                

                for (int listIndex = 0; listIndex < badWords.Count; listIndex++)
                {
                    Console.WriteLine("Please enter a Word...");
                    input = Console.ReadLine();
                    
                 
                        if (badWords[listIndex].Contains(input))
                        {
                            Console.WriteLine("Bark!! Bark!! -- Hey Buddy, you have already used that word");
                        }
                        else
                        {
                            Console.WriteLine("Thank you for your word...");
                            badWords[listIndex] += input;
                        }

                    }
                    
                }
                Console.ReadLine();
            }
          
        }
     }
 

    


