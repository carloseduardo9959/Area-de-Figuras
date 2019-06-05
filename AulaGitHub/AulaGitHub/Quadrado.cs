using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaGitHub
{
	class Quadrado:Figura
	{
		private double lado;

		public double Lado {set => lado = value; }

		public override double Area()
		{
			double result= lado*lado;
			return result;
		}
	}
}
