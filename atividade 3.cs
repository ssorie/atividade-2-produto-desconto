using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_2_aula_dia_02_04
{
    internal class Program
    {
        static void Main(string[] args)
            //1. inicio
            //2. var inicio: caracter, preço, prestação, total:real
            //3. leia nome
            //4. leia preço
            //5. total = preço - preço * 0.10 || total = preço - preço * 10/100
            //6. escreva o total
            //7. total = preço + preço * 0.02
            //8. escreva o total
            //9. total = preço + preço * 0.05
            //10. escreva o total
            //11. fim.
        {
            string inicio;
            double preço, total;

             string inicio;
 double preço = 0, total;

 Console.Write("Digite o nome do produto: ");
 inicio = Console.ReadLine();
 Console.ReadLine();
 Console.WriteLine("----------------------------");
 Console.Write("Digite o preço R$: ");

 total = preço - preço * 0.10;
 Console.ReadKey();
        }
    }
}
