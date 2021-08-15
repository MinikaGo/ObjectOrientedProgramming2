using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class FileLoggerService : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Log Yazıldı");
        }
    }
}
