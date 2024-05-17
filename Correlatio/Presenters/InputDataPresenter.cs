using Correlatio.Models;
using Correlatio.Views;
using RICPFitter.Functions;
using System;
using System.Collections.Generic;
using System.IO;
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
            try
            {
                using var reader = new StreamReader(filePath);
                List<string> colX = [];
                List<string> colY = [];
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(ColumnDelimiter);

                    colX.Add(values[0]);
                    colY.Add(values[1]);
                }
                DataSet inputData = new() { Title = title };
                if (hasHeader)
                {
                    inputData.XLabel = colX[0];
                    inputData.YLabel = colY[0];
                    colX.RemoveAt(0);
                    colY.RemoveAt(0);
                }
                inputData.XData = [.. colX.ConvertAll( x =>
                Double.Parse(x.Replace(',','.'),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture))];
                inputData.YData = [.. colY.ConvertAll(y =>
                Double.Parse(y.Replace(',', '.'),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture))];
                fitBox.InputData = inputData;
            }
            catch (Exception ex)
            {
                view.UpdateErrorMessage(errorMessage: ex.Message);
            }
        }

        private void View_Generate(double start, double end, int nbOfPoints)
        {
            try
            {
                (double[] x, double[] y) = selectedFunction.GenerateData(start, end, nbOfPoints);
                fitBox.InputData = new DataSet(x, y, selectedFunction.Name, "x (a.u.)", "y (a.u.)");
            }
            catch (Exception ex)
            {
                view.UpdateErrorMessage(errorMessage: ex.Message);
            }
        }

        private void View_SelectGenFunc(string name)
        {
            try
            {
                selectedFunction = functionCollection.FindByName(name);
                view.BindFuncGenParameters(selectedFunction);
            }
            catch (Exception ex)
            {
                view.UpdateErrorMessage(errorMessage: ex.Message);
            }
        }
    }
}
