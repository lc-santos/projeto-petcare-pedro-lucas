using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPfuncionario
{
    public partial class FrmCadastroAnimal : Form
    {
        public FrmCadastroAnimal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtpeso.Clear();
            txtnome.Clear();
            txtdetalhe.Clear();
            cbbcor.SelectedIndex = -1;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal abrir = new FrmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }
    }
}
