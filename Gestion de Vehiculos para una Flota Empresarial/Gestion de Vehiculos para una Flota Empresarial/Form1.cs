using System.Diagnostics;

namespace Gestion_de_Vehiculos_para_una_Flota_Empresarial
{
    public partial class Form1 : Form
    {
        private List<Vehiculo> listaVehiculos = new List<Vehiculo>();
        private ControladorVehiculos controlador = new ControladorVehiculos();
        public Form1()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            cboTipoDeVehiculo.SelectedIndex = 0;
            dataGridViewVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewVehiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void ConfigurarDataGridView()
        {
            dataGridViewVehiculos.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn columnaMarca = new DataGridViewTextBoxColumn();
            columnaMarca.HeaderText = "Marca";
            columnaMarca.DataPropertyName = "Marca";
            dataGridViewVehiculos.Columns.Add(columnaMarca);

            DataGridViewTextBoxColumn columnaModelo = new DataGridViewTextBoxColumn();
            columnaModelo.HeaderText = "Modelo";
            columnaModelo.DataPropertyName = "Modelo";
            dataGridViewVehiculos.Columns.Add(columnaModelo);

            DataGridViewTextBoxColumn columnaTipo = new DataGridViewTextBoxColumn();
            columnaTipo.HeaderText = "Tipo";
            columnaTipo.DataPropertyName = "Tipo";
            dataGridViewVehiculos.Columns.Add(columnaTipo);

            DataGridViewTextBoxColumn columnaCapacidad = new DataGridViewTextBoxColumn();
            columnaCapacidad.HeaderText = "Capacidad";
            columnaCapacidad.DataPropertyName = "Capacidad";
            dataGridViewVehiculos.Columns.Add(columnaCapacidad);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTipoDeVehiculo.SelectedItem.ToString())
            {
                case "Camion":
                    lblCapacidad.Visible = true;
                    txtCapacidad.Visible = true;
                    lblCapacidad.Text = "Capacidad de carga(Kg):";
                    break;
                case "Vehiculo Electrico":
                    lblCapacidad.Visible = true;
                    txtCapacidad.Visible = true;
                    lblCapacidad.Text = "Capacidad de bateria(Kw):";
                    break;
                default:
                    lblCapacidad.Visible = false;
                    txtCapacidad.Visible = false;
                    break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string tipoVehiculo = cboTipoDeVehiculo.SelectedItem.ToString();
                string marca = txtMarca.Text;
                string modelo = txtModelo.Text;
                Vehiculo nuevoVehiculo;

                if (string.IsNullOrWhiteSpace(marca) || string.IsNullOrWhiteSpace(modelo))
                {
                    throw new VehiculoException("Los campos ´Marca´ y ´Modelo´ son obligatorios.");
                }

                if (tipoVehiculo == "Camion" || tipoVehiculo == "Vehiculo Electrico")
                {
                    if (!int.TryParse(txtCapacidad.Text, out int capacidad))
                    {
                        throw new
                            VehiculoException("El valor de capacidad debe ser un numero.");
                    }
                    nuevoVehiculo = controlador.CrearVehiculo(tipoVehiculo, marca, modelo, capacidad);
                }
                else
                {
                    nuevoVehiculo = controlador.CrearVehiculo(tipoVehiculo, marca, modelo);
                }

                listaVehiculos.Add(nuevoVehiculo);
                ActualizarDataGridView();
            }
            catch (VehiculoException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarDataGridView()
        {
            dataGridViewVehiculos.DataSource = null;
            dataGridViewVehiculos.DataSource = listaVehiculos;
            dataGridViewVehiculos.Refresh();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridViewVehiculos.SelectedRows.Count > 0)
                {
                    int indiceSeleccionado = dataGridViewVehiculos.SelectedRows[0].Index;
                    if (indiceSeleccionado >= 0 && indiceSeleccionado < listaVehiculos.Count) {

                        Vehiculo vehiculoSeleccionado = listaVehiculos[indiceSeleccionado];

                        MessageBox.Show($"El vehiculo {vehiculoSeleccionado.Marca} {vehiculoSeleccionado.Modelo} se ha iniciado.", "Vehiculo iniciado", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    }
                    else
                    {
                        MessageBox.Show("El vehiculo seleccionado no es valido.", "Error de seleccion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show($"Por favor, seleccione un vehiculo antes de iniciar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (VehiculoException ex)
            {
                MessageBox.Show($"Ocurrio un error al momento de intentar iniciar el vehiculo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridViewVehiculos.SelectedRows.Count > 0)
                {
                    int indiceSeleccionado = dataGridViewVehiculos.SelectedRows[0].Index;

                    if (indiceSeleccionado >= 0 && indiceSeleccionado < listaVehiculos.Count)
                    {
                        Vehiculo vehiculoSeleccionado = listaVehiculos[indiceSeleccionado];

                        MessageBox.Show($"El vehiculo {vehiculoSeleccionado.Marca} {vehiculoSeleccionado.Modelo} se ha detenido.", "Vehiculo detenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El vehiculo seleccionado no es valido.", "Error de seleccion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show($"Por favor, seleccione un vehiculo antes de detener.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (VehiculoException ex)
            {
                MessageBox.Show($"Ocurrio un error al momento de intentar detener el vehiculo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridViewVehiculos.SelectedRows.Count > 0)
                {
                    int indiceSeleccionado = dataGridViewVehiculos.SelectedRows[0].Index;

                    if (indiceSeleccionado >= 0 && indiceSeleccionado < listaVehiculos.Count)
                    {
                        Vehiculo vehiculoSeleccionado = listaVehiculos[indiceSeleccionado];

                        MessageBox.Show($"El vehiculo {vehiculoSeleccionado.Marca} {vehiculoSeleccionado.Modelo} se ha movido.", "Vehiculo moviendose", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El vehiculo seleccionado no es valido.", "Error de seleccion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show($"Por favor, seleccione un vehiculo antes de moverlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (VehiculoException ex)
            {
                MessageBox.Show($"Ocurrio un error al momento de intentar mover el vehiculo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCargarBateria_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridViewVehiculos.SelectedRows.Count > 0)
                {
                    int indiceSeleccionado = dataGridViewVehiculos.SelectedRows[0].Index;

                    if (indiceSeleccionado >= 0 && indiceSeleccionado < listaVehiculos.Count)
                    {
                        Vehiculo vehiculoSeleccionado = listaVehiculos[indiceSeleccionado];
                        if (vehiculoSeleccionado is IElectrico vehiculoElectrico)
                        {
                            vehiculoElectrico.CargarBateria();

                            MessageBox.Show($"El vehiculo electrico {vehiculoSeleccionado.Marca} {vehiculoSeleccionado.Modelo} esta cargando su bateria", "Cargando su bateria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"El vehiculo seleccionado no es electrico y no puede cargar su bateria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El vehiculo seleccionado no es valido.", "Error de seleccion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show($"Por favor, seleccione un vehiculo antes de intentar cargar su bateria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (VehiculoException ex)
            {
                MessageBox.Show($"Ocurrio un error al momento de intentar cargar la bateria del vehiculo electrico: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
