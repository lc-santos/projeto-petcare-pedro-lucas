namespace APPfuncionario
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.gpbdados = new System.Windows.Forms.GroupBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblrg = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.gpbdados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbdados
            // 
            this.gpbdados.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gpbdados.Controls.Add(this.txtcodigo);
            this.gpbdados.Controls.Add(this.txtidade);
            this.gpbdados.Controls.Add(this.pictureBox1);
            this.gpbdados.Controls.Add(this.txtname);
            this.gpbdados.Controls.Add(this.lblrg);
            this.gpbdados.Controls.Add(this.lblcpf);
            this.gpbdados.Controls.Add(this.lblname);
            this.gpbdados.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbdados.Location = new System.Drawing.Point(51, 47);
            this.gpbdados.Name = "gpbdados";
            this.gpbdados.Size = new System.Drawing.Size(695, 263);
            this.gpbdados.TabIndex = 0;
            this.gpbdados.TabStop = false;
            this.gpbdados.Text = "Dados do cliente";
            
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(207, 149);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 26);
            this.txtcodigo.TabIndex = 8;
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(207, 117);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(100, 26);
            this.txtidade.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(410, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(207, 81);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 26);
            this.txtname.TabIndex = 3;
            // 
            // lblrg
            // 
            this.lblrg.AutoSize = true;
            this.lblrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrg.Location = new System.Drawing.Point(129, 155);
            this.lblrg.Name = "lblrg";
            this.lblrg.Size = new System.Drawing.Size(65, 20);
            this.lblrg.TabIndex = 2;
            this.lblrg.Text = "Código";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.Location = new System.Drawing.Point(139, 121);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(55, 20);
            this.lblcpf.TabIndex = 1;
            this.lblcpf.Text = "Idade";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(139, 84);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(55, 20);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Nome";
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(123, 391);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(134, 40);
            this.btnnew.TabIndex = 19;
            this.btnnew.Text = "Novo";
            this.btnnew.UseVisualStyleBackColor = true;
       
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(335, 391);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(134, 40);
            this.btnclear.TabIndex = 20;
            this.btnclear.Text = "Limpar";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(544, 391);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(134, 40);
            this.btnback.TabIndex = 21;
            this.btnback.Text = "Voltar";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.gpbdados);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.gpbdados.ResumeLayout(false);
            this.gpbdados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbdados;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblrg;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtidade;
    }
}