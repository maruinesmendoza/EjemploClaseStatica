using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjemploClaseStatica.Controllers 
{


    [Route("api/Auto")]
    public class AutoController : ControllerBase
    {

        [HttpGet()]
        public async Task <string> GetVehiculo()

            {
                Auto auto = new Auto();
                auto.Modelo = "Steway";
                auto.Marca = "Renault";

                return auto.Acelera();
             }

         }
}













 






