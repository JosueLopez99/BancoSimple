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
    public partial class AgregarCuentaForm : Form
    {
        public CuentaService cuentaservice;
        private int _clienteId;
        public AgregarCuentaForm(int clienteId)
        {
            InitializeComponent();
            cuentaservice = new CuentaService();
            _clienteId = clienteId;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumeroCuenta.Text) || string.IsNullOrWhiteSpace(txtSaldo.Text))
            {
                MessageBox.Show("Algun campo esta vacio rellenelo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cuentaservice.AgregarCuenta(txtNumeroCuenta.Text, decimal.Parse(txtSaldo.Text), _clienteid, activa: true);
                MessageBox.Show("La cuenta fue agregada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
