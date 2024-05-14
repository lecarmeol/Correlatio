using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicsPlotter.Views
{
    public interface IFitFunctionView
    {
        void InitGenerableList(List<string> generableList, int defaultSelectedIdx);

        void InitFittableList(List<string> fittableList, int defaultSelectedIdx);

        void BindFuncGenParameters(object parameters);

        void BindFuncFitParameters(object parameters);

        void BindGuessParameters(object parameters);

        void UpdateRawData(double[] xData, double[] yData);

        void UpdateFitData(double[] xData, double[] yData, double cod);

        void UpdateErrorMessage(string message);

        event Action<double, double, int> Generate;
        event Action Fit;
        event Action<string> SelectGenFunc;
        event Action<string> SelectFitFunc;
    }
}
