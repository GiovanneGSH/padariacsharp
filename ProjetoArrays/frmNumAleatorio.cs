using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoArrays
{
    public partial class frmNumAleatorio : Form
    {
        public frmNumAleatorio()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

       
        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = int.Parse(txtNumero.Text);
                int numero = rnd.Next(valor);
                ltbMostraNumero.Items.Clear();
                ltbMostraNumero.Items.Add(numero);
            }
            catch {
                MessageBox.Show("Inserir um número inteiro");
                txtNumero.Clear();
                txtNumero.Focus();
            }
            txtNumero.Clear();
            txtNumero.Focus();
            

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            txtNumero.Clear();
            txtNumero.Focus();
            ltbMostraNumero.Items.Clear();

        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
