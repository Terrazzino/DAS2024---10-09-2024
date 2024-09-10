using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var formProveedor = new FormProveedor();
            formProveedor.ShowDialog();
            ActualizarVista();
        }

        private void ActualizarVista()
        {
            var list = Controladora.ControladoraProveedor.Instance.RecuperarProveedores();
            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = list;
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            //dgvProveedores.AutoGenerateColumns = false;
            ActualizarVista();
        }
    }
}
