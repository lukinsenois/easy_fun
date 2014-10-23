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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;


            grbLogin.Left = (this.ClientSize.Width - grbLogin.Width) / 2;
            grbLogin.Top = (this.ClientSize.Height - grbLogin.Height) / 2;
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtSenha.Text == "admin")
            {
                this.Hide();

                frmCadPulseira y = new frmCadPulseira();
                y.Show();
            }

            else if (txtUsuario.Text == "caixa" && txtSenha.Text == "caixa")
            {
                this.Hide();

                frmCaixa x = new frmCaixa();
                x.Show();
            }

            else if (txtUsuario.Text == "venda" && txtSenha.Text == "venda")
            {
                this.Hide();

                frmCaixaVenda z = new frmCaixaVenda();
                z.Show();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
