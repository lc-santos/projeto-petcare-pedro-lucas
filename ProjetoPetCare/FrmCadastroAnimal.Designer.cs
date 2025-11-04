namespace APPfuncionario
{
    partial class FrmCadastroAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroAnimal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnback = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.lblpeso = new System.Windows.Forms.Label();
            this.lblcor = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdetalhe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbcor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(414, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(56, 340);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(134, 40);
            this.btnback.TabIndex = 6;
            this.btnback.Text = "Voltar";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(246, 340);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(134, 40);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Limpar";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Dados animal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(54, 94);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(28, 20);
            this.lblid.TabIndex = 25;
            this.lblid.Text = "ID";
            this.lblid.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(142, 94);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(164, 20);
            this.txtid.TabIndex = 1;
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(142, 136);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(164, 20);
            this.txtpeso.TabIndex = 2;
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpeso.Location = new System.Drawing.Point(54, 136);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(49, 20);
            this.lblpeso.TabIndex = 27;
            this.lblpeso.Text = "Peso";
            this.lblpeso.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblcor
            // 
            this.lblcor.AutoSize = true;
            this.lblcor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcor.Location = new System.Drawing.Point(54, 180);
            this.lblcor.Name = "lblcor";
            this.lblcor.Size = new System.Drawing.Size(37, 20);
            this.lblcor.TabIndex = 29;
            this.lblcor.Text = "Cor";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(142, 225);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(164, 20);
            this.txtnome.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nome";
            // 
            // txtdetalhe
            // 
            this.txtdetalhe.Location = new System.Drawing.Point(142, 263);
            this.txtdetalhe.Name = "txtdetalhe";
            this.txtdetalhe.Size = new System.Drawing.Size(164, 20);
            this.txtdetalhe.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Detalhe";
            // 
            // cbbcor
            // 
            this.cbbcor.FormattingEnabled = true;
            this.cbbcor.Items.AddRange(new object[] {
            "branco",
            "preto",
            "amarelo",
            "cinza",
            "caramelo",
            "pintado",
            "malhado",
            "rajado",
            "marrom",
            "outro"});
            this.cbbcor.Location = new System.Drawing.Point(142, 179);
            this.cbbcor.Name = "cbbcor";
            this.cbbcor.Size = new System.Drawing.Size(164, 21);
            this.cbbcor.TabIndex = 3;
            // 
            // FrmCadastroAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbcor);
            this.Controls.Add(this.txtdetalhe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblcor);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.lblpeso);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmCadastroAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Animal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.Label lblcor;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdetalhe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbcor;
    }
}