using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correlatio.Views
{
    /// <summary>
    /// Interface for making UI handling input data
    /// </summary>
    public interface IInputDataView
    {
        /// <summary>
        /// Initialize the list of function for data generation
        /// </summary>
        /// <param name="generableList"></param>
        /// <param name="defaultSelectedIdx"></param>
        void InitGenerableList(List<string> generableList, int defaultSelectedIdx);

        /// <summary>
        /// Bind the parameters of the generation function
        /// </summary>
        /// <param name="parameters"></param>
        void BindFuncGenParameters(object parameters);

        /// <summary>
        /// Initialize the settings of the load file UI
        /// </summary>
        /// <param name="decimalSeparator"></param>
        /// <param name="columnDelimiter"></param>
        /// <param name="hasHeader"></param>
        /// <param name="title"></param>
        void InitLoadFileSettings(string decimalSeparator = ".", string columnDelimiter = ",", bool hasHeader = false, string title = null);

        /// <summary>
        /// Update error message
        /// </summary>
        /// <param name="errorMessage"></param>
        void UpdateErrorMessage(string errorMessage);

        /// <summary>
        /// Fired to generate input data from the selected function
        /// </summary>
        event Action<double, double, int> Generate;

        /// <summary>
        /// Fired to select a function for input generation
        /// </summary>
        event Action<string> SelectGenFunc;

        /// <summary>
        /// Fired when input data loading from file is requested<br/>
        /// Arguments:<br/>
        /// - file path (string)<br/>
        /// - decimal separator (string)<br/>
        /// - column delimiter (string)<br/>
        /// - first line is header (bool)<br/>
        /// - title (string)
        /// </summary>
        event Action<string, string, string, bool, string> LoadFromFile;
    }
}
