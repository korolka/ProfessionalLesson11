using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalLesson11
{
    class FileOperation
    {
        string content;
        object block = new object();
        public void FileReader(object? path)//path to txt file with information
        {
            lock (block)
            {
                string path1 = path as string;
                StreamReader streamReader = new StreamReader(path1);
                string content = streamReader.ReadToEnd();
                Console.WriteLine(content);
                streamReader.Close();
                FileWriter(content);
            }
        }

        public void FileWriter(string content)
        {
            StreamWriter streamWriter = new StreamWriter("receivedFile.txt", true);
            streamWriter.Write(content);
            streamWriter.WriteLine();
            streamWriter.WriteLine(new string('-', 80));
            streamWriter.Close();

        }

    }
}
