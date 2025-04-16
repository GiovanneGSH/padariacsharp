using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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

            //int valor1, valor4, resp; //Inteiro
            //double valor2; // Real x64 -> Mais utilizada.
            //float valor3; // Real x32

            //bool flag;// Boleando

            //string nome; // Texto

            //char sexo; // Texto

            //inicializar as variáveis

            //valor1 = 10;

            //valor4 = 10;

            //resp = valor1 + valor4;
            
            Operacoes op = new Operacoes();  //Instânciando a Classe

            double num1, num2, resp = 0;

            try // Tratativa de erros try{}catch(exception){}
            {

                num1 = Convert.ToDouble(txtNumero1.Text);
                num2 = Convert.ToDouble(txtNumero2.Text);

                if (rdbSomar.Checked == false &&
                    rdbSubtrair.Checked == false &&
                    rdbMultiplicacao.Checked == false &&
                    rdbDivisao.Checked == false)
                {
                    MessageBox.Show("Selecione uma operação", "Mensagem do sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {

                    if (rdbSomar.Checked) //Condicional
                    {
                        resp = op.getSoma(num1, num2);                                                                
                                                
                    }
                    txtResposta.Text = resp.ToString(); //Convertendo a resposta para String

                    if (rdbSubtrair.Checked)
                    {
                        resp = op.getSubtração(num1, num2);
                    }
                    txtResposta.Text = resp.ToString();

                    if (rdbMultiplicacao.Checked)
                    {
                        resp = op.getMultiplicacao(num1, num2);
                    }
                    txtResposta.Text = resp.ToString();

                    if (rdbDivisao.Checked)
                    {
                        if (num2 == 0) // tratando o erro de dividir o número por zero.
                        {
                            MessageBox.Show("Impossível dividir por zero", "Mensagem do Sistema",
                                MessageBoxButtons.OK, MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1); // mostra a  mensagem para o usuário.
                            resp = 0;
                        }
                        else
                            resp = op.getDivisao(num1, num2);
                    }
                    txtResposta.Text = resp.ToString();

                }

            }
            catch (Exception) { //Tratativa de erros
                MessageBox.Show("Insira valores válidos", "Mensagem do Sistema",
                            MessageBoxButtons.OK, MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1);
                limparCampos();
            }
        }

        public void limparCampos() //Criando o método criar campos
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero1.Focus();
        }

        public void limparCamposDesabilitar() 
        {
            limparCampos(); // Limpar campos

            rdbSomar.Checked = false;
            rdbSubtrair.Checked = false;
            rdbMultiplicacao.Checked = false;
            rdbDivisao.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //limpar os campos
            //txtNumero1.Text = "";

            ////limpar os campos método II 

            //txtNumero2.Clear();

            //txtResposta.Clear();

            limparCampos();

            //limpar seleção radio button

            limparCamposDesabilitar();

            //cursor na primeira caixa

            txtNumero1.Focus();
                        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Sair do sistema e encerrar todos os programas
            Application.Exit();
        }
    }
}
