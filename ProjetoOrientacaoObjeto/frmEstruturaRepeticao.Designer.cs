namespace ProjetoOrientacaoObjeto
{
    partial class frmEstruturaRepeticao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstruturaRepeticao));
            this.cbbEstados = new System.Windows.Forms.ComboBox();
            this.ltbListaEstados = new System.Windows.Forms.ListBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblListaEstados = new System.Windows.Forms.Label();
            this.btnCarregaEstado = new System.Windows.Forms.Button();
            this.btnCarregaListaEstados = new System.Windows.Forms.Button();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.btnInserirEstado = new System.Windows.Forms.Button();
            this.txtCadastro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbEstados
            // 
            this.cbbEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEstados.FormattingEnabled = true;
            this.cbbEstados.Location = new System.Drawing.Point(47, 59);
            this.cbbEstados.Name = "cbbEstados";
            this.cbbEstados.Size = new System.Drawing.Size(163, 28);
            this.cbbEstados.TabIndex = 0;
            // 
            // ltbListaEstados
            // 
            this.ltbListaEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbListaEstados.FormattingEnabled = true;
            this.ltbListaEstados.ItemHeight = 20;
            this.ltbListaEstados.Location = new System.Drawing.Point(279, 59);
            this.ltbListaEstados.Name = "ltbListaEstados";
            this.ltbListaEstados.Size = new System.Drawing.Size(163, 284);
            this.ltbListaEstados.TabIndex = 1;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(43, 36);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado";
            // 
            // lblListaEstados
            // 
            this.lblListaEstados.AutoSize = true;
            this.lblListaEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaEstados.Location = new System.Drawing.Point(275, 36);
            this.lblListaEstados.Name = "lblListaEstados";
            this.lblListaEstados.Size = new System.Drawing.Size(128, 20);
            this.lblListaEstados.TabIndex = 3;
            this.lblListaEstados.Text = "Lista de Estados";
            // 
            // btnCarregaEstado
            // 
            this.btnCarregaEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaEstado.Location = new System.Drawing.Point(47, 364);
            this.btnCarregaEstado.Name = "btnCarregaEstado";
            this.btnCarregaEstado.Size = new System.Drawing.Size(163, 50);
            this.btnCarregaEstado.TabIndex = 4;
            this.btnCarregaEstado.Text = "Carrega Estados";
            this.btnCarregaEstado.UseVisualStyleBackColor = true;
            this.btnCarregaEstado.Click += new System.EventHandler(this.btnCarregaEstado_Click);
            // 
            // btnCarregaListaEstados
            // 
            this.btnCarregaListaEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaListaEstados.Location = new System.Drawing.Point(279, 364);
            this.btnCarregaListaEstados.Name = "btnCarregaListaEstados";
            this.btnCarregaListaEstados.Size = new System.Drawing.Size(163, 50);
            this.btnCarregaListaEstados.TabIndex = 5;
            this.btnCarregaListaEstados.Text = "Carrega Lista de Estados";
            this.btnCarregaListaEstados.UseVisualStyleBackColor = true;
            this.btnCarregaListaEstados.Click += new System.EventHandler(this.btnCarregaListaEstados_Click);
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.Location = new System.Drawing.Point(43, 132);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(118, 20);
            this.lblCadastro.TabIndex = 6;
            this.lblCadastro.Text = "Digite o Estado";
            // 
            // btnInserirEstado
            // 
            this.btnInserirEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirEstado.Location = new System.Drawing.Point(47, 187);
            this.btnInserirEstado.Name = "btnInserirEstado";
            this.btnInserirEstado.Size = new System.Drawing.Size(163, 50);
            this.btnInserirEstado.TabIndex = 7;
            this.btnInserirEstado.Text = "Inserir Estado";
            this.btnInserirEstado.UseVisualStyleBackColor = true;
            this.btnInserirEstado.Click += new System.EventHandler(this.btnInserirEstado_Click);
            // 
            // txtCadastro
            // 
            this.txtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastro.Location = new System.Drawing.Point(47, 155);
            this.txtCadastro.MaxLength = 30;
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.Size = new System.Drawing.Size(163, 26);
            this.txtCadastro.TabIndex = 8;
            this.txtCadastro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCadastro_KeyDown);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(47, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Limpar Estado";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(130, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 50);
            this.button2.TabIndex = 10;
            this.button2.Text = "Limpar Lista";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmEstruturaRepeticao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 437);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCadastro);
            this.Controls.Add(this.btnInserirEstado);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.btnCarregaListaEstados);
            this.Controls.Add(this.btnCarregaEstado);
            this.Controls.Add(this.lblListaEstados);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.ltbListaEstados);
            this.Controls.Add(this.cbbEstados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmEstruturaRepeticao";
            this.Text = "frmEstruturaRepeticao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbEstados;
        private System.Windows.Forms.ListBox ltbListaEstados;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblListaEstados;
        private System.Windows.Forms.Button btnCarregaEstado;
        private System.Windows.Forms.Button btnCarregaListaEstados;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Button btnInserirEstado;
        private System.Windows.Forms.TextBox txtCadastro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}