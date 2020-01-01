using ExoMai1.Models;
using ExoMai1.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ExoMai1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ZooController : ControllerBase
    {
        private IZooService _zooService;

        public ZooController(IZooService zooService)
        {
            _zooService = zooService;
        }

        [HttpPost]
        [Route("add")]
        public void Add([FromBody]AnimalModel animal)
        {
            _zooService.Add(animal);
        }

        [HttpGet]
        [Route("getall")]
        public IEnumerable<AnimalModel> GetAll()
        {
            return _zooService.GetAll();
        }
    }
}
