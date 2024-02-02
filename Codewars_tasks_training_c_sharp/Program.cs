using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codewars_task_lib;

namespace Codewars_tasks_training_c_sharp {
    internal class Program {
        static void Main(string[] args) {
            string name = "aba";
            Dictionary<char, int> result = new Dictionary<char, int>();
            result = CodewarsLib.Count(name);
            foreach (var item in result) {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        
    }
}
