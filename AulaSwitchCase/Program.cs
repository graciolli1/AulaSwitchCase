using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaSwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mesextenso = null;
            int mes, dia, ano;
            Console.WriteLine("Digite uma data: \n[Formato: DD/MM/AAAA]");
            var numero1 = Convert.ToDateTime(Console.ReadLine());
            mes = numero1.Month;
            dia = numero1.Day;
            ano = numero1.Year;
            switch (mes)
            {
                case 1:
                    mesextenso = ("Janeiro");
                    break;
                case 2:
                    mesextenso = ("Fevereiro");
                    break;
                case 3:
                    mesextenso = ("Março");
                    break;
                case 4:
                    mesextenso = ("Abriu");
                    break;
                case 5:
                    mesextenso = ("Maio");
                    break;
                case 6:
                    mesextenso = ("Junho");
                    break;
                case 7:
                    mesextenso = ("Julho");
                    break;
                case 8:
                    mesextenso = ("Agosto");
                    break;
                case 9:
                    mesextenso = ("Setembro");
                    break;
                case 10:
                    mesextenso = ("Outubro");
                    break;
                case 11:
                    mesextenso = ("Novembro");
                    break;
                case 12:
                    mesextenso = ("Dezembro");
                    break;
            }
            Console.WriteLine(dia + " de " + mesextenso + " de " + ano);
            Console.ReadKey();
        }
    }
}
