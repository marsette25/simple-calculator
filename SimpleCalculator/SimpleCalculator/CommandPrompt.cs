using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class CommandPrompt
    {
    
        static void Main(string[] args)
        {

            int response = 1;
            int answer = 1;

            Console.WriteLine("[x]>");
            response = Int32.Parse(Console.ReadLine());

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
