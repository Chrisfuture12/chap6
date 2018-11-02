using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap6{

    class npv{

        public static double getInput(string item)
        {
            string input;
            Console.WriteLine("Enter "+item);
            input = Console.ReadLine();
            double userInput = double.Parse(input);
            return userInput;
        }

        public static void Main()
        {
            double irate = 0;
            double year = 0; 
            double cf = 0;
            double npv = 0;
    
            irate = getInput("The interest rate");
            year = getInput("The year");
            cf = getInput("the cashflow");

            while(irate < 0){
                Console.WriteLine("Please enter a number greater than or equal to zero");
                irate=getInput("The interest rate");
            }

            for(int i = 1; i<= year; i++){
                npv+= (cf) / Math.Pow(1+irate, i);
                Console.WriteLine("NPV is: "+ npv);
            }
            
            Console.ReadKey();
        }

        
    }
}