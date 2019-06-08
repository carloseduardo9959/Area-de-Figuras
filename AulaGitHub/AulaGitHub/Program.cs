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
						Console.Write("Nome: ");
						Q.Nome = Console.ReadLine();
						Console.Write("Cor: ");
						Q.Cor = Console.ReadLine();
						Console.Write("Lado: ");
						Q.Lado = double.Parse(Console.ReadLine());
                        Console.Write(Q.Area());
                        LF.Add(Q);
						break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("======== TRIANGULO =======");
                        Console.Write("Nome: ");
                        T.Nome = Console.ReadLine();
                        Console.Write("Cor: ");
                        T.Cor = Console.ReadLine();
                        Console.Write("Altura: ");
                        T.AlturaT = double.Parse(Console.ReadLine());
                        Console.Write("Base: ");
                        T.BaseT = double.Parse(Console.ReadLine());
                        Console.Write(T.Area());
                        LF.Add(T);
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("======== CIRCULO =======");
                        Console.Write("Nome: ");
                        C.Nome = Console.ReadLine();
                        Console.Write("Cor: ");
                        C.Cor = Console.ReadLine();
                        Console.Write("Raio: ");
                        C.Raio = double.Parse(Console.ReadLine());
                        Console.Write(T.Area());
                        LF.Add(T);
                        break;
                    //Deu certo???
                    case 4:
						Console.Clear();
						foreach (Figura item in LF)//Comando para mostrar todos os valores dentro da lista
                        {
                            Console.WriteLine("Nome: "+item.Nome);
							Console.WriteLine("Cor: " + item.Cor);
                            Console.WriteLine("Area: " +item.Area());
                        }
                        Console.ReadKey();

                        break;
                        

                }
            } while (Op!=5);
        }
    }
}
