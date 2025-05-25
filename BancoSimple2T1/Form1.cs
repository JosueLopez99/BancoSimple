using BancoSimple2T1.Data;
using BancoSimple2T1.Models;
using Microsoft.EntityFrameworkCore;
namespace BancoSimple2T1
    
{
    public partial class Banco : Form
    {
        public ClienteService clienteservice;
        public CuentaService cuentaservice;
        private BancoSimpleContext _db = new BancoSimpleContext();
        public Banco()
        {
            InitializeComponent();
            clienteservice = new ClienteService();
            cuentaservice = new CuentaService();
            CargarInfo();

        }

        private void CargarInfo()
        {
            dataClientes.DataSource = clienteservice.ObtenerClientes();
            dataCuentas.DataSource = cuentaservice.CuentasActivas();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            var agregar = new AgregarClienteForm();
            if (agregar.ShowDialog() == DialogResult.OK)
            {
                CargarInfo();
            }
        }

        private void btnAgregarCuenta_Click(object sender, EventArgs e)
        {
            if (dataClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cuenta primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int clienteid = (int)dataClientes.SelectedRows[0].Cells["ClienteId"].Value;
                var agregar = new AgregarCuentaForm(clienteid);
                if (agregar.ShowDialog() == DialogResult.OK)
                {
                    CargarInfo();
                }

            }
        }
        //Transacciones
        private void RealizarTransaccion(int cuentaOrigenId, int cuentaDestinoId, decimal monto)
        {
            //implementacion
            //Nivel de aislamiento
            using var transferencia = _db.Database.BeginTransaction(System.Data.IsolationLevel.Serializable);
            try
            {
                //Filtro y ordenacion
                var cuentaOrigen = _db.Cuenta.FirstOrDefault(c => c.CuentaId == cuentaOrigenId);
                var cuentaDestino = _db.Cuenta.FirstOrDefault(c => c.CuentaId == cuentaDestinoId);

                if (cuentaOrigen == null || cuentaDestino == null)
                    throw new Exception("Una o ambas cuentas no existen");

                if (!cuentaOrigen.Activa || !cuentaDestino.Activa)
                    throw new Exception("Una o ambas cuentas están inactivas");
                if (cuentaOrigen.Saldo < monto)
                    throw new Exception("Saldo Insuficiente en la cuenta Origen");

                cuentaOrigen.Saldo -= monto;
                cuentaDestino.Saldo += monto;

                //Registrar la transaccion
                _db.Transacciones.Add(new Transaccion
                {
                    Monto = monto,
                    Fecha = DateTime.Now,
                    Descripcion = "Transferencia entre cuentas",
                    CuentaOrigenId = cuentaOrigenId,
                    CuentaDestinoId = cuentaDestinoId
                });
                _db.SaveChanges();
                //Transaccion completada
                transferencia.Commit();
                MessageBox.Show("Transferencia realizada");
                CargarInfo();


            }
            catch (Exception ex)
            {
                transferencia.Rollback();

                var inner = ex.InnerException?.Message ?? "No hay InnerException";
                MessageBox.Show($"Error al guardar:\n{ex.Message}\n\nDetalle:\n{inner}");
            }

        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            if (dataCuentas.SelectedRows.Count != 2)
            {
                MessageBox.Show("Seleccione exactamente 2 cuentas");
                return;
            }
            var cuentaOrigenId = (int)dataCuentas.SelectedRows[1].Cells["CuentaId"].Value;
            var cuentaDestinoId = (int)dataCuentas.SelectedRows[0].Cells["CuentaId"].Value;

            var form = new TransaccionesForms(cuentaOrigenId, cuentaDestinoId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                RealizarTransaccion(cuentaOrigenId, cuentaDestinoId, form.Monto);
            }

        }

        private void btnBuscarCleinte_Click(object sender, EventArgs e)
        {
            //Busqueda de patrones con like
            var patron = txtBuscar.Text;
            var cliente = _db.Cliente.Where(c => EF.Functions.Like(c.Nombre, $"%{patron}%")).ToList();

            dataClientes.DataSource = cliente;
        }

        private void btnVerTrans_Click(object sender, EventArgs e)
        {
            var form = new VerTransferenciaForms();
            form.ShowDialog();
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (dataCuentas.SelectedRows.Count != 1)
            {
                MessageBox.Show("Selecciones solo una cuenta exactamente");
                return;
            }
            else
            {
                var cuentaId = (int)dataCuentas.SelectedRows[0].Cells["CuentaId"].Value;
                var cuenta = _db.Cuenta.Find(cuentaId);
                cuenta.Activa = false;
                _db.SaveChanges();
                CargarInfo();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
