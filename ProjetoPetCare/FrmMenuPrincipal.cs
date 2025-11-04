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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCliente abrir = new FrmCliente();
            abrir.Show();
            this.Hide();
        }

        private void btncadastroanimal_Click(object sender, EventArgs e)
        {
            FrmCadastroAnimal abrir = new FrmCadastroAnimal();
            abrir.Show();
            this.Hide();
        }

        private void btnfornecedor_Click(object sender, EventArgs e)
        {
            FrmVeterinario abrir = new FrmVeterinario();
            abrir.Show();
            this.Hide();
        }


    }
}
