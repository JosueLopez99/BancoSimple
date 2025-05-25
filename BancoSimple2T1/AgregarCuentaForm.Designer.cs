namespace BancoSimple2T1
{
    partial class AgregarCuentaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancelar = new Button();
            btnAceptar = new Button();
            txtSaldo = new TextBox();
            label1 = new Label();
            txtNumeroCuenta = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Cyan;
            btnCancelar.Location = new Point(267, 125);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 36);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Cyan;
            btnAceptar.Location = new Point(60, 125);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(106, 36);
            btnAceptar.TabIndex = 30;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(236, 69);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(125, 27);
            txtSaldo.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 69);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 28;
            label1.Text = "Saldo:";
            // 
            // txtNumeroCuenta
            // 
            txtNumeroCuenta.Location = new Point(236, 23);
            txtNumeroCuenta.Name = "txtNumeroCuenta";
            txtNumeroCuenta.Size = new Size(125, 27);
            txtNumeroCuenta.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 23);
            label2.Name = "label2";
            label2.Size = new Size(146, 25);
            label2.TabIndex = 26;
            label2.Text = "NumeroCuenta:";
            // 
            // AgregarCuentaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(453, 185);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtSaldo);
            Controls.Add(label1);
            Controls.Add(txtNumeroCuenta);
            Controls.Add(label2);
            Name = "AgregarCuentaForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtSaldo;
        private Label label1;
        private TextBox txtNumeroCuenta;
        private Label label2;
    }
}