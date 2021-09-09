using ExoMai1.Models;
using ExoMai1.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ExoMai1.Controllers
{
    [ApiController]
    [Route("zoo")]
    //[Route("[controller]")]
    public class ZooController : ControllerBase
    {
        private IZooService _zooService;

        public ZooController(IZooService zooService)
        {
            _zooService = zooService;
        }

        [HttpPost("add")]
        public void Add([FromBody]AnimalModel animal)
        {
            _zooService.Add(animal);
        }

        [HttpGet("getall")]
        public IEnumerable<AnimalModel> GetAll()
        {
            return _zooService.GetAll();
        }
    }
}
