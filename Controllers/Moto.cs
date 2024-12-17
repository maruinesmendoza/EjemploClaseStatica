namespace EjemploClaseStatica.Controllers
{
    public class Moto : Vehiculo
    {
        public string motor { get; set; }



        public override string Acelera()
        {
            return "La moto  Acelera";
        }
        public override string Frena()
        {
            return "La moto  Frenó";
        }
    }

}

       





