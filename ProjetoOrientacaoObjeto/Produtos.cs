using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrientacaoObjeto
{
    public class Produtos
    {
        private string codigo;
        private string descricao;
        private int quantidade;
        private double valor;
        private int total;
        private string dataEntrada;
        private string dataSaida;

        public void setCodigo(string codigo)
        {
            this.codigo = codigo;
        }
        public string getCodigo() 
        {
            return this.codigo;       
        }

        public void setDescricao(string descricao) 
        { 
            this.descricao = descricao;
        }

        public string getDescricao() 
        { 
            return this.descricao;
        }

        public void setQuantidade(int quantidade) 
        { 
            this.quantidade = quantidade;
        }

        public int getQuantidade() 
        {             
            return this.quantidade;
        }

        public void setValor(double valor)
        {
            this.valor = valor;
        }

        public double getValor()
        {
            return this.valor;
        }

        public void setTotal(int total) 
        {         
            this.total = total;
        }

        public int getTotal() 
        {         
            return this.total;        
        }

        public void setDataEntrada(string dataEntrada) 
        {         
            this.dataEntrada = dataEntrada;
        }

        public string getDataEntrada()
        {
            return this.dataEntrada;
        }

        public void setDataSaida(string dataSaida) 
        {             
            this.dataSaida = dataSaida;        
        }

        public string getDataSaida() 
        {         
            return this.dataSaida;
        }



    }
}
