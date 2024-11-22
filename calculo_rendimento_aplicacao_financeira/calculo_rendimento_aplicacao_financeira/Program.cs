using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_rendimento_aplicacao_financeira
{
    internal class Program
    {
        static double valorfinal(double valorincial,double taxa,int meses)
        {
            return valorincial * Math.Pow ((1 + taxa/100),meses);
        }
        static void Main(string[] args)
        {
            double resultado = 0;
            
            Console.Write("Cálculo de Rendimento de uma Aplicação Financeira");

            Console.Write($"\nDigite o valor inicial investido (em R$) : ");
            double qtdvalorinicial = double.Parse(Console.ReadLine());
            
            Console.Write($"\nDigite o percentual de rendimento mensal (ex : 1 para 1%) : ");
            double qtdtaxa = double.Parse(Console.ReadLine());

            //Converte a taxa percentual para decimal.
            //double qtdmeses = qtdtaxa / 100;
            //Math.Pow ((1 + taxa/100),meses);

            Console.Write($"\nDigite o número de meses da aplicação: ");
            int qtdmeses = int.Parse(Console.ReadLine());

            resultado = valorfinal(qtdvalorinicial, qtdtaxa, qtdmeses);
            
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write($"\nApós meses, o valor acumulado será de R$ {resultado:F2}");
            Console.ResetColor();







            Console.ReadKey();
        
        }
    }
}
