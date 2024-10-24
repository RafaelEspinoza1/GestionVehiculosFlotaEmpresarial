namespace Gestion_de_Vehiculos_para_una_Flota_Empresarial
{
    partial class Form1
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
            lblGestionDeVehiculos = new Label();
            lblTipo = new Label();
            lblMarca = new Label();
            lblModelo = new Label();
            cboTipoDeVehiculo = new ComboBox();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtCapacidad = new TextBox();
            lblCapacidad = new Label();
            dataGridViewVehiculos = new DataGridView();
            btnAgregar = new Button();
            btnMover = new Button();
            btnDetener = new Button();
            btnCargarBateria = new Button();
            btnIniciar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculos).BeginInit();
            SuspendLayout();
            // 
            // lblGestionDeVehiculos
            // 
            lblGestionDeVehiculos.AutoSize = true;
            lblGestionDeVehiculos.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionDeVehiculos.Location = new Point(285, 20);
            lblGestionDeVehiculos.Name = "lblGestionDeVehiculos";
            lblGestionDeVehiculos.Size = new Size(172, 21);
            lblGestionDeVehiculos.TabIndex = 0;
            lblGestionDeVehiculos.Text = "Gestión de vehiculos";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(49, 76);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(97, 15);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo de vehiculo:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(103, 117);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(43, 15);
            lblMarca.TabIndex = 2;
            lblMarca.Text = "Marca:";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(95, 151);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(51, 15);
            lblModelo.TabIndex = 3;
            lblModelo.Text = "Modelo:";
            // 
            // cboTipoDeVehiculo
            // 
            cboTipoDeVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDeVehiculo.FormattingEnabled = true;
            cboTipoDeVehiculo.Items.AddRange(new object[] { "Auto", "Camion", "Motocicleta", "Vehiculo Electrico" });
            cboTipoDeVehiculo.Location = new Point(177, 76);
            cboTipoDeVehiculo.Name = "cboTipoDeVehiculo";
            cboTipoDeVehiculo.Size = new Size(121, 23);
            cboTipoDeVehiculo.TabIndex = 4;
            cboTipoDeVehiculo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(177, 109);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(121, 23);
            txtMarca.TabIndex = 5;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(177, 143);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(121, 23);
            txtModelo.TabIndex = 6;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(177, 185);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(121, 23);
            txtCapacidad.TabIndex = 7;
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Location = new Point(12, 193);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(66, 15);
            lblCapacidad.TabIndex = 8;
            lblCapacidad.Text = "Capacidad:";
            // 
            // dataGridViewVehiculos
            // 
            dataGridViewVehiculos.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVehiculos.Location = new Point(379, 76);
            dataGridViewVehiculos.Name = "dataGridViewVehiculos";
            dataGridViewVehiculos.ReadOnly = true;
            dataGridViewVehiculos.Size = new Size(409, 150);
            dataGridViewVehiculos.TabIndex = 9;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(32, 280);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 29);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar vehiculo";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnMover
            // 
            btnMover.Location = new Point(177, 280);
            btnMover.Name = "btnMover";
            btnMover.Size = new Size(101, 29);
            btnMover.TabIndex = 11;
            btnMover.Text = "Mover vehiculo";
            btnMover.UseVisualStyleBackColor = true;
            btnMover.Click += btnMover_Click;
            // 
            // btnDetener
            // 
            btnDetener.Location = new Point(177, 335);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(113, 23);
            btnDetener.TabIndex = 12;
            btnDetener.Text = "Detener vehiculo";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // btnCargarBateria
            // 
            btnCargarBateria.Location = new Point(315, 311);
            btnCargarBateria.Name = "btnCargarBateria";
            btnCargarBateria.Size = new Size(116, 23);
            btnCargarBateria.TabIndex = 13;
            btnCargarBateria.Text = "Cargar bateria";
            btnCargarBateria.UseVisualStyleBackColor = true;
            btnCargarBateria.Click += btnCargarBateria_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(38, 335);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(108, 23);
            btnIniciar.TabIndex = 14;
            btnIniciar.Text = "Iniciar vehiculo";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIniciar);
            Controls.Add(btnCargarBateria);
            Controls.Add(btnDetener);
            Controls.Add(btnMover);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridViewVehiculos);
            Controls.Add(lblCapacidad);
            Controls.Add(txtCapacidad);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(cboTipoDeVehiculo);
            Controls.Add(lblModelo);
            Controls.Add(lblMarca);
            Controls.Add(lblTipo);
            Controls.Add(lblGestionDeVehiculos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGestionDeVehiculos;
        private Label lblTipo;
        private Label lblMarca;
        private Label lblModelo;
        private ComboBox cboTipoDeVehiculo;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtCapacidad;
        private Label lblCapacidad;
        private DataGridView dataGridViewVehiculos;
        private Button btnAgregar;
        private Button btnMover;
        private Button btnDetener;
        private Button btnCargarBateria;
        private Button btnIniciar;
    }
}
