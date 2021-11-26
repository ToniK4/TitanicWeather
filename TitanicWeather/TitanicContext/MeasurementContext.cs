using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TitanicWeather.Models;

namespace TitanicWeather.TitanicContext
{
    //Delet dis later pls
    public class MeasurementContext : DbContext
    {
        public MeasurementContext()
        {
        }

        public MeasurementContext(DbContextOptions<MeasurementContext> options) : base(options)
        {

        }
        public DbSet<Measurement> Measurements { get; set; }
    }
}
