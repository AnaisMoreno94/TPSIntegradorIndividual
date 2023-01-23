using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public static class DacMedico
    {
        private static DBProyectoIntegradorContext context = new DBProyectoIntegradorContext();
        public static List<Medico> Select()
        {
            return context.Medicos.ToList();
        }
        public static List<Medico> Select(string especialidad)
        {
            List<Medico> medicos = (from m in context.Medicos
                            where m.Especialidad == especialidad
                            select m).ToList();
            return medicos;
        }
        public static int Insert(Medico medico)
        {
            context.Medicos.Add(medico);
            return 0;
        }

        public static Medico SelectById(int id)
        {
            return context.Medicos.Find(id);
        }
        public static int Eliminar(int id)
        {
           
            Medico medicoOrigen = context.Medicos.Find(id);
            if (medicoOrigen != null)
            {
                context.Medicos.Remove(medicoOrigen);
                return context.SaveChanges();

            }
            else return 0;
        }
    }
}
