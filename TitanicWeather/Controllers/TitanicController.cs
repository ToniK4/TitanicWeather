using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TitanicWeather.Managers;
using TitanicWeather.Models;
using TitanicWeather.TitanicContext;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TitanicWeather.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TitanicController : ControllerBase
    {
        private readonly TitanicManagerDB _manager;
        public TitanicController()
        {
            _manager = new TitanicManagerDB();
        }


        // GET: api/Recent/<TitanicController>
        [HttpGet("Recent")]
        public Measurement GetRecentMeasurement()
        {
            return _manager.GetLastMeasurement();
        }

        // GET: api/All/<TitanicController>
        [HttpGet("All")]
        public IEnumerable<Measurement> GetAllMeasurements()
        {
            return _manager.GetAllMeasurements();
        }

        // GET api/<TitanicController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        // DELETE api/<TitanicController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
