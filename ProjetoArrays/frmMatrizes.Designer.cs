namespace ProjetoArrays
{
    partial class frmMatrizes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatrizes));
            this.gpbLista = new System.Windows.Forms.GroupBox();
            this.txtLinha = new System.Windows.Forms.TextBox();
            this.txtColuna = new System.Windows.Forms.TextBox();
            this.lblLinha = new System.Windows.Forms.Label();
            this.lblColuna = new System.Windows.Forms.Label();
            this.ltbListaMatriz = new System.Windows.Forms.ListBox();
            this.btnCarrega = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbLista
            // 
            this.gpbLista.Controls.Add(this.lblColuna);
            this.gpbLista.Controls.Add(this.lblLinha);
            this.gpbLista.Controls.Add(this.txtColuna);
            this.gpbLista.Controls.Add(this.txtLinha);
            this.gpbLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbLista.Location = new System.Drawing.Point(16, 26);
            this.gpbLista.Name = "gpbLista";
            this.gpbLista.Size = new System.Drawing.Size(507, 344);
            this.gpbLista.TabIndex = 0;
            this.gpbLista.TabStop = false;
            this.gpbLista.Text = "Lista Matriz";
            // 
            // txtLinha
            // 
            this.txtLinha.Location = new System.Drawing.Point(75, 41);
            this.txtLinha.MaxLength = 10;
            this.txtLinha.Name = "txtLinha";
            this.txtLinha.Size = new System.Drawing.Size(89, 26);
            this.txtLinha.TabIndex = 0;
            // 
            // txtColuna
            // 
            this.txtColuna.Location = new System.Drawing.Point(75, 94);
            this.txtColuna.MaxLength = 10;
            this.txtColuna.Name = "txtColuna";
            this.txtColuna.Size = new System.Drawing.Size(89, 26);
            this.txtColuna.TabIndex = 1;
            // 
            // lblLinha
            // 
            this.lblLinha.AutoSize = true;
            this.lblLinha.Location = new System.Drawing.Point(21, 44);
            this.lblLinha.Name = "lblLinha";
            this.lblLinha.Size = new System.Drawing.Size(48, 20);
            this.lblLinha.TabIndex = 2;
            this.lblLinha.Text = "Linha";
            // 
            // lblColuna
            // 
            this.lblColuna.AutoSize = true;
            this.lblColuna.Location = new System.Drawing.Point(10, 97);
            this.lblColuna.Name = "lblColuna";
            this.lblColuna.Size = new System.Drawing.Size(59, 20);
            this.lblColuna.TabIndex = 3;
            this.lblColuna.Text = "Coluna";
            // 
            // ltbListaMatriz
            // 
            this.ltbListaMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbListaMatriz.FormattingEnabled = true;
            this.ltbListaMatriz.ItemHeight = 20;
            this.ltbListaMatriz.Location = new System.Drawing.Point(540, 26);
            this.ltbListaMatriz.Name = "ltbListaMatriz";
            this.ltbListaMatriz.Size = new System.Drawing.Size(248, 344);
            this.ltbListaMatriz.TabIndex = 1;
            // 
            // btnCarrega
            // 
            this.btnCarrega.BackColor = System.Drawing.Color.SpringGreen;
            this.btnCarrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrega.Location = new System.Drawing.Point(16, 395);
            this.btnCarrega.Name = "btnCarrega";
            this.btnCarrega.Size = new System.Drawing.Size(142, 43);
            this.btnCarrega.TabIndex = 2;
            this.btnCarrega.Text = "Carrega Matriz";
            this.btnCarrega.UseVisualStyleBackColor = false;
            this.btnCarrega.Click += new System.EventHandler(this.btnCarrega_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(209, 395);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(142, 43);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.LightCoral;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(402, 395);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(142, 43);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmMatrizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCarrega);
            this.Controls.Add(this.ltbListaMatriz);
            this.Controls.Add(this.gpbLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMatrizes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMatrizes";
            this.gpbLista.ResumeLayout(false);
            this.gpbLista.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbLista;
        private System.Windows.Forms.TextBox txtColuna;
        private System.Windows.Forms.TextBox txtLinha;
        private System.Windows.Forms.Label lblColuna;
        private System.Windows.Forms.Label lblLinha;
        private System.Windows.Forms.ListBox ltbListaMatriz;
        private System.Windows.Forms.Button btnCarrega;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}