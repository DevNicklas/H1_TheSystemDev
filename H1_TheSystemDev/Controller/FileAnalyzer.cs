using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheSystemDev.Controller
{
    /// <summary>
    /// Class <see cref="FileAnalyzer"/> is used for analyzing files
    /// </summary>
    internal class FileAnalyzer
    {
        internal byte GetErrorsAmount(List<string?> fileContent)
        {
            const string ERROR_CODE = "[Error]";
            byte errors = 0;

            // Counts every line which contains the error code
            for (int i = 0; i < fileContent.Count; i++)
            {
                if (fileContent[i] != null)
                {
                    if (fileContent[i]!.Contains(ERROR_CODE))
                    {
                        errors++;
                    }
                }
            }
            return errors;
        }
    }
}
