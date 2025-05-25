namespace BancoSimple2T1
{
    partial class Banco
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btnDesactivarCuenta = new Button();
            btnVerTransferencia = new Button();
            btnTransferencia = new Button();
            btnAgregarCuenta = new Button();
            dataCuentas = new DataGridView();
            btnAgregar = new Button();
            dataClientes = new DataGridView();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataCuentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 9);
            label1.Name = "label1";
            label1.Size = new Size(154, 54);
            label1.TabIndex = 4;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(698, 9);
            label2.Name = "label2";
            label2.Size = new Size(156, 54);
            label2.TabIndex = 11;
            label2.Text = "Cuenta";
            // 
            // btnDesactivarCuenta
            // 
            btnDesactivarCuenta.BackColor = Color.FromArgb(128, 255, 255);
            btnDesactivarCuenta.Location = new Point(712, 497);
            btnDesactivarCuenta.Name = "btnDesactivarCuenta";
            btnDesactivarCuenta.Size = new Size(142, 51);
            btnDesactivarCuenta.TabIndex = 22;
            btnDesactivarCuenta.Text = "DesactivarCuentas";
            btnDesactivarCuenta.UseVisualStyleBackColor = false;
            // 
            // btnVerTransferencia
            // 
            btnVerTransferencia.BackColor = Color.FromArgb(128, 255, 255);
            btnVerTransferencia.Location = new Point(1000, 216);
            btnVerTransferencia.Name = "btnVerTransferencia";
            btnVerTransferencia.Size = new Size(127, 51);
            btnVerTransferencia.TabIndex = 21;
            btnVerTransferencia.Text = "Ver Transferencias";
            btnVerTransferencia.UseVisualStyleBackColor = false;
            // 
            // btnTransferencia
            // 
            btnTransferencia.BackColor = Color.FromArgb(128, 255, 255);
            btnTransferencia.Location = new Point(911, 497);
            btnTransferencia.Name = "btnTransferencia";
            btnTransferencia.Size = new Size(127, 51);
            btnTransferencia.TabIndex = 20;
            btnTransferencia.Text = "Transferencia";
            btnTransferencia.UseVisualStyleBackColor = false;
            // 
            // btnAgregarCuenta
            // 
            btnAgregarCuenta.BackColor = Color.FromArgb(128, 255, 255);
            btnAgregarCuenta.Location = new Point(520, 497);
            btnAgregarCuenta.Name = "btnAgregarCuenta";
            btnAgregarCuenta.Size = new Size(127, 51);
            btnAgregarCuenta.TabIndex = 19;
            btnAgregarCuenta.Text = "AgregarCuenta";
            btnAgregarCuenta.UseVisualStyleBackColor = false;
            // 
            // dataCuentas
            // 
            dataCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataCuentas.Location = new Point(551, 113);
            dataCuentas.Name = "dataCuentas";
            dataCuentas.ReadOnly = true;
            dataCuentas.RowHeadersWidth = 51;
            dataCuentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataCuentas.Size = new Size(432, 359);
            dataCuentas.TabIndex = 18;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(128, 255, 255);
            btnAgregar.Location = new Point(174, 497);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 51);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // dataClientes
            // 
            dataClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataClientes.Location = new Point(56, 113);
            dataClientes.Name = "dataClientes";
            dataClientes.ReadOnly = true;
            dataClientes.RowHeadersWidth = 51;
            dataClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataClientes.Size = new Size(381, 359);
            dataClientes.TabIndex = 16;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(128, 255, 255);
            btnBuscar.Location = new Point(80, 65);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(92, 29);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(198, 66);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(152, 27);
            txtBuscar.TabIndex = 14;
            // 
            // Banco
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1161, 591);
            Controls.Add(btnDesactivarCuenta);
            Controls.Add(btnVerTransferencia);
            Controls.Add(btnTransferencia);
            Controls.Add(btnAgregarCuenta);
            Controls.Add(dataCuentas);
            Controls.Add(btnAgregar);
            Controls.Add(dataClientes);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Banco";
            Text = "Banco";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataCuentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button btnDesactivarCuenta;
        private Button btnVerTransferencia;
        private Button btnTransferencia;
        private Button btnAgregarCuenta;
        private DataGridView dataCuentas;
        private Button btnAgregar;
        private DataGridView dataClientes;
        private Button btnBuscar;
        private TextBox txtBuscar;
    }
}
