namespace Vista
{
    partial class FormProveedor
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
            groupBox1 = new GroupBox();
            txtDireccion = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label3 = new Label();
            btnAceptar = new Button();
            txtCuit = new TextBox();
            txtRazonSocial = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            lblLeyenda = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnAceptar);
            groupBox1.Controls.Add(txtCuit);
            groupBox1.Controls.Add(txtRazonSocial);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(295, 233);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Proveedor";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(118, 145);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.MaxLength = 150;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(170, 27);
            txtDireccion.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 150);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 9;
            label4.Text = "Direccion";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(118, 107);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.MaxLength = 150;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(172, 27);
            txtTelefono.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 112);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 7;
            label3.Text = "Telefono";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(9, 188);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 31);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(118, 29);
            txtCuit.Margin = new Padding(3, 4, 3, 4);
            txtCuit.MaxLength = 15;
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(170, 27);
            txtCuit.TabIndex = 2;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(118, 68);
            txtRazonSocial.Margin = new Padding(3, 4, 3, 4);
            txtRazonSocial.MaxLength = 150;
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(172, 27);
            txtRazonSocial.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 34);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 4;
            label1.Text = "Cuit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 73);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 5;
            label2.Text = "Razon Social";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(204, 188);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblLeyenda
            // 
            lblLeyenda.AutoSize = true;
            lblLeyenda.Location = new Point(12, 250);
            lblLeyenda.Name = "lblLeyenda";
            lblLeyenda.Size = new Size(50, 20);
            lblLeyenda.TabIndex = 8;
            lblLeyenda.Text = "label8";
            lblLeyenda.Visible = false;
            // 
            // FormProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 274);
            Controls.Add(lblLeyenda);
            Controls.Add(groupBox1);
            Name = "FormProveedor";
            Text = "FormProveedor";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDireccion;
        private Label label7;
        private ComboBox cBoxCategorias;
        private TextBox txtCantidadMinima;
        private Label label6;
        private TextBox txtCantidadActual;
        private Label label5;
        private TextBox txtPrecioVenta;
        private Label label4;
        private TextBox txtTelefono;
        private TextBox txtPrecioCompra;
        private Label label3;
        private Button btnAceptar;
        private TextBox txtCuit;
        private TextBox txtCodigo;
        private TextBox txtRazonSocial;
        private Label label1;
        private Label label2;
        private Button btnCancelar;
        private Label lblLeyenda;
    }
}