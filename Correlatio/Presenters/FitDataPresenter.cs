using Correlatio.Models;
using Correlatio.Views;
using System;
using System.Collections.Generic;
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
            view.BindFuncFitParameters(fitBox.FitFunction);

            view.SelectFitFunc += View_SelectFitFunc;
            view.Fit += View_Fit;
        }

        private void View_Fit()
        {
            fitBox.FitFunction.DoFit(fitBox.InputData.XData, fitBox.InputData.YData);
        }

        private void View_SelectFitFunc(string name)
        {
            fitBox.FitFunction = fitBox.ListOfFitFunctions.FindByName(name);
            view.BindFuncFitParameters(fitBox.FitFunction);
        }
    }
}
