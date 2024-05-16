using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correlatio.Models
{
    /// <summary>
    /// Set of XY data
    /// </summary>
    public class DataSet
    {
        private double[] xData;
        private double[] yData;

        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// X label or description
        /// </summary>
        public string XLabel { get; set; }

        /// <summary>
        /// Y label or description
        /// </summary>
        public string YLabel { get; set; }

        /// <summary>
        /// X data
        /// </summary>
        public double[] XData
        {
            get => xData;
            set
            {
                if (xData != value)
                {
                    xData = value;
                    if (yData != null) InputDataChanged?.Invoke(this);
                }
            }
        }

        /// <summary>
        /// Y data
        /// </summary>
        public double[] YData
        {
            get => yData;
            set
            {
                if (yData != value)
                {
                    yData = value;
                    if (xData != null) InputDataChanged?.Invoke(this);
                }
            }
        }

        /// <summary>
        /// New empty dataset
        /// </summary>
        public DataSet()
        {
            
        }

        /// <summary>
        /// New dataset with input data
        /// </summary>
        /// <param name="xData"></param>
        /// <param name="yData"></param>
        /// <param name="title"></param>
        /// <param name="xLabel"></param>
        /// <param name="yLabel"></param>
        public DataSet(double[] xData, double[] yData, string title = null, string xLabel = null, string yLabel = null) : this()
        {
            this.xData = xData;
            this.yData = yData;
            Title = title;
            XLabel = xLabel;
            YLabel = yLabel;
            InputDataChanged?.Invoke(this);
        }

        /// <summary>
        /// Fired when X or Y data change
        /// </summary>
        public event Action<DataSet> InputDataChanged;

    }
}
