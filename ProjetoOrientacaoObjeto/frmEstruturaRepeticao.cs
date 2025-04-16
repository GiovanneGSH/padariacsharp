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
    public partial class frmEstruturaRepeticao : Form
    {

        //Método construtor da classe
        public frmEstruturaRepeticao()
        {
            InitializeComponent();
            //executa o método carrega combo
            carregaCombo();

            txtCadastro.TabIndex = 0;


            //carregaListaEstados();
        }

        private void btnCarregaEstado_Click(object sender, EventArgs e)
        {
            //executa o método carrega combo
            carregaCombo();

        }
        //criando o método construtor
        public void carregaCombo()
        {

            cbbEstados.Items.Clear();
            cbbEstados.Items.Add("Santo Amaro");
            cbbEstados.Items.Add("Capão Redondo");
            cbbEstados.Items.Add("São Luiz");
            cbbEstados.Items.Add("Jardim Angela");
            cbbEstados.Items.Add("Jardim Jacira");
            cbbEstados.Items.Add("Jardim Nakamura");
            cbbEstados.Items.Add("Capelinha");
            cbbEstados.Items.Add("Vila Remo");
            cbbEstados.Items.Add("Piraporinha");
            cbbEstados.Items.Add("Campo Grande");
            cbbEstados.Items.Add("Campo Limpo");

        }

        public void carregaListaEstados()
        {
            ltbListaEstados.Items.Clear();
            ltbListaEstados.Items.Add("Pinheiros");
            ltbListaEstados.Items.Add("Ibirapuera");
            ltbListaEstados.Items.Add("Moema");
            ltbListaEstados.Items.Add("Borba Gato");
            ltbListaEstados.Items.Add("Granja Julieta");
            ltbListaEstados.Items.Add("Morumbi");
            ltbListaEstados.Items.Add("Alto da Boa Vista");
            ltbListaEstados.Items.Add("Vila Olímpia");
            ltbListaEstados.Items.Add("Brooklin");
            ltbListaEstados.Items.Add("Cidade Jardim");
        }


        private void btnCarregaListaEstados_Click(object sender, EventArgs e)
        {
            //carregaListaEstados();
        }

        private void btnInserirEstado_Click(object sender, EventArgs e)
        {
            if (txtCadastro.Text.Equals(""))
            {
                menssagemSistema();
                limpaCampo();
            }
            else 
            {
                inserirEstado();
            }
        }

        public void inserirEstado()    //Criando o método para inserir Estados
        {           
                ltbListaEstados.Items.Add(txtCadastro.Text);
                limpaCampo();                       
                
        }
        private void txtCadastro_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter && txtCadastro.Text.Equals(""))
            {
                menssagemSistema();
            }
            else
                if (e.KeyCode == Keys.Enter && txtCadastro.Text != "")

            {
                inserirEstado();
            }
                        
        }

        public void limpaCampo() // Criando o método para limpar campos.
        {
            txtCadastro.Clear();
            txtCadastro.Focus();
        }

        public void menssagemSistema() //Criando o método para monstrar uma mensagem no sistema.
        {
            MessageBox.Show("Por favor inserir um Estado", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }



}

