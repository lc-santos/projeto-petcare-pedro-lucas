namespace APPfuncionario
{
    partial class FrmMenuPrincipal
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
            this.btncliente = new System.Windows.Forms.Button();
            this.btncadastroanimal = new System.Windows.Forms.Button();
            this.btnfornecedor = new System.Windows.Forms.Button();
            this.btnnotas = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncliente
            // 
            this.btncliente.Location = new System.Drawing.Point(284, 51);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(205, 47);
            this.btncliente.TabIndex = 0;
            this.btncliente.Text = "Cadastro Cliente";
            this.btncliente.UseVisualStyleBackColor = true;
            this.btncliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncadastroanimal
            // 
            this.btncadastroanimal.Location = new System.Drawing.Point(284, 131);
            this.btncadastroanimal.Name = "btncadastroanimal";
            this.btncadastroanimal.Size = new System.Drawing.Size(205, 47);
            this.btncadastroanimal.TabIndex = 1;
            this.btncadastroanimal.Text = "Cadastro Animal";
            this.btncadastroanimal.UseVisualStyleBackColor = true;
            this.btncadastroanimal.Click += new System.EventHandler(this.btncadastroanimal_Click);
            // 
            // btnfornecedor
            // 
            this.btnfornecedor.Location = new System.Drawing.Point(284, 216);
            this.btnfornecedor.Name = "btnfornecedor";
            this.btnfornecedor.Size = new System.Drawing.Size(205, 47);
            this.btnfornecedor.TabIndex = 2;
            this.btnfornecedor.Text = "Cadastro Veterinário";
            this.btnfornecedor.UseVisualStyleBackColor = true;
            this.btnfornecedor.Click += new System.EventHandler(this.btnfornecedor_Click);
            // 
            // btnnotas
            // 
            this.btnnotas.Location = new System.Drawing.Point(284, 292);
            this.btnnotas.Name = "btnnotas";
            this.btnnotas.Size = new System.Drawing.Size(205, 47);
            this.btnnotas.TabIndex = 3;
            this.btnnotas.Text = "Produtos";
            this.btnnotas.UseVisualStyleBackColor = true;
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(284, 365);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(205, 47);
            this.btnsair.TabIndex = 4;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnnotas);
            this.Controls.Add(this.btnfornecedor);
            this.Controls.Add(this.btncadastroanimal);
            this.Controls.Add(this.btncliente);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.Button btncadastroanimal;
        private System.Windows.Forms.Button btnfornecedor;
        private System.Windows.Forms.Button btnnotas;
        private System.Windows.Forms.Button btnsair;
    }
}