using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjemploClaseStatica.Controllers { 

    [Route("api/Herencia")]
    public class HerenciaController2 : ControllerBase
    {

        [HttpGet()]
        public async Task<string> GetVehiculo()
        {
            Moto moto = new Moto();
            moto.Modelo = "Deportiva";
            moto.Marca = "Renault";

            return moto.Acelera();
        }

    }

}


    