using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TitanicWeather.Models;
using TitanicWeather.TitanicContext;

namespace TitanicWeather.Managers
{
    public class TitanicManagerDB
    {
        private TitanicdatabaseContext _context = new TitanicdatabaseContext();
        public TitanicManagerDB()
        {
            
        }

        public Measurement Add(Measurement newItem)
        {
            _context.Measurements.Add(newItem);
            _context.SaveChanges();
            return newItem;
        }

        public IEnumerable<Measurement> GetAllMeasurements()
        {
            return _context.Measurements;
        }

        public Measurement GetLastMeasurement()
        {
            Measurement meas = new Measurement()
            {
                Id = 0
            };

            foreach (var item in _context.Measurements)
            {
                if (item.Id > meas.Id)
                {
                    meas = item;
                }
            }
            return meas;
        }

    }
}
