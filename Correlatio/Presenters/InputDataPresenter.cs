using Correlatio.Models;
using Correlatio.Views;
using RICPFitter.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correlatio.Presenters
{
    internal class InputDataPresenter
    {
        private readonly IInputDataView view;
        private readonly FitBox1D fitBox;
        private readonly IFunctionCollection functionCollection;
        private IGenerable selectedFunction;

        public InputDataPresenter(IInputDataView view, FitBox1D fitBox, IFunctionCollection functionCollection)
        {
            this.view = view;
            this.fitBox = fitBox;
            this.functionCollection = functionCollection;
            view.InitLoadFileSettings();
            view.InitGenerableList(functionCollection.Functions.Select(f => f.Name).ToList(), 0);
            selectedFunction = functionCollection.Functions[0];
            view.BindFuncGenParameters(selectedFunction);

            view.SelectGenFunc += View_SelectGenFunc;
            view.Generate += View_Generate;
            view.LoadFromFile += View_LoadFromFile;
        }

        private void View_LoadFromFile(string filePath, string DecimalSeparator, string ColumnDelimiter, bool hasHeader, string title)
        {
            throw new NotImplementedException();
        }

        private void View_Generate(double start, double end, int nbOfPoints)
        {
            (double[] x, double[] y) = selectedFunction.GenerateData(start, end, nbOfPoints);
            fitBox.InputData = new DataSet(x, y, selectedFunction.Name, "x (a.u.)", "y (a.u.)");
        }

        private void View_SelectGenFunc(string name)
        {
            selectedFunction = functionCollection.FindByName(name);
            view.BindFuncGenParameters(selectedFunction);
        }
    }
}
