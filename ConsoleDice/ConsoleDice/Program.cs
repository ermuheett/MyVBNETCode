using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDice
{
    class Program
    {
        static void Main(string[] args)
        {


            // Read input Number

            Console.Write("Enter the Value of N   :   ");
            string input = Console.ReadLine();
            int intN;
            Int32.TryParse(input, out intN);


            // Genreate N Numbers from 1 to N

            string strOutput = "";

            Random rnd = new Random();


            for (int i = 0; i<intN; i++)
            {


                int intDice = rnd.Next(1, 7);


                strOutput = strOutput + intDice.ToString();


            }

            Console.WriteLine("The Output is " + strOutput);

            // Check for 66 Thrown in the String


            // Convert the String into Array 

            
            strOutput = strOutput + " ";


            char[] arrChar = strOutput.ToCharArray() ;


            // Check for Repeadted 66 in the Array 


            
            int intCnt = 0;

            for (int i = 0;i <arrChar.Length - 1; i++)
            {
                // Check for repeated Sixes

                if (arrChar [i] == '6' && arrChar [i+1] == '6')
                {

                        intCnt = intCnt + 1;
                        i = i + 1;
                }

                
            }


            Console.WriteLine(" The Occurance of 66 in in the given string \n||"  + strOutput + " ||\n is || " + intCnt + " || Times");


            




            Console.ReadKey();



        }
    }
}
