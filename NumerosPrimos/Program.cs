<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite um número: ");

            n = Convert.ToInt32(Console.ReadLine());
            int divisor = 0;
            for(int i = 1; i<= n; i++)
            {
                if(n%i == 0)
                {
                    divisor++;
                }
            }
                if (divisor ==2)
            {
                Console.WriteLine("O número " + n + " é um número primo");
                Console.Read();
            }
            else
            {
                Console.WriteLine("O número " + n + " não é um número primo");
                Console.Read();
            }
            Console.Read();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite um número: ");

            n = Convert.ToInt32(Console.ReadLine());
            int divisor = 0;
            for(int i = 1; i<= n; i++)
            {
                if(n%i == 0)
                {
                    divisor++;
                }
            }
                if (divisor ==2)
            {
                Console.WriteLine("O número " + n + " é um número primo");
                Console.Read();
            }
            else
            {
                Console.WriteLine("O número " + n + " não é um número primo");
                Console.Read();
            }
            Console.Read();
        }
    }
}
>>>>>>> e8e7d42c368e8ae46807e2cf21a2e5c08418c9e5
