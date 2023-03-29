using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2._28._3._2023
{
    public partial class FormPrincipal : Form
    {
        FormLogin MainLogin = new FormLogin();
        FormVenta FormVentas = new FormVenta();
        FormAdmin Admin = new FormAdmin();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainLogin.ShowDialog();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            FormVentas.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            MainLogin.ShowDialog();
            Admin.ShowDialog();
        }
    }
}
