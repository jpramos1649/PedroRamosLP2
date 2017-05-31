using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNoPlano
{
    class Program
    {
        static void Main(string[] args)
        {
            Obejeto2D obj = new Obejeto2D();

            Console.WriteLine("digite x inicial: ");
            obj.x = int.Parse(Console.ReadLine());

            Console.WriteLine("digite y inicial: ");
            obj.y = int.Parse(Console.ReadLine());

            
            while(true)
            {
                
             Console.WriteLine("digite o comando: ");
             ConsoleKey comando = Console.ReadKey().Key;

             if (comando == ConsoleKey.RightArrow)
             {
                 obj.AndarParaDireita();
                 
             }

            }






        }
    }
}
