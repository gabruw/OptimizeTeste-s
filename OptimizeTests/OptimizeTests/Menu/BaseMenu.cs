using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizeTests.Menu
{
    class BaseMenu
    {
        public void MenuSwith()
        {
            var opcao = 5;
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    break;
                case 4:
                    Console.WriteLine("Case 4");
                    break;
                case 5:
                    Console.WriteLine("Case 5");
                    break;
                default:
                    break;
            }
        }

        public void MenuIf()
        {
            var opcao = 5;
            if (opcao == 1)
            {
                Console.WriteLine("Case 1");
            }
            else if (opcao == 2)
            {
                Console.WriteLine("Case 2");
            }
            else if (opcao == 3)
            {
                Console.WriteLine("Case 3");
            }
            else if (opcao == 4)
            {
                Console.WriteLine("Case 4");
            }
            else if (opcao == 5)
            {
                Console.WriteLine("Case 5");
            }
        }
    }
}
