using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Datos
{
    public class DacHabitacion
    {
        private static DBProyectoIntegradorContext context = new DBProyectoIntegradorContext();
        public static List<Habitacion> Select()
        {
            return context.Habitaciones.ToList();

        }
        public static Habitacion Select(int nroHabitacion)
        {
            Habitacion habitacion = (from h in context.Habitaciones
                                     where h.Numero == nroHabitacion
                                     select h).SingleOrDefault();
            return habitacion;
        }

        public static List<Habitacion> Select(string estado)
        {
           List<Habitacion> habitaciones = (from h in context.Habitaciones
                                     where h.Estado == estado
                                     select h).ToList();
            return habitaciones;
        }
        public static int Insert(Habitacion habitacion)
        {
            context.Habitaciones.Add(habitacion);
            return 0;
        }

        public static Habitacion SelectById(int id)
        {
            
            return context.Habitaciones.Find(id);
        }
        public static int Eliminar(int id)
        {
            
            Habitacion habitacionOrigen = context.Habitaciones.Find(id);
            if (habitacionOrigen != null)
            {
                context.Habitaciones.Remove(habitacionOrigen);
                return context.SaveChanges();
                
            }
            else return 0;
           
        }
    }
}
