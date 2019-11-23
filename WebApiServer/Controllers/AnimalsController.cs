using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiServer.Data;
using WebApiServer.DTO;

namespace WebApiServer.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    //[ApiController]
    public class AnimalsController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public AnimalsController(ApplicationDbContext dbContext)
        {
            _db = dbContext;
        }
        // api/animals
        [HttpGet]
        public IActionResult GetAnimals()
        {
            List<AnimalDTO> model = _db.Animals
                .Select(x=>
                            new AnimalDTO
                            {
                                Name = x.Name,
                                Bread = x.Bread,
                                DateBirdth = x.DateBirdth.ToString(),
                                Image = x.Image
                            }
                ).ToList();// = new List<AnimalDTO>();
            //model.Add(new AnimalDTO
            //{
            //    Name="Боря",
            //    Bread="Манул",
            //    DateBirdth="12.12.2018",
            //    Image= "https://dinoanimals.com/wp-content/uploads/2016/02/Pallass_cat.jpg"
            //});

            //model.Add(new AnimalDTO
            //{
            //    Name = "Оксана",
            //    Bread = "Руский голубий",
            //    DateBirdth = "07.01.2017",
            //    Image = "https://www.humanesociety.org/sites/default/files/styles/1240x698/public/2018/06/cat-217679.jpg?h=c4ed616d&itok=3qHaqQ56"
            //});
            return Ok(model);
        }
    }
}