namespace Entidades
{
    public abstract class Persona
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Domicilio { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }

    }
}