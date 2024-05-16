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
        /// Bind the parameters of the fit function
        /// </summary>
        /// <param name="parameters"></param>
        void BindFuncFitParameters(object parameters);

        /// <summary>
        /// Fired to start fit calculation
        /// </summary>
        event Action Fit;

        /// <summary>
        /// Fired to select a function for fit generation
        /// </summary>
        event Action<string> SelectFitFunc;

    }
}
