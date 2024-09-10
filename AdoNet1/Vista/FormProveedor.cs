using Controladora;
using Modelo_V2.Objetos;
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
    public partial class FormProveedor : Form
    {
        public FormProveedor()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var proveedor = ValidarYCrear();
            if (proveedor != null)
            {
                if (ControladoraProveedor.Instance.AgregarProveedor(proveedor))
                {
                    lblLeyenda.Text = "Proveedor cargado con éxito";
                }
                else
                {
                    lblLeyenda.Text = "null";
                }
                
            }
            else
            {
                lblLeyenda.Text = "Debe llenar todos los campos!";
            }
            lblLeyenda.Visible = true;
        }

        private Proveedor ValidarYCrear()
        {
            if (txtCuit.Text != "" && txtRazonSocial.Text != "" && txtTelefono.Text != "" && txtDireccion.Text != "")
            {
                Proveedor proveedor = new Proveedor()
                {
                    Cuit = int.Parse(txtCuit.Text),
                    RazonSocial = txtRazonSocial.Text,
                    Telefono = int.Parse(txtTelefono.Text),
                    Direccion = txtDireccion.Text,
                };
                return proveedor;
            }
            else
            {
                return null;
            }
        }
    }
}
