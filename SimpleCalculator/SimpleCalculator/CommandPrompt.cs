using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class CommandPrompt
    {
    
        static void First(string[] args)
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

        //public int Count()
        //{
        //    //If the list is empty
        //    //this.Count == 0
        //    if (this.First() == x)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        int length = 1;
        //        var node = this.first_node;
        //        //Complexity is 0(n)
        //        while (node.Next != null)
        //        {
        //            length++;
        //            node = node.Next;
        //        }
        //        return length;
        //    }

            //Provide a second implementation
        }
    }

