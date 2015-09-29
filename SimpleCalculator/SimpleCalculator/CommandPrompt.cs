using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using SC = System.Console;

namespace SimpleCalculator
{
    public class CommandPrompt : Addition
    {
        public static int i { get; private set; }

        public void Command(string[] args)
        {

            int response = 1;
            int answer = 1;

            Console.WriteLine("[x]>");
            response = int.Parse(SC.ReadLine());

            for (var i = 0; i < 10; i++)
            {
               answer *= i;
            }
            response = answer;
           
            Console.WriteLine("[{0}>]", response);
            //Console.WriteLine("Press any key to exit...");
            Console.ReadLine();


        }
    }
    }

