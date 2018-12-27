using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> lista = new List<Figura>();

            Console.Write("Quantas figuras você vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.Write("Figura "+ i + " - triângulo ou retângulo? (t/r)? ");
                char ch = char.Parse(Console.ReadLine());
                if(ch == 'r')
                {
                    Figura f = Tela.lerRetangulo();
                    lista.Add(f);
                }
                else
                {
                    Figura f = Tela.lerTriangulo();
                    lista.Add(f);
                }

            }

            Console.WriteLine();
            Console.WriteLine("Áreas das figuras: ");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Figura " + (i+1) + ": " + lista[i].area());
            }



            Console.ReadKey();
        }
    }
}
