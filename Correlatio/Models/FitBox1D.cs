using PhysicsPlotter.Models;
using RICPFitter.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correlatio.Models
{
    /// <summary>
    /// Class designed to fit any 1D curve on input data
    /// </summary>
    public class FitBox1D
    {
        private IFittable fitFunction;
        private DataSet inputData;

        /// <summary>
        /// Input data
        /// </summary>
        public DataSet InputData 
        { 
            get => inputData; 
            set
            {
                if (inputData != value)
                {
                    if (inputData != null) inputData.InputDataChanged -= InputData_InputDataChanged;
                    inputData = value;
                    InputData_InputDataChanged(inputData);
                    inputData.InputDataChanged += InputData_InputDataChanged;
                }
            }
        }

        private void InputData_InputDataChanged(DataSet data)
        {
            InputDataChanged?.Invoke(data.XData, data.YData);
        }

        /// <summary>
        /// Fit function
        /// </summary>
        public IFittable FitFunction 
        { 
            get => fitFunction; 
            set
            {
                if (fitFunction != value)
                {
                    if (fitFunction != null) fitFunction.FitPerformed -= FitFunction_FitPerformed;
                    fitFunction = value;
                    FitFunctionChanged?.Invoke(fitFunction);
                    fitFunction.FitPerformed += FitFunction_FitPerformed;
                }
            }
        }

        private void FitFunction_FitPerformed(double[] x, double[] y, double cod)
        {
            FitDataChanged?.Invoke(x, y, cod);
        }

        /// <summary>
        /// List of available fit functions
        /// </summary>
        public IFunctionCollection ListOfFitFunctions { get; set; }

        /// <summary>
        /// New empty fit box 1D
        /// </summary>
        public FitBox1D()
        {
            
        }

        /// <summary>
        /// New fit box 1D with fit functions definitions
        /// </summary>
        /// <param name="xmlFilePath">XML file path containing the definitions of the fit functions</param>
        public FitBox1D(string xmlFilePath)
        {
            ListOfFitFunctions = FunctionCollection.FromXML(xmlFilePath);
            FitFunction = ListOfFitFunctions.Functions[0];
        }

        public event Action<double[], double[]> InputDataChanged;
        public event Action<double[], double[], double> FitDataChanged;
        public event Action<IFittable> FitFunctionChanged;
    }
}
