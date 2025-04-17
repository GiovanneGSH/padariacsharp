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

            desativaRdbs();

            desabilitaCampos();
            
        }

        Random rnd = new Random();

        int tamanho;

        public void desativaRdbs()
        {
            rdbInteirosA.Checked = false;
            rdbVariosInteiros.Checked = false;
            rdbIntAIntervalos.Checked = false;
            rdbGerarFloatsA.Checked = false;
            rdbAleatoriosRepeticao.Checked = false;
        }

        public void limpaCampoNumero()
        {
            txtNumero.Clear();
            txtNumero.Focus();
        }

        public void desabilitaCampos() 
        {
            txtNumero.Enabled = false;
            txtNMinimo.Enabled = false;
            txtNMaximo.Enabled = false;
            txtRepeticao.Enabled = false;
        }
               
        private void btnGerar_Click(object sender, EventArgs e)
        {
            
            if (rdbInteirosA.Checked)
            {

                try
                {
                    {                        
                        int numero = rnd.Next();
                        ltbMostraNumero.Items.Add(numero);
                        limpaCampoNumero();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Favor inserir um número inteiro");
                    limpaCampoNumero();
                }

            }

            if (rdbVariosInteiros.Checked)
            {

                try
                {
                    int valor = int.Parse(txtNumero.Text);
                    int numero = rnd.Next(valor);
                    ltbMostraNumero.Items.Add(numero);
                    limpaCampoNumero();
                }
                catch
                {
                    MessageBox.Show("Inserir um número inteiro");
                    limpaCampoNumero();
                }
                limpaCampoNumero();

            }

            if (rdbIntAIntervalos.Checked)
            {

                try
                {
                    int valor1 = int.Parse(txtNMaximo.Text);
                    int valor2 = int.Parse(txtNMinimo.Text);
                    int numero = rnd.Next(valor2, valor1);
                    ltbMostraNumero.Items.Add(numero);
                    limpaCampoNumero();
                }
                catch
                {
                    MessageBox.Show("Inserir um número inteiro");
                    limpaCampoNumero();
                }
                limpaCampoNumero();

            }

            if (rdbGerarFloatsA.Checked)
            {

                try
                {                    
                    double numero = rnd.NextDouble();
                    ltbMostraNumero.Items.Add(numero);
                    limpaCampoNumero();
                }
                catch
                {
                    MessageBox.Show("Inserir um número inteiro");
                    limpaCampoNumero();
                }
                limpaCampoNumero();

            }

            if (rdbAleatoriosRepeticao.Checked)
            {

                try
                {
                    string traco = "----------";

                    int valor = int.Parse(txtNumero.Text);

                    int tamanho = int.Parse(txtRepeticao.Text);

                    for (int i = 0; i < tamanho; i++)
                    {
                        ltbMostraNumero.Items.Add(rnd.Next(valor));
                    }
                    ltbMostraNumero.Items.Add(traco);
                }
                catch
                {
                    MessageBox.Show("Inserir a quantidade de repetições");
                    txtRepeticao.Clear();
                    txtRepeticao.Focus();
                }
                limpaCampoNumero();
                txtRepeticao.Clear();                

            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            desativaRdbs();

            desabilitaCampos();

            txtNMinimo.Clear();
            txtNMaximo.Clear();
            txtNumero.Clear();
            txtRepeticao.Clear();
            ltbMostraNumero.Items.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdbVariosInteiros_CheckedChanged(object sender, EventArgs e)
        {
            txtNMaximo.Enabled = false;
            txtNMinimo.Enabled = false;
            txtNumero.Enabled = true;
            txtRepeticao.Enabled = false;
            txtNumero.Focus();
        }

        private void rdbIntAIntervalos_CheckedChanged(object sender, EventArgs e)
        {
            txtNumero.Enabled = false;
            txtNMaximo.Enabled = true;
            txtNMinimo.Enabled = true;
            txtRepeticao.Enabled = false;
            txtNMinimo.Focus();
        }

        private void rdbInteirosA_CheckedChanged(object sender, EventArgs e)
        {
            desabilitaCampos();
            txtNumero.Focus();
        }

        private void rdbAleatoriosRepeticao_CheckedChanged(object sender, EventArgs e)
        {
            txtNMaximo.Enabled = false;
            txtNMinimo.Enabled = false;
            txtNumero.Enabled = true;
            txtRepeticao.Enabled = true;
            txtNumero.Focus();

        }

    }  

}
