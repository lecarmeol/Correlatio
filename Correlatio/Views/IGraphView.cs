using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correlatio.Views
{
    /// <summary>
    /// Interface for making a graph view showing input data and fit result
    /// </summary>
    public interface IGraphView
    {
        /// <summary>
        /// Update input data information
        /// </summary>
        /// <param name="title"></param>
        /// <param name="xLabel"></param>
        /// <param name="yLabel"></param>
        void UpdateInputInfo(string title, string xLabel, string yLabel);

        /// <summary>
        /// Update input data set
        /// </summary>
        /// <param name="xData"></param>
        /// <param name="yData"></param>
        void UpdateInputData(double[] xData, double[] yData);

        /// <summary>
        /// Update fit data set
        /// </summary>
        /// <param name="xData"></param>
        /// <param name="yData"></param>
        /// <param name="cod"></param>
        void UpdateFitData(double[] xData, double[] yData, double cod);
    }
}
