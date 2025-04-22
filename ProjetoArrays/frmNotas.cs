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

        string [,] alunos = new string [10,10];
        
        int i = 0;
        
        int j = 0;
        
        double [,] prova1 = new double [10,10];

        double [,] prova2 = new double [10,10];

        double [,] prova3 = new double [10,10];

        double [,] trabalho = new double [10,10];


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

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        
    }
}
