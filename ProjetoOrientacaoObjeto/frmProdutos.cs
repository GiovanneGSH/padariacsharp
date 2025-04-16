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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtQuantidade.Clear();
            txtValor.Clear();
            txtCodigo.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Produtos pr = new Produtos();

            pr.setCodigo(txtCodigo.Text);
            lblMostraC.Text = pr.getCodigo();

            pr.setDescricao(txtDescricao.Text);
            lblMostraD.Text = pr.getDescricao();

            pr.setQuantidade(Convert.ToInt32(txtQuantidade.Text));
            lblMostraQ.Text = pr.getQuantidade().ToString();

            pr.setValor(Convert.ToInt32(txtValor.Text));
            lblMostraV.Text = pr.getValor().ToString("C2");

            pr.setDataEntrada(txtValor.Text);
            lblMostraDE.Text = dtpDataEntrada.Value.ToString();

            pr.setDataSaida(txtValor.Text);
            lblMostraDS.Text = dtpDataSaida.Value.ToString();

            pr.setTotal(Convert.ToInt32(txtQuantidade.Text));
            lblMostraT.Text = pr.getTotal()+pr.getQuantidade().ToString();


        }
    }
}
