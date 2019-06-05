using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaGitHub
{
    class Circulo : Figura
    {
        private double raio;

        public double Raio { set => raio = value; }//OLOKINHO MEU

        public double Area()
        {
            double A;
            A = 3.1416 * (raio * raio);
            return A;
        }

    }
}
