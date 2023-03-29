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
    public partial class FormVenta : Form
    {
        FormFactura Factura = new FormFactura();
        public FormVenta()
        {
            InitializeComponent();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            Factura.ShowDialog();
        }
    }
}
