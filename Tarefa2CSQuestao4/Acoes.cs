using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa2CSQuestao4
{
    public class Acoes
    {
        static void Main(string[] args)
        {
            Console.WriteLine(funcaoRetornaQuantitadePOV(0.1M, 90)); //10
            Console.WriteLine(funcaoRetornaQuantitadePOV(0.1M, 100)); //11
            Console.WriteLine(funcaoRetornaQuantitadePOV(0.2M, 70)); //17
        }
        public static int funcaoRetornaQuantitadePOV(decimal porcentagem, int totalNegociado)
        {
            return (int) (porcentagem * totalNegociado / (1 - porcentagem));
        }
    }
}
