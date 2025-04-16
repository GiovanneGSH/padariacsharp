using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOrientacaoObjeto
{
    public partial class frmTeste : Form
    {
        public frmTeste()
        {
            InitializeComponent();
        }

        int contador = 0;

        string[] nomes = new string[3];

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtInserir.Text;
            
            for (int i = contador; i < nome.Length && i == contador; i++)
            {
                nomes[i] = nome;
                ltbTeste.Items.Add(nome[i]);
            }
            contador++;

            
        }
    }
}
