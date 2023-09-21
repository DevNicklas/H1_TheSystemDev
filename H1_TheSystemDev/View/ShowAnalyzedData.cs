using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheSystemDev.View
{
    /// <summary>
    /// Class <see cref="ShowAnalyzedData"/> represents all graphical about analyzed data
    /// </summary>
    internal class ShowAnalyzedData
    {
        internal void ErrorCodeAmount(byte errorAmount)
        {
            Console.WriteLine($"There was found: {errorAmount} errors in the log");
        }
    }
}
