using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class DatabaseLoggerService : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Log Yazıldı");
        }
    }
}
