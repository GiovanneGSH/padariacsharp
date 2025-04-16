namespace ProjetoArrays
{
    partial class frmVetores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVetores));
            this.gpbNomes = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.lblInsiraNome = new System.Windows.Forms.Label();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.ltbNomes = new System.Windows.Forms.ListBox();
            this.btnCarrega = new System.Windows.Forms.Button();
            this.gpbNomes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbNomes
            // 
            this.gpbNomes.Controls.Add(this.txtNome);
            this.gpbNomes.Controls.Add(this.txtTamanho);
            this.gpbNomes.Controls.Add(this.lblInsiraNome);
            this.gpbNomes.Controls.Add(this.lblTamanho);
            this.gpbNomes.Controls.Add(this.lblNome);
            this.gpbNomes.Controls.Add(this.ltbNomes);
            this.gpbNomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbNomes.Location = new System.Drawing.Point(12, 12);
            this.gpbNomes.Name = "gpbNomes";
            this.gpbNomes.Size = new System.Drawing.Size(780, 267);
            this.gpbNomes.TabIndex = 0;
            this.gpbNomes.TabStop = false;
            this.gpbNomes.Text = "Nomes";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(28, 144);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(157, 26);
            this.txtNome.TabIndex = 7;
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(28, 63);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(94, 26);
            this.txtTamanho.TabIndex = 6;
            // 
            // lblInsiraNome
            // 
            this.lblInsiraNome.AutoSize = true;
            this.lblInsiraNome.Location = new System.Drawing.Point(24, 121);
            this.lblInsiraNome.Name = "lblInsiraNome";
            this.lblInsiraNome.Size = new System.Drawing.Size(94, 20);
            this.lblInsiraNome.TabIndex = 5;
            this.lblInsiraNome.Text = "Insira Nome";
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Location = new System.Drawing.Point(24, 40);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(76, 20);
            this.lblTamanho.TabIndex = 4;
            this.lblTamanho.Text = "Tamanho";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(425, 17);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(109, 20);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Lista de nome";
            // 
            // ltbNomes
            // 
            this.ltbNomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbNomes.FormattingEnabled = true;
            this.ltbNomes.ItemHeight = 20;
            this.ltbNomes.Location = new System.Drawing.Point(429, 40);
            this.ltbNomes.Name = "ltbNomes";
            this.ltbNomes.Size = new System.Drawing.Size(345, 204);
            this.ltbNomes.TabIndex = 2;
            // 
            // btnCarrega
            // 
            this.btnCarrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrega.Location = new System.Drawing.Point(12, 285);
            this.btnCarrega.Name = "btnCarrega";
            this.btnCarrega.Size = new System.Drawing.Size(185, 67);
            this.btnCarrega.TabIndex = 1;
            this.btnCarrega.Text = "Carrega";
            this.btnCarrega.UseVisualStyleBackColor = true;
            this.btnCarrega.Click += new System.EventHandler(this.btnCarrega_Click);
            // 
            // frmVetores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.btnCarrega);
            this.Controls.Add(this.gpbNomes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVetores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vetores";
            this.gpbNomes.ResumeLayout(false);
            this.gpbNomes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbNomes;
        private System.Windows.Forms.Button btnCarrega;
        private System.Windows.Forms.ListBox ltbNomes;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Label lblInsiraNome;
        private System.Windows.Forms.Label lblTamanho;
    }
}