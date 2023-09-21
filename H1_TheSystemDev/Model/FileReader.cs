using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheSystemDev.Model
{
    internal class FileReader
    {
        private List<string?> _fileContent = new List<string?>();

        internal List<string?> FileContent
        {
            get { return _fileContent; }
            private set { _fileContent = value; }
        }

        /// <summary>
        /// Reads all content in a text file
        /// </summary>
        /// <param name="path">path for text file which will be read</param>
        /// <exception cref="ArgumentException">Message of exception, when any IOException is catched</exception>
        internal void ReadTextFile(string path)
        {
            // Reads a text file using the path
            // When a line is read, then it adds the content of that line to a list of all file content<
            StreamReader? sr = null;
            try
            {
                sr = new StreamReader(path);
                while (!sr.EndOfStream)
                {
                    _fileContent.Add(sr.ReadLine());
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(ex);
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                sr?.Close();
            }
        }
    }
}
