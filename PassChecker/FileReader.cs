using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassChecker
{
    internal class FileReader
    {
        static string relativePath = "/Src/File.txt";
        readonly string textFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
        
        public FileReader()
        {

        }
        public FileReader(string path)
        {
            textFile = path;
        }

        public string[] GetDataFromFile()
        {
            List<string> dataList = new List<string>();
            
            if(File.Exists(textFile))
            {
                using (StreamReader sr = new StreamReader(textFile))
                {
                    string line;
                    
                    while ((line = sr.ReadLine()) != null)
                    {
                        dataList.Add(line);
                    }
                }
            }

            return dataList.ToArray();
        }
    }
}
