using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonAssubly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Runner runner= new Runner();
            runner.Run();
            runner.Run_10Item();
            runner.print();
            runner.item100();
        }
    }
}
