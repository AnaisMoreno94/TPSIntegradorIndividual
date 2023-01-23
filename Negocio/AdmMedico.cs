using Datos;
using Entidades;

namespace Negocio
{
    public static class AdmMedico
    {

        public static List<Medico> Listar()
        {
            return DacMedico.Select();
        }

        public static List<Medico> ListarEspecialidad (string especialidad)
        {
            return DacMedico.Select(especialidad);
        }

        public static int Insertar(Medico medico)
        {
            
            return DacMedico.Insert(medico);
        }

        public static int Eliminar(int id)
        {
            

            return DacMedico.Eliminar(id);
        }

        public static Medico TraerUno(int id) {


            return DacMedico.SelectById(id);
        }

    }
}