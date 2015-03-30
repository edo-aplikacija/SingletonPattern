using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Logger
    {
        private static Logger _logger = null;

        private Logger() { }

        public static Logger GetInstance()
        {
            // Yoda expression
            if (null == _logger)
            {
                _logger = new Logger();
            }
            return _logger;
        }

        public void FriteToFile()
        {
            Console.WriteLine("Write to file!!!");
        }
    }
}
