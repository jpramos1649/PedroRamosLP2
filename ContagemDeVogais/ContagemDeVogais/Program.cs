using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContagemDeVogais
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = Console.ReadLine();
            int contV = 0, i = 0, cont = txt.Length;


            while (i < cont)
             {
                switch (txt[i])
                {

                    case 'a':
                        contV++;
                        break;
                    case 'e':
                        contV++;
                        break;
                    case 'i':
                        contV++;
                        break;
                    case 'o':
                        contV++;
                        break;
                    case 'u':
                        contV++;
                        break;

                    case 'A':
                        contV++;
                        break;
                    case 'E':
                        contV++;
                        break;
                    case 'I':
                        contV++;
                        break;
                    case 'O':
                        contV++;
                        break;
                    case 'U':
                        contV++;
                        break;



                }

                i++;
                
             }

            Console.WriteLine(contV);
            Console.ReadKey();

        }
    }
}
