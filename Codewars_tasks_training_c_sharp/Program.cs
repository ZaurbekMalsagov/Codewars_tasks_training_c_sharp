using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codewars_task_lib;

namespace Codewars_tasks_training_c_sharp {
    internal class Program {
        static void Main(string[] args) {
            string name = "abcabc";
            // name = CodewarsLib.Solution(name, "j");
            Console.WriteLine(CodewarsLib.Solution(name, "bc"));
            Console.ReadLine();
        }

        
    }
}
