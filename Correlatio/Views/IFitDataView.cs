using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correlatio.Views
{
    /// <summary>
    /// Interface for making UI handling fit data
    /// </summary>
    public interface IFitDataView
    {
        /// <summary>
        /// Initialize the list of function for fit generation
        /// </summary>
        /// <param name="fittableList"></param>
        /// <param name="defaultSelectedIdx"></param>
        void InitFittableList(List<string> fittableList, int defaultSelectedIdx);

        /// <summary>
        /// Initialize the export options
        /// </summary>
        /// <param name="decimalSeparator"></param>
        /// <param name="columnDelimiter"></param>
        /// <param name="addHeader"></param>
        /// <param name="addInputData"></param>
        void InitExportOptions(string decimalSeparator = ".", string columnDelimiter = ",", bool addHeader = false, bool addInputData = true);

        /// <summary>
        /// Bind the parameters of the fit function
        /// </summary>
        /// <param name="parameters"></param>
        void BindFuncFitParameters(object parameters);

        /// <summary>
        /// Update error message
        /// </summary>
        /// <param name="errorMessage"></param>
        void UpdateErrorMessage(string errorMessage);

        /// <summary>
        /// Fired to start fit calculation
        /// </summary>
        event Action Fit;

        /// <summary>
        /// Fired to select a function for fit generation
        /// </summary>
        event Action<string> SelectFitFunc;

        /// <summary>
        /// Fired when a data export is request<br/>
        /// Arguments:<br/>
        /// - File path (string)<br/>
        /// - Decimal separator (string)<br/>
        /// - Column separator (string)<br/>
        /// - Add header (bool)<br/>
        /// - Add input data (bool)<br/>
        /// </summary>
        event Action<string, string, string, bool, bool> Export;

    }
}
