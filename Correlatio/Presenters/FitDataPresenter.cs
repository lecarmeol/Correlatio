using Correlatio.Models;
using Correlatio.Views;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correlatio.Presenters
{
    internal class FitDataPresenter
    {
        private readonly IFitDataView view;
        private readonly FitBox1D fitBox;

        public FitDataPresenter(IFitDataView view, FitBox1D fitBox)
        {
            this.view = view;
            this.fitBox = fitBox;

            view.InitFittableList(fitBox.ListOfFitFunctions.Functions.Select(f => f.Name).ToList(), 0);
            view.InitExportOptions();
            view.BindFuncFitParameters(fitBox.FitFunction);

            view.SelectFitFunc += View_SelectFitFunc;
            view.Fit += View_Fit;
            view.Export += View_Export;
        }

        private void View_Export(string fp, string decimalSep, string columnSep, bool addHeader, bool addInputData)
        {
            try
            {
                using StreamWriter writer = new(fp);
                if (addHeader)
                {
                    string header = fitBox.InputData.XLabel + columnSep;
                    if (addInputData)
                    {
                        header += fitBox.InputData.YLabel + columnSep;
                    }
                    header += fitBox.FitFunction.Name;
                    writer.WriteLine(header);
                }
                double[] yFit = fitBox.FitFunction.GenerateData(fitBox.InputData.XData);
                for (int i = 0; i < fitBox.InputData.XData.Length; i++)
                {
                    string line = fitBox.InputData.XData[i].ToString(CultureInfo.InvariantCulture).Replace(".", decimalSep) + columnSep;
                    if (addInputData)
                    {
                        line += fitBox.InputData.YData[i].ToString(CultureInfo.InvariantCulture).Replace(".", decimalSep) + columnSep;
                    }
                    line += yFit[i].ToString(CultureInfo.InvariantCulture).Replace(".", decimalSep);
                    writer.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                view.UpdateErrorMessage(errorMessage: ex.Message);
            }
        }

        private void View_Fit()
        {
            try
            {
                fitBox.FitFunction.DoFit(fitBox.InputData.XData, fitBox.InputData.YData);
            }
            catch (Exception ex)
            {
                view.UpdateErrorMessage(errorMessage: ex.Message);
            }
        }

        private void View_SelectFitFunc(string name)
        {
            try
            {
                fitBox.FitFunction = fitBox.ListOfFitFunctions.FindByName(name);
                view.BindFuncFitParameters(fitBox.FitFunction);
            }
            catch (Exception ex)
            {
                view.UpdateErrorMessage(errorMessage: ex.Message);
            }
        }
    }
}
