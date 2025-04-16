using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padaria
{
    public class Operacoes 
    {
        private double valor1;
        private double valor2;

        public void setValor1(double valor1)
        {
            this.valor1 = valor1;
        }        

        public void setValor2(double valor2)

        {
            this.valor2 = valor2;
        }       

        public double getSoma(double valor1, double valor2)
        {
            return (valor1 + valor2);
        }

        public double getSubtração(double valor1, double valor2)
        {
            return (valor1 - valor2);
        }

        public double getMultiplicacao(double valor1, double valor2)
        {
            return (valor1 * valor2);
        }
             
        public double getDivisao(double valor1, double valor2)
        {
            return (valor1 / valor2);
        }
    }
}
