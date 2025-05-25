using BancoSimple2T1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoSimple2T1
{
    public partial class AgregarClienteForm : Form
    {
        public ClienteService clienteservice;
        public AgregarClienteForm()
        {
            InitializeComponent();
            clienteservice = new ClienteService();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtIdentificacion.Text))
            {
                MessageBox.Show("Algun Campo esta vacio rellenelo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                clienteservice.AgregarCliente(txtNombre.Text, txtIdentificacion.Text);
                MessageBox.Show("El cliente fue agregado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
