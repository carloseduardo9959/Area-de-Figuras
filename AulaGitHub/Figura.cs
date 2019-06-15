using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaGitHub
{
	class Figura
	{
		private string cor;
		private string nome;

		public string Cor { get => cor; set => cor = value; }
		public string Nome { get => nome; set => nome = value; }

		virtual public double Area()
		{
			return 0;
		}

		public string GetFigura()
		{
			string aux = " ";
			aux= "Nome: " +Nome +"   Cor: " + Cor;
			return aux;
		}
	}
}
