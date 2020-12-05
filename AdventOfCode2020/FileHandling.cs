using System;
using System.IO;
using System.Text;

namespace AdventOfCode2020
{
    public static class FileHandling
    {
        public static void Load(string path, Action<string> lineRead)
        {
            var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    lineRead(line);
                }
            }
        }
    }
}