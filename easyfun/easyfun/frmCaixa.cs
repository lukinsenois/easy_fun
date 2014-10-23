using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace easyfun
{
    public partial class frmCaixa : Form
    {
        public frmCaixa()
        {
            InitializeComponent();
        }

        private void frmCaixa_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
           
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            this.Close();

            frmCadCliente x = new frmCadCliente();
            x.ShowDialog();
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            frmCheckIN x = new frmCheckIN();
            x.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin x = new frmLogin();
            x.Show();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            this.Close();

            frmCheckOUT x = new frmCheckOUT();
            x.Show();
        }
    }
}
