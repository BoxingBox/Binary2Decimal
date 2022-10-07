using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bin2Dec
{
    internal class Calculations
    {
        


        public static int Calculation(string a)
        {
            int intResultTwo=1;
            int intResult=1;
            string? inputCheck;


            for (int i = 0; i < a.Length; i++) //1001
            {
              

                string stringResult = a.Substring(i, 1);
                intResult = Int32.Parse(stringResult);
                if (i == 0) intResult = intResult + (2 * 0);
                else intResult = intResult + (2 * intResultTwo);
                intResultTwo = intResult; //4


            }
            return intResult;
        }




    }
}
