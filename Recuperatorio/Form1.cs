using Entidades;

namespace Recuperatorio
{
    public partial class Form1 : Form
    {
        private Fabrica fabrica;

        public Form1()
        {
            InitializeComponent();
            InicializarFabrica();
            this.Refresh();

        }

        private void InicializarFabrica()
        {
            this.fabrica = new Fabrica(5);
            this.fabrica += new Camioneta(EPropulsion.Electrico, true);


        }

        public void Refrescar()
        {
            listVehiculos.DataSource = null;
            listVehiculos.DataSource = this.fabrica.Vehiculos;
        }

        public Vehiculo CrearVehiculo()
        {
            switch (cmbTipo.SelectedIndex)
            {
                case 0:
                    return new Automovil();
                case 1:
                    return new Camioneta(EPropulsion.Hibrido, true);
                default:
                    return new Moto(EPropulsion.Combustion);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbTipo.DataSource = new object[] { "Automovil", "Camioneta", "Moto" };
        }

        private void listVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFabricar_Click(object sender, EventArgs e)
        {
            Vehiculo v = CrearVehiculo();
            this.fabrica += v;
            Refrescar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int v = listVehiculos.SelectedIndex;

            Vehiculo vehiculo = this.fabrica.Vehiculos[v];

            this.fabrica -= vehiculo;

            Refrescar();
            
        }
    }
}