﻿using Microsoft.AspNetCore.Mvc;
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
        private readonly TitanicManager _localManager;
        public TitanicController()
        {
            _manager = new TitanicManagerDB();
            _localManager = new TitanicManager();
        }


        [HttpGet]
        public IActionResult OnGet()
        {
            return RedirectToPage("/index.html");
        }

        // GET: api/Titanic/Recent
        [HttpGet("Recent")]
        public Measurement GetRecentMeasurement()
        {
            return _manager.GetLastMeasurement();
        }

        // GET: api/Titanic/All
        [HttpGet("All")]
        public IEnumerable<Measurement> GetAllMeasurements()
        {
            return _manager.GetAllMeasurements();
        }

        // GET: api/Titanic/Command
        [HttpGet("Command")]
        public int GetCommand()
        {
            return _localManager.GetCommand();
        }
        
        // GET: api/Titanic/HeatingLevel
        [HttpGet("HeatingLevel")]
        public int GetHeatingLevel()
        {
            return _localManager.GetHeatingLevel();
        }
        // GET: api/Titanic/SummarizedData
        [HttpGet("SummarizedData")]
        public IEnumerable<SummarizedData> GetSummarizedData()
        {
            return _manager.GetSummarizedData();
        }

        // POST api/Titanic/SetCommand
        [HttpPost("SetCommand")]
        public void PostCommand([FromBody] Command command)
        {
            _localManager.SetCommand(command.integer);
        }

        // POST api/Titanic/SetHeatingLevel
        [HttpPost("SetHeatingLevel")]
        public void PostHeatingLevel([FromBody] HeatingLevel heatingLevel)
        {
            _localManager.SetHeatingLevel(heatingLevel.integer);
        }
    }
}
