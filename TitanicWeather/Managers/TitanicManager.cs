using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TitanicWeather.Managers
{
    public class TitanicManager
    {
        private static int _command = 0;

        public void SetCommand(int com)
        {
            _command = com;
        }

        public int GetCommand()
        {
            return _command;
        }

    }
}
