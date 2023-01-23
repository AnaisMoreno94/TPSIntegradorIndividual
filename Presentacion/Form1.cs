using Negocio;
using Entidades;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridPacientes.DataSource = AdmPaciente.Listar();
            gridMedicos.DataSource = AdmMedico.Listar();

            List<Habitacion> listaHabitaciones = AdmHabitacion.Listar();

            foreach (Habitacion habitacion in listaHabitaciones)
            {
                listHabitaciones.Items.Add("Numero Habitacion: "+ habitacion.Numero + ", Estado: " + habitacion.Estado);
            }

            List<Medico> listaMedicos = AdmMedico.Listar();

            foreach (Medico medico in listaMedicos)
            {
                if (medico.Especialidad == "Clinico") 
                {
                    listMedicos.Items.Add("Medico: "+medico.Nombre+", Especialidad: "+medico.Especialidad);
                }
                
            }
        }

        private void listHabitaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
  
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}