using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoSintaxeSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com um valor para o dia da semana: ");
            int x = int.Parse(Console.ReadLine());
            string dia;

            switch (x)
            {
                case 1:
                    dia = "Domingo";
                    break;
                case 2:
                    dia = "Segunda";
                    break;
                case 3:
                    dia = "Terça";
                    break;
                case 4:
                    dia = "Quarta";
                    break;
                case 5:
                    dia = "Quinta";
                    break;
                case 6:
                    dia = "Sexta";
                    break;
                case 7:
                    dia = "Sabado";
                    break;
                default:
                    dia = "Dia Inexistente!";
                    break;
            }

            Console.WriteLine($"O dia da semana é {dia}");
            Console.ReadLine();
        }
    }
}
