using OptimizeTests.Repetição;
using OptimizeTests.Menu;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizeTests
{
    class Index
    {
        static void Main(string[] args)
        {
            var index = new Index();

            // Repetição
            index.BenchmarkRepeticao();
            Console.ReadKey();

            Console.Clear();

            // Menu
            index.BenchmarkMenu();
            Console.ReadKey();

            Console.Clear();
        }

        internal void BenchmarkRepeticao()
        {
            var stopwatch = new Stopwatch();
            var BaseClass = new BaseRepeticao();

            Console.WriteLine("[For]");
            stopwatch.Start();
            BaseClass.PrintFor();
            stopwatch.Stop();
            var timeFor = stopwatch.Elapsed;
            Console.WriteLine("Tempo passado: {0} \n", timeFor);

            Console.WriteLine("[Foreach]");
            stopwatch.Start();
            BaseClass.PrintForeach();
            stopwatch.Stop();
            var timeForeach = stopwatch.Elapsed;
            Console.WriteLine("Tempo passado: {0} \n", timeForeach);
            stopwatch.Restart();

            Console.WriteLine("[While]");
            stopwatch.Start();
            BaseClass.PrintWhile();
            stopwatch.Stop();
            var timeWhile = stopwatch.Elapsed;
            Console.WriteLine("Tempo passado: {0} \n", timeWhile);
            stopwatch.Restart();

            Console.WriteLine("[Linq]");
            stopwatch.Start();
            BaseClass.PrintLinq();
            stopwatch.Stop();
            var timeLinq = stopwatch.Elapsed;
            Console.WriteLine("Tempo passado: {0}", timeLinq);
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("[For]");
            Console.WriteLine("Tempo Total {0}", timeFor);

            Console.WriteLine("[Foreach]");
            Console.WriteLine("Tempo Total {0}", timeForeach);

            Console.WriteLine("[While]");
            Console.WriteLine("Tempo Total {0}", timeWhile);

            Console.WriteLine("[Linq]");
            Console.WriteLine("Tempo Total {0}", timeLinq);
            Console.ReadKey();
        }

        internal void BenchmarkMenu()
        {
            var stopwatch = new Stopwatch();
            var BaseClass = new BaseMenu();

            Console.WriteLine("[Swith]");
            stopwatch.Start();
            BaseClass.MenuSwith();
            stopwatch.Stop();
            var timeSwith = stopwatch.Elapsed;
            Console.WriteLine("Tempo passado: {0} \n", timeSwith);

            Console.WriteLine("[If]");
            stopwatch.Start();
            BaseClass.MenuIf();
            stopwatch.Stop();
            var timeIf = stopwatch.Elapsed;
            Console.WriteLine("Tempo passado: {0} \n", timeIf);
            Console.ReadKey();
        }
    }
}
