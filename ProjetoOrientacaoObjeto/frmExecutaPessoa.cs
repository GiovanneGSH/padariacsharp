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
    public partial class frmExecutaPessoa : Form
    {
        public frmExecutaPessoa()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa ps = new Pessoa();

            ps.setNome(txtNome.Text);

            lblMostraNome.Text = ps.getNome();                      
                    

            ps.setEmail(txtEmail.Text);

            lblMostraEmail.Text = ps.getEmail();          
                      

            ps.setCpf(mktCpf.Text);

            lblMostraCpf.Text = ps.getCpf();            
                        

            ps.setTelefone(mktTelefone.Text);

            lblMostraTelefone.Text = ps.getTelefone();
                                                        

            ps.setIdade(Convert.ToInt32(txtIdade.Text));

            lblMostraIdade.Text = ps.getIdade().ToString();


        }
    }
}
