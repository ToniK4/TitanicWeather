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
        public SummarizedData SummarizeDataForTheDay(IEnumerable<Measurement> dayMeasures,DateTime dt)
        {
            SummarizedData res;
            if (dayMeasures.Any())
            res = new SummarizedData()
            {
                Date = dt,
                MaxTemp = dayMeasures.FirstOrDefault().Temperature.Value,
                MinTemp = dayMeasures.FirstOrDefault().Temperature.Value,
                MaxHumid = dayMeasures.FirstOrDefault().Humidity.Value,
                MinHumid = dayMeasures.FirstOrDefault().Humidity.Value
            };
            else res = new SummarizedData()
            {
                Date = dt,
                MaxTemp =0,
                MinTemp =0,
                MaxHumid = 0,
                MinHumid =0
            };
            foreach (Measurement measurement in dayMeasures)
            {
                if (measurement.Temperature.Value > res.MaxTemp) res.MaxTemp = measurement.Temperature.Value;
                if (measurement.Temperature.Value < res.MinTemp) res.MinTemp = measurement.Temperature.Value;
                if (measurement.Humidity.Value > res.MaxHumid) res.MaxHumid = measurement.Humidity.Value;
                if (measurement.Humidity.Value < res.MinHumid) res.MinHumid = measurement.Humidity.Value;
            }

            return res;
        }
        public IEnumerable<SummarizedData> GetSummarizedData()
        {
            IEnumerable<Measurement> data = _context.Measurements;
            DateTime currentDate;
            List<SummarizedData> res = new List<SummarizedData>();
            for (int i = 6; i >= 0; i--)
            {
                currentDate = DateTime.Now.Date.AddDays(-i);
                res.Add(SummarizeDataForTheDay(data.Where(x=>x.DateAndTime.Date==currentDate),currentDate));
            }
            return res;
        }

    }
}
