using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TitanicWeather.Managers
{
    public class TitanicManager
    {
        private static int _command = -1;
        private static int _heatingLevel = 0;

        public void SetCommand(int com)
        {
            _command = com;
        }
        public void SetHeatingLevel(int heat)
        {
            _heatingLevel = heat;
        }

        public int GetCommand()
        {
            return _command;
        }

        public int GetHeatingLevel()
        {
            return _heatingLevel;
        }

    }
}
