using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GCLab16FileIOCountries
{
    class FileWriter
    {
        private string path;
        private StreamWriter sw;

        public FileWriter(string path)
        {
            this.path = path;
            sw = new StreamWriter(path);
        }

        public void WriteToFile(string input)
        {
            sw.Write(input);
        }

        public void SWClose()
        {
            sw.Close();

        }
    }
}
