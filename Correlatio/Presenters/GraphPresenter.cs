using Correlatio.Models;
using Correlatio.Views;
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

        private void FitBox_FitDataChanged(double[] x, double[] y, double cod)
        {
            view.UpdateFitData(x, y, cod);
        }

    }
}
