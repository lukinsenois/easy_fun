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
    public partial class frmCaixaVenda : Form
    {
        public frmCaixaVenda()
        {
            InitializeComponent();
        }

        private void frmCaixaVenda_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin x = new frmLogin();
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVendas x = new frmVendas();
            x.Show();
        }
    }
}
