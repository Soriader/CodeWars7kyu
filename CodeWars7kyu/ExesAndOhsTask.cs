using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class ExesAndOhsTask
    {
        public static bool XO(string input)
        {
            var exes = input.ToLower().Count(c => c == 'x');
            var ohs = input.ToLower().Count(c => c == 'o');

            if( exes == ohs ) 
            { 
                return true;
            }
            
            return false;
        }
    }
}
