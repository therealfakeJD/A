using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace newProblems
{
    class Problem5
    {
        public string man; 

        public string dance()
        {
            man =
                @"    *  * 
                   *      * 
                     *  *        * 
                       *      * 
                   *  *  * 
                 *    *     
               *      *       
                       * 
                   *      * 
                 *          * 
               *              * 
             *                  * 
           *                      * ";
            return man;
        }

        public string danceAgain()
        {
            man =
                @"   *  * 
                   *      * 
                     *  *        
                       *      
                   *  *  * 
                 *    *    *
               *      *      *
                       * 
                   *      * 
                 *          * 
               *              * 
             *                  * 
           *                      * ";
            return man;
        }
    }
}
