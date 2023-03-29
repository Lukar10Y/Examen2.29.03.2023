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
    public partial class FormAdmin : Form
    {
        FormModificarProducto OpcionesModificar = new FormModificarProducto(); 
        public FormAdmin()
        {
            InitializeComponent();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            OpcionesModificar.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
