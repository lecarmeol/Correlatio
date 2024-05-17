using Correlatio.Models;
using Correlatio.Presenters;
using Correlatio.Views;
using PhysicsPlotter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Correlatio
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            UserControlGraphView ucGraphView = new();
            UserControlInputData ucInputData = new();
            UserControlFitData ucFitData = new();
            FormMain main = new(ucGraphView, ucInputData, ucFitData);

            string xmlFP = AppDomain.CurrentDomain.BaseDirectory + "ListOfFunctions.xml";
            FitBox1D fitBox = new(xmlFP);
            _ = new GraphPresenter(ucGraphView, fitBox);
            _ = new InputDataPresenter(ucInputData, fitBox, FunctionCollection.FromXML(xmlFP));
            _ = new FitDataPresenter(ucFitData, fitBox);

            Application.Run(main);
        }
    }
}
