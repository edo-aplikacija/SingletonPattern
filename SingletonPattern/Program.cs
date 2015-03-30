using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = Logger.GetInstance();

            logger.FriteToFile();

            Console.ReadLine();
        }
    }
}
