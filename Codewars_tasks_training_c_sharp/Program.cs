using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codewars_task_lib;

namespace Codewars_tasks_training_c_sharp {
    internal class Program {
        static void Main(string[] args) {
            string name = ">=8?-vf-gjryir";
            name = CodewarsLib.Rot13(name);
            Console.WriteLine(name);

            Console.ReadLine();
        }

        
    }
}
