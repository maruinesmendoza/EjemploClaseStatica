using EjemploClaseStatica.Controllers;

namespace EjemploClaseStatica.Controllers
{
    public class Vehiculo
    {
        public string Marca { get; set; }

        public string Modelo { get; set; }

        private string patente { get; set; }

        private string Combustible { get; set; }

        public Vehiculo()
        {

        }
        public virtual string Acelera()
        {
            return "El Vehiculo Acelero";
        }
        public virtual string Frena()
        {
            return "El Vehiculo Freno";
        }
        public virtual string Cambios()
        {
            return "El Vehiculo tiene cambios";

        }
    }
}
        
