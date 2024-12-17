namespace EjemploClaseStatica.Controllers
{
    public class Auto : Vehiculo
    {
        private  string numerochasi { get; set; }



        public override string Acelera()
        {
            return "El auto Acelera";
        }
        public override string Frena()
        {
            return "El Auto Frenó";
        }
 }
    }
