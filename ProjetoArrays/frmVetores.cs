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
    public partial class frmVetores : Form
    {
        public frmVetores()
        {
            InitializeComponent();           
        }   
           
          static int tamanho;

          int contador = 0;

          string[] nomes = new string[tamanho];

        private void btnCarrega_Click(object sender, EventArgs e)
        {
            carrregaVetores();
        }    
        
        public void carrregaVetores()
        {
            int tamanho = int.Parse(txtTamanho.Text);

            nomes[contador] = txtNome.Text;
            

            if (contador == 2)
            {
                for (int i = 0; i < nomes.Length; i++)
                {
                    ltbNomes.Items.Add(nomes[i]);
                }
            }
            contador++;
            txtNome.Focus();

        }
        
    } 
}
