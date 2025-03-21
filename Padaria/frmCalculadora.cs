using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padaria
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Comentário de linha
            /*
             Comentário de Bloco
            *Versão: 1.0
            *Data: 20/03/2025
            */

            //Declarando variáveis: Tipo da Variável + Nome da Variável = Valor da Variável -> ;

            int valor1, valor4, resp; //Inteiro
            double valor2; // Real x64 -> Mais utilizada.
            float valor3; // Real x32

            bool flag;// Boleando

            string nome; // Texto

            char sexo; // Texto

            //inicializar as variáveis

            valor1 = 10;

            valor4 = 10;

            resp = valor1 + valor4;
            
            

        }
    }
}
