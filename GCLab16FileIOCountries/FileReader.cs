using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GCLab16FileIOCountries
{
    class FileReader
    {
        private string path;
        private StreamReader sr;

        public FileReader(string path)
        {
            this.path = path;
            sr = new StreamReader(path);
        }

        public string GetAllRemainingLines()
        {
            try
            {
                string output = sr.ReadToEnd();
                return output;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.HelpLink);
                return "No New Lines Found";
            }

        }

        public void SRClose()
        {
            sr.Close();

        }
    }
}
