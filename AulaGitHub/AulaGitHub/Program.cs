using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
			int Op = 0;
			do
			{
				Console.WriteLine("===== MENU DE OPÇÕES =====");
				Console.WriteLine("[1] - Adicionar Quadrado");
				Console.WriteLine("[2] - Adicionar Triangulo");
				Console.WriteLine("[3] - Adicionar Círculo");
				Console.WriteLine("[4] - Mostrar o Nome, a Cor e a Área de uma determinada figura");
				Console.WriteLine("[5] - Sair do programa");
				Console.WriteLine("==========================");
				Console.Write("Sua opção: ");
				Op = int.Parse(Console.ReadLine());
			} while (Op!=5);
        }
    }
}
