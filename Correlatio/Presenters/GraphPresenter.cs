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
    internal class GraphPresenter
    {
        private readonly IGraphView view;
        private readonly FitBox1D fitBox;

        public GraphPresenter(IGraphView view, FitBox1D fitBox = null)
        {
            this.view = view;
            this.fitBox = fitBox;

            fitBox.InputDataChanged += FitBox_InputDataChanged;
            fitBox.FitDataChanged += FitBox_FitDataChanged;
        }

        private void FitBox_InputDataChanged(double[] x, double[] y)
        {
            view.UpdateInputInfo(fitBox.InputData.Title, fitBox.InputData.XLabel, fitBox.InputData.YLabel);
            view.UpdateInputData(x, y);
        }

        private void FitBox_FitDataChanged(IFittable function, double[] x, double[] y)
        {
            string fitInfo = function.Description + Environment.NewLine;
            foreach(var param in function.Parameters)
            {
                fitInfo += $"{param.Name} = {param.Value}" + Environment.NewLine;
            }
            fitInfo += $"R² = {Math.Round(function.CoeffOfDetermination, 4)}"; 
            view.UpdateFitData(x, y, fitInfo);
        }

    }
}
