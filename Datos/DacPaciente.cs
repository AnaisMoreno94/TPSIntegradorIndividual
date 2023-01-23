using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DacPaciente
    {
        private static DBProyectoIntegradorContext context = new DBProyectoIntegradorContext();
        public static List<Paciente> Select()
        {
            return context.Pacientes.ToList();
        }
        public static Paciente Select(int nroHistoria)
        {
            Paciente paciente = (from p in context.Pacientes
                                    where p.NroHistoriaClinica == nroHistoria
                                    select p).SingleOrDefault();
            return paciente;
        }
        public static int Insert(Paciente paciente)
        {
            context.Pacientes.Add(paciente);
            return 0;
        }

        public static Paciente SelectById(int id)
        {
            return context.Pacientes.Find(id);
        }
        public static int Eliminar(int id)
        {

            Paciente medicoOrigen = context.Pacientes.Find(id);
            if (medicoOrigen != null)
            {
                context.Pacientes.Remove(medicoOrigen);
                return context.SaveChanges();

            }
            else return 0;
        }
    }
}
}
