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
			List<Figura> LF = new List<Figura>();

			Triangulo T = new Triangulo();
			Circulo C = new Circulo();
			Quadrado Q = new Quadrado();

			int Op = 0;
			do
			{
				Console.Clear();
				Console.WriteLine("===== MENU DE OPÇÕES =====");
				Console.WriteLine("[1] - Adicionar Quadrado");
				Console.WriteLine("[2] - Adicionar Triangulo");
				Console.WriteLine("[3] - Adicionar Círculo");
				Console.WriteLine("[4] - Mostrar o Nome, a Cor e a Área de uma determinada figura");
				Console.WriteLine("[5] - Sair do programa");
				Console.WriteLine("==========================");
				Console.Write("Sua opção: ");
				Op = int.Parse(Console.ReadLine());

				switch (Op)
				{
					case 1:
						Console.Clear();
						Console.WriteLine("======== QUADRADO =======");
                        Console.WriteLine("Nome: ");
						break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("======== TRIANGULO =======");
                        Console.Write("Nome: ");
                        T.Nome = Console.ReadLine();
                        Console.Write("Cor: ");
                        T.Cor= Console.ReadLine();
                        Console.Write("Altura: ");
                        T.AlturaT = double.Parse(Console.ReadLine());
                        Console.Write("Base: ");
                        T.BaseT = double.Parse(Console.ReadLine());
                        llllkl
                        Console.WriteLine(T.Area());
                        break;
                }

			} while (Op!=5);
        }
    }
}
