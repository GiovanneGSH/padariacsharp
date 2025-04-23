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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        int i = 0;

        int j = 0; 
        
        int k = 0;        

        string[,] alunos = new string[3,3];             

        double[,] prova1 = new double[3,3];

        double[,] prova2 = new double[3,3];

        double[,] prova3 = new double[3,3];

        double[,] trabalho = new double[3,3];
             


        private void btnInserir_Click(object sender, EventArgs e)
        {

            alunos[i, j] = txtNome.Text;                    

            prova1[i, j] = double.Parse(txtNota1.Text);

            prova2[i, j] = double.Parse(txtNota2.Text);

            prova3[i, j] = double.Parse(txtNota3.Text);

            trabalho[i, j] = double.Parse(txtNotaTrabalho.Text);
                       

            txtNome.Clear();
            txtNome.Focus();

            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNotaTrabalho.Clear();

            j++;

            if (j == 3)
            {
                i++;
                j = 0;
            }

            k++;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNotaTrabalho.Clear();
            txtNome.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
                       
            lblMostraNome.Text = alunos[0, 0];
            lblMostraNota1.Text = prova1[0, 0].ToString();
            lblMostraNota2.Text = prova2[0, 0].ToString();
            lblMostraNota3.Text = prova3[0, 0].ToString();
            lblMostraNotaTrabalho.Text = trabalho[0, 0].ToString();

            double media = (prova1[0, 0] + prova2[0, 0] + prova3[0, 0] + trabalho[0, 0]) / 4;

            lblMostraMedia.Text = media.ToString();

            if (media == 10)
            {
                lblMostraCF.Text = "Aprovado*";
            }
            else if (media >= 7)
            {
                lblMostraCF.Text = "Aprovado";
            }
            else if (media >= 5 && media < 7)
            {
                lblMostraCF.Text = "Recuperação";
            }
            else if (media < 5) 
            {
                lblMostraCF.Text = "Reprovado";
            }                       
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
                        
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {

        }

        private void btnLimparConceito_Click(object sender, EventArgs e)
        {
            ltbAprovados.Items.Clear();
            ltbRecuperacao.Items.Clear();
            ltbReprovados.Items.Clear();
        }

        private void btnConceito_Click(object sender, EventArgs e)
        {

            //if (k == 9)
            //{
            //   int i = 0;
            //   int j = 0;

            //    for (j = 0; j < 9; j++)                 
            //    {

            //        double media = (prova1[i, j] + prova2[i, j] + prova3[i, j] + trabalho[i, j]) / 4;

            //        if (media >= 7)
            //        {
            //            ltbAprovados.Items.Add("----APROVADOS----");
            //            ltbAprovados.Items.Add(alunos[i, j]);
            //        }                    
            //        else if (media >= 5 && media < 7)
            //        {
            //            ltbRecuperacao.Items.Add("----RECUPERAÇÃO----");
            //            ltbRecuperacao.Items.Add(alunos[i, j]);
            //        }
            //        else if (media < 5)
            //        {
            //            ltbReprovados.Items.Add("----REPROVADOS----");
            //            ltbReprovados .Items.Add(alunos[i, j]);
            //        }

            //    }
            //}        
           
        }
                
    }
}
