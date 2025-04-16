namespace ProjetoOrientacaoObjeto
{
    partial class frmProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.gpbCadastroProdutos = new System.Windows.Forms.GroupBox();
            this.gpbMostraProdutos = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblMostraCodigo = new System.Windows.Forms.Label();
            this.lblMostraDataEntrada = new System.Windows.Forms.Label();
            this.lblMostraDescricao = new System.Windows.Forms.Label();
            this.lblMostraDataSaida = new System.Windows.Forms.Label();
            this.lblMostraValor = new System.Windows.Forms.Label();
            this.lblMostraTotal = new System.Windows.Forms.Label();
            this.lblMostraQuantidade = new System.Windows.Forms.Label();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpDataSaida = new System.Windows.Forms.DateTimePicker();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblMostraC = new System.Windows.Forms.Label();
            this.lblMostraD = new System.Windows.Forms.Label();
            this.lblMostraQ = new System.Windows.Forms.Label();
            this.lblMostraV = new System.Windows.Forms.Label();
            this.lblMostraT = new System.Windows.Forms.Label();
            this.lblMostraDE = new System.Windows.Forms.Label();
            this.lblMostraDS = new System.Windows.Forms.Label();
            this.gpbCadastroProdutos.SuspendLayout();
            this.gpbMostraProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(15, 32);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(243, 32);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(84, 20);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Tag = "";
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(15, 137);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(50, 20);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(15, 85);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(96, 20);
            this.lblQuantidade.TabIndex = 4;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataSaida.Location = new System.Drawing.Point(536, 85);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(111, 20);
            this.lblDataSaida.TabIndex = 6;
            this.lblDataSaida.Text = "Data de Saída";
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntrada.Location = new System.Drawing.Point(243, 85);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(127, 20);
            this.lblDataEntrada.TabIndex = 7;
            this.lblDataEntrada.Text = "Data de Entrada";
            // 
            // gpbCadastroProdutos
            // 
            this.gpbCadastroProdutos.Controls.Add(this.txtValor);
            this.gpbCadastroProdutos.Controls.Add(this.txtCodigo);
            this.gpbCadastroProdutos.Controls.Add(this.txtQuantidade);
            this.gpbCadastroProdutos.Controls.Add(this.txtDescricao);
            this.gpbCadastroProdutos.Controls.Add(this.dtpDataSaida);
            this.gpbCadastroProdutos.Controls.Add(this.dtpDataEntrada);
            this.gpbCadastroProdutos.Controls.Add(this.lblCodigo);
            this.gpbCadastroProdutos.Controls.Add(this.lblDataEntrada);
            this.gpbCadastroProdutos.Controls.Add(this.lblDescricao);
            this.gpbCadastroProdutos.Controls.Add(this.lblDataSaida);
            this.gpbCadastroProdutos.Controls.Add(this.lblValor);
            this.gpbCadastroProdutos.Controls.Add(this.lblQuantidade);
            this.gpbCadastroProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCadastroProdutos.Location = new System.Drawing.Point(12, 12);
            this.gpbCadastroProdutos.Name = "gpbCadastroProdutos";
            this.gpbCadastroProdutos.Size = new System.Drawing.Size(776, 191);
            this.gpbCadastroProdutos.TabIndex = 8;
            this.gpbCadastroProdutos.TabStop = false;
            this.gpbCadastroProdutos.Text = "Cadastro Produtos";
            // 
            // gpbMostraProdutos
            // 
            this.gpbMostraProdutos.Controls.Add(this.lblMostraDS);
            this.gpbMostraProdutos.Controls.Add(this.lblMostraDE);
            this.gpbMostraProdutos.Controls.Add(this.lblMostraT);
            this.gpbMostraProdutos.Controls.Add(this.lblMostraV);
            this.gpbMostraProdutos.Controls.Add(this.lblMostraQ);
            this.gpbMostraProdutos.Controls.Add(this.lblMostraD);
            this.gpbMostraProdutos.Controls.Add(this.lblMostraC);
            this.gpbMostraProdutos.Controls.Add(this.lblMostraCodigo);
            this.gpbMostraProdutos.Controls.Add(this.lblMostraDataEntrada);
            this.gpbMostraProdutos.Controls.Add(this.btnSair);
            this.gpbMostraProdutos.Controls.Add(this.lblMostraDescricao);
            this.gpbMostraProdutos.Controls.Add(this.btnLimpar);
            this.gpbMostraProdutos.Controls.Add(this.lblMostraDataSaida);
            this.gpbMostraProdutos.Controls.Add(this.btnCadastrar);
            this.gpbMostraProdutos.Controls.Add(this.lblMostraValor);
            this.gpbMostraProdutos.Controls.Add(this.lblMostraQuantidade);
            this.gpbMostraProdutos.Controls.Add(this.lblMostraTotal);
            this.gpbMostraProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbMostraProdutos.Location = new System.Drawing.Point(12, 209);
            this.gpbMostraProdutos.Name = "gpbMostraProdutos";
            this.gpbMostraProdutos.Size = new System.Drawing.Size(776, 229);
            this.gpbMostraProdutos.TabIndex = 9;
            this.gpbMostraProdutos.TabStop = false;
            this.gpbMostraProdutos.Text = "Produtos";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(46, 152);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(125, 61);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(326, 152);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(125, 61);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(606, 152);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(125, 61);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblMostraCodigo
            // 
            this.lblMostraCodigo.AutoSize = true;
            this.lblMostraCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraCodigo.Location = new System.Drawing.Point(15, 33);
            this.lblMostraCodigo.Name = "lblMostraCodigo";
            this.lblMostraCodigo.Size = new System.Drawing.Size(70, 20);
            this.lblMostraCodigo.TabIndex = 8;
            this.lblMostraCodigo.Text = "Código:";
            // 
            // lblMostraDataEntrada
            // 
            this.lblMostraDataEntrada.AutoSize = true;
            this.lblMostraDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraDataEntrada.Location = new System.Drawing.Point(426, 70);
            this.lblMostraDataEntrada.Name = "lblMostraDataEntrada";
            this.lblMostraDataEntrada.Size = new System.Drawing.Size(147, 20);
            this.lblMostraDataEntrada.TabIndex = 14;
            this.lblMostraDataEntrada.Text = "Data de Entrada:";
            // 
            // lblMostraDescricao
            // 
            this.lblMostraDescricao.AutoSize = true;
            this.lblMostraDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraDescricao.Location = new System.Drawing.Point(243, 32);
            this.lblMostraDescricao.Name = "lblMostraDescricao";
            this.lblMostraDescricao.Size = new System.Drawing.Size(94, 20);
            this.lblMostraDescricao.TabIndex = 9;
            this.lblMostraDescricao.Text = "Descrição:";
            // 
            // lblMostraDataSaida
            // 
            this.lblMostraDataSaida.AutoSize = true;
            this.lblMostraDataSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraDataSaida.Location = new System.Drawing.Point(426, 108);
            this.lblMostraDataSaida.Name = "lblMostraDataSaida";
            this.lblMostraDataSaida.Size = new System.Drawing.Size(129, 20);
            this.lblMostraDataSaida.TabIndex = 13;
            this.lblMostraDataSaida.Text = "Data de Saída:";
            // 
            // lblMostraValor
            // 
            this.lblMostraValor.AutoSize = true;
            this.lblMostraValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraValor.Location = new System.Drawing.Point(15, 108);
            this.lblMostraValor.Name = "lblMostraValor";
            this.lblMostraValor.Size = new System.Drawing.Size(56, 20);
            this.lblMostraValor.TabIndex = 10;
            this.lblMostraValor.Text = "Valor:";
            // 
            // lblMostraTotal
            // 
            this.lblMostraTotal.AutoSize = true;
            this.lblMostraTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraTotal.Location = new System.Drawing.Point(243, 70);
            this.lblMostraTotal.Name = "lblMostraTotal";
            this.lblMostraTotal.Size = new System.Drawing.Size(54, 20);
            this.lblMostraTotal.TabIndex = 12;
            this.lblMostraTotal.Text = "Total:";
            // 
            // lblMostraQuantidade
            // 
            this.lblMostraQuantidade.AutoSize = true;
            this.lblMostraQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraQuantidade.Location = new System.Drawing.Point(15, 70);
            this.lblMostraQuantidade.Name = "lblMostraQuantidade";
            this.lblMostraQuantidade.Size = new System.Drawing.Size(107, 20);
            this.lblMostraQuantidade.TabIndex = 11;
            this.lblMostraQuantidade.Text = "Quantidade:";
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(376, 80);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(117, 26);
            this.dtpDataEntrada.TabIndex = 3;
            // 
            // dtpDataSaida
            // 
            this.dtpDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataSaida.Location = new System.Drawing.Point(653, 82);
            this.dtpDataSaida.Name = "dtpDataSaida";
            this.dtpDataSaida.Size = new System.Drawing.Size(117, 26);
            this.dtpDataSaida.TabIndex = 4;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(329, 29);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(441, 26);
            this.txtDescricao.TabIndex = 1;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(113, 82);
            this.txtQuantidade.MaxLength = 5;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 26);
            this.txtQuantidade.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(80, 29);
            this.txtCodigo.MaxLength = 20;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 26);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(67, 134);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 26);
            this.txtValor.TabIndex = 5;
            // 
            // lblMostraC
            // 
            this.lblMostraC.AutoSize = true;
            this.lblMostraC.Location = new System.Drawing.Point(83, 33);
            this.lblMostraC.Name = "lblMostraC";
            this.lblMostraC.Size = new System.Drawing.Size(0, 20);
            this.lblMostraC.TabIndex = 15;
            // 
            // lblMostraD
            // 
            this.lblMostraD.AutoSize = true;
            this.lblMostraD.Location = new System.Drawing.Point(336, 32);
            this.lblMostraD.Name = "lblMostraD";
            this.lblMostraD.Size = new System.Drawing.Size(0, 20);
            this.lblMostraD.TabIndex = 16;
            // 
            // lblMostraQ
            // 
            this.lblMostraQ.AutoSize = true;
            this.lblMostraQ.Location = new System.Drawing.Point(121, 70);
            this.lblMostraQ.Name = "lblMostraQ";
            this.lblMostraQ.Size = new System.Drawing.Size(0, 20);
            this.lblMostraQ.TabIndex = 17;
            // 
            // lblMostraV
            // 
            this.lblMostraV.AutoSize = true;
            this.lblMostraV.Location = new System.Drawing.Point(69, 108);
            this.lblMostraV.Name = "lblMostraV";
            this.lblMostraV.Size = new System.Drawing.Size(0, 20);
            this.lblMostraV.TabIndex = 18;
            // 
            // lblMostraT
            // 
            this.lblMostraT.AutoSize = true;
            this.lblMostraT.Location = new System.Drawing.Point(297, 70);
            this.lblMostraT.Name = "lblMostraT";
            this.lblMostraT.Size = new System.Drawing.Size(0, 20);
            this.lblMostraT.TabIndex = 19;
            // 
            // lblMostraDE
            // 
            this.lblMostraDE.AutoSize = true;
            this.lblMostraDE.Location = new System.Drawing.Point(579, 70);
            this.lblMostraDE.Name = "lblMostraDE";
            this.lblMostraDE.Size = new System.Drawing.Size(0, 20);
            this.lblMostraDE.TabIndex = 20;
            // 
            // lblMostraDS
            // 
            this.lblMostraDS.AutoSize = true;
            this.lblMostraDS.Location = new System.Drawing.Point(561, 108);
            this.lblMostraDS.Name = "lblMostraDS";
            this.lblMostraDS.Size = new System.Drawing.Size(0, 20);
            this.lblMostraDS.TabIndex = 21;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.gpbMostraProdutos);
            this.Controls.Add(this.gpbCadastroProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.gpbCadastroProdutos.ResumeLayout(false);
            this.gpbCadastroProdutos.PerformLayout();
            this.gpbMostraProdutos.ResumeLayout(false);
            this.gpbMostraProdutos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.GroupBox gpbCadastroProdutos;
        private System.Windows.Forms.GroupBox gpbMostraProdutos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblMostraCodigo;
        private System.Windows.Forms.Label lblMostraDataEntrada;
        private System.Windows.Forms.Label lblMostraDescricao;
        private System.Windows.Forms.Label lblMostraDataSaida;
        private System.Windows.Forms.Label lblMostraValor;
        private System.Windows.Forms.Label lblMostraQuantidade;
        private System.Windows.Forms.Label lblMostraTotal;
        private System.Windows.Forms.DateTimePicker dtpDataSaida;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblMostraC;
        private System.Windows.Forms.Label lblMostraDS;
        private System.Windows.Forms.Label lblMostraDE;
        private System.Windows.Forms.Label lblMostraT;
        private System.Windows.Forms.Label lblMostraV;
        private System.Windows.Forms.Label lblMostraQ;
        private System.Windows.Forms.Label lblMostraD;
    }
}