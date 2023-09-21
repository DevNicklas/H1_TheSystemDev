using H1_TheSystemDev.Model;
using H1_TheSystemDev.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheSystemDev.Controller
{
    /// <summary>
    /// Class <see cref="MainController"/> controls the main part of the program
    /// </summary>
    internal class MainController
    {
        /// <summary>
        /// Starts the controller
        /// </summary>
        internal void Start()
        {
            
            FileReader? fileReader = null;
            try
            {
                fileReader = new FileReader();
                fileReader.ReadTextFile(@"C:\Users\zbc23nlmg\Desktop\CodeLock\log.txt");

                // Gets amount of errors in log file
                FileAnalyzer analyzer = new FileAnalyzer();
                byte errorAmount = analyzer.GetErrorsAmount(fileReader!.FileContent);

                ShowAnalyzedData analyzedData = new ShowAnalyzedData();
                analyzedData.ErrorCodeAmount(errorAmount);
            }

            // Writes a user friendly message
            catch(ArgumentException ex)
            {
                ShowErrorMessage errorMessage = new ShowErrorMessage();
                errorMessage.ShowError(ex.Message);
            }
        }
    }
}
