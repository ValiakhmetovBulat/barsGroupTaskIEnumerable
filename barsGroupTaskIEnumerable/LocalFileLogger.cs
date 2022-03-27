using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace barsGroupTaskIEnumerable
{
    public class LocalFileLogger<T> : ILogger
    {
        private string _path;

        public LocalFileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message, Exception ex)
        {
            using (StreamWriter writer = new StreamWriter(_path, true))
            {
               writer.WriteLine($"[Error]:[{typeof(T).Name}]:{message}.{ex.Message}");
            }
        }

        public void LogInfo(string message)
        {
            using (StreamWriter writer = new StreamWriter(_path, true))
            {
                writer.WriteLine($"[Info]:[{typeof(T).Name}]:{message}");
            }
        }

        public void LogWarning(string message)
        {
            using (StreamWriter writer = new StreamWriter(_path, true))
            {
                writer.WriteLine($"[Warning]:[{typeof(T).Name}]:{message}");
            }
        }
    }
}
