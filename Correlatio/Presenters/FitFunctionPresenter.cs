using PhysicsPlotter.Views;
using RICPFitter;
using RICPFitter.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsPlotter.Presenters
{
    public class FitFunctionPresenter
    {
        private readonly IFitFunctionView view;
        private IGenerable generatedFunc;
        private IFittable fitFunc;
        private List<FuncParameter> guessParameters;

        private double[] inputX, inputY; 

        public FitFunctionPresenter(IFitFunctionView view, IGenerable generatedFunc, IFittable fitFunc)
        {
            this.view = view;
            this.generatedFunc = generatedFunc;
            this.fitFunc = fitFunc;

            view.InitGenerableList(Definitions.FunctionNames, Definitions.FunctionNames.IndexOf(generatedFunc.GetType().Name));
            view.InitFittableList(Definitions.FunctionNames, Definitions.FunctionNames.IndexOf(fitFunc.GetType().Name));
            view.BindFuncGenParameters(generatedFunc);
            view.BindFuncFitParameters(fitFunc);
            guessParameters = new List<FuncParameter>(fitFunc.Parameters);
            view.BindGuessParameters(guessParameters);

            view.SelectGenFunc += View_SelectGenFunc;
            view.SelectFitFunc += View_SelectFitFunc;

            view.Generate += View_Generate;
            view.Fit += View_Fit;
        }

        private void View_Fit()
        {
            try
            {
                double cod = fitFunc.DoFit(inputX, inputY, guessParameters);
                view.UpdateFitData(inputX, fitFunc.GenerateData(inputX), cod);
            }
            catch (Exception ex)
            {
                view.UpdateErrorMessage("Fit failed.\nDetail: " + ex.Message);
            }
        }

        private void View_Generate(double min, double max, int nbOfPoints)
        {
            (inputX, inputY) = generatedFunc.GenerateData(min, max, nbOfPoints);
            view.UpdateRawData(inputX, inputY);
        }

        private void View_SelectGenFunc(string type)
        {
            string tmp = Definitions.FunctionTypes.Find(x => x.Contains(type));
            var genType = Type.GetType(tmp);
            generatedFunc = (IGenerable)Activator.CreateInstance(genType);
            //view.BindFuncGenParameters(generatedFunc.Parameters);
            view.BindFuncGenParameters(generatedFunc);

        }

        private void View_SelectFitFunc(string type)
        {
            var funcType = Type.GetType(Definitions.FunctionTypes.Find(x => x.Contains(type)));
            fitFunc = (IFittable)Activator.CreateInstance(funcType);
            //view.BindFuncFitParameters(fitFunc.Parameters);
            view.BindFuncFitParameters(fitFunc);

            guessParameters = new List<FuncParameter>(fitFunc.Parameters);
            view.BindGuessParameters(guessParameters);
        }
    }
}
