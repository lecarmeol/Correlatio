using PhysicsPlotter.Presenters;
using PhysicsPlotter.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsPlotter
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

            UserControlFitFunctionView userControlFitFunctionView = new();
            FormMain main = new(userControlFitFunctionView);

            //new FitFunctionPresenter(userControlFitFunctionView, new Gaussian(), new Gaussian());
            string xmlFP = AppDomain.CurrentDomain.BaseDirectory + "ListOfFunctions.xml";
            _ = new FunctionCollectionPresenter(userControlFitFunctionView, Models.FunctionCollection.FromXML(xmlFP));

            Application.Run(main);
        }
    }
}
