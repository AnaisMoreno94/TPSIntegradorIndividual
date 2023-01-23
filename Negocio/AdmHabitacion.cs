using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public static class AdmHabitacion
    {

        public static List<Habitacion> Listar()
        {
            return DacHabitacion.Select();
        }

        public static List<Habitacion> Listar(string estado)
        {

            return DacHabitacion.Select(estado);
        }
        public static int Insertar(Habitacion habitacion)
        {

            return DacHabitacion.Insert(habitacion);
        }

        public static int Eliminar(int ID)
        {

            return DacHabitacion.Eliminar(ID);
        }

        public static Habitacion TraerUno(int id)
        {
            return DacHabitacion.SelectById(id);
        }
    }
}