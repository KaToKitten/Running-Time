using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Running_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            /* INPUT ARRAY SIZE */
            int numArray;
            Console.Write("Input number of Arrays: ");
            string numAr = Console.ReadLine();
            
            // VALIDATE THE SIZE
            bool check = int.TryParse(numAr, out numArray);
            bool valid = check && 1 <= numArray && numArray <= 1001;
            while (!valid) 
            {
                Console.WriteLine("Invalid Input, Try again...");
                Console.Write("Input number of Arrays: ");
                numAr = Console.ReadLine();
                check = check = int.TryParse(numAr, out numArray);
                valid = check && 1 <= numArray && numArray <= 1001;
            }

            numArray = Convert.ToInt32(numAr);

            /* INPUT VALUE OF ARRAY*/
            Console.Write("Input value (Seperated by Space): ");
            string[] input = Console.ReadLine().Split(' ');
            int[] arr = new int[input.Length];

            // CONVERTING STRING TO INTERGER
            for (int y = 0; y < input.Length; y++) 
            {
                // VALIDATE THE VALUE USING CONTRAINTS
                bool checkValue = int.TryParse(input[y], out arr[y]);
                bool validValue = checkValue && -10000 <= arr[y] && arr[y] <= 10000;
                while(!validValue) 
                {
                    Console.WriteLine("Invalid Input Value, Try again...");
                    Console.Write("Input value (Seperated by Space): ");
                    input = Console.ReadLine().Split(' ');
                    checkValue = int.TryParse(input[y], out arr[y]);
                    validValue = checkValue && -10000 <= arr[y] && arr[y] <= 10000;
                }
                arr[y] = Int32.Parse(input[y]);
            }

            /* CONDITION IN SORTING */
            int n = numArray, i, j, val, flag, swaps=0;
            for (i = 1; i < n; i++) 
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1; ) 
                {
                    if (val < arr[j]) 
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                        // START COUNTING THE NUMBER OF SWAPS/SHIFT
                        swaps++;
                    }
                    else flag = 1;
                }
            }

            // OUTPUT
            Console.WriteLine("Swaps: " + swaps);
            Console.WriteLine("Press Any Key to Quit.");
            Console.ReadKey();
        }


    }
}
