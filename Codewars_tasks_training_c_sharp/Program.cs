using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codewars_task_lib;

namespace Codewars_tasks_training_c_sharp {
    internal class Program {
        static void Main() {
            // string name = ">=8?-vf-gjryir";
            long n = 1234567890;
            n = CodewarsLib.NextBiggerNumber(n);
            Console.WriteLine(n);

            Console.ReadLine();
        }

        
    }
}
