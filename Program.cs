using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcEstacoesAno
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia;
            string mes;

            Console.WriteLine("********** Programa que informa as estações astronômicas do hemisfério sul - 2020 **********");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Que dia deseja consultar? ");
            dia = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Dê que mês? ");
            mes = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("");

            int diaInt = 0;
            int mesInt = 0;

            try
            {
                diaInt = Convert.ToInt32(dia);
                mesInt = Convert.ToInt32(mes);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                Environment.Exit(1);
            }

            InterpretadorEstacao interpretador = new InterpretadorEstacao();
            Estacao estacao = interpretador.Interpretar(diaInt, mesInt);

            if(estacao != null)
            {
                Console.WriteLine("A estação do ano atual é " + estacao.nome + ". " + estacao.caracteristicas);
            }
            else
            {
                Console.WriteLine("Dados informados incorretamente. Tente novamente.");
            }
            Console.ReadKey();
        }
    }
}
