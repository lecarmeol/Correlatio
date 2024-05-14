using PhysicsPlotter.Views;
using RICPFitter.Functions;
using RICPFitter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhysicsPlotter.Models;
using System.ComponentModel;

namespace PhysicsPlotter.Presenters
{
    public class FunctionCollectionPresenter
    {
        private readonly IFitFunctionView view;
        private readonly FunctionCollection collection;

        [DisplayName("Parameters")]
        [Description("Parameters of the function")]
        public List<FuncParameter> GuessParameters { get; set; }

        private double[] inputX, inputY;

        public FunctionCollectionPresenter(IFitFunctionView view, FunctionCollection collection)
        {
            this.view = view;
            this.collection = collection;

            view.InitGenerableList(collection.GenerableFunctions.Select(f => f.Name).ToList(), 0);
            view.InitFittableList(collection.FittableFunctions.Select(f => f.Name).ToList(), 0);
            view.BindFuncGenParameters(collection.GetSelectedGenerableFunction());
            view.BindFuncFitParameters(collection.GetSelectedFitFunction());
            GuessParameters = new List<FuncParameter>(collection.GetSelectedFitFunction().Parameters);
            view.BindGuessParameters(this);

            view.SelectGenFunc += View_SelectGenFunc;
            view.SelectFitFunc += View_SelectFitFunc;

            view.Generate += View_Generate;
            view.Fit += View_Fit;
        }

        private void View_Fit()
        {
            try
            {
                IFittable fitFunc = collection.GetSelectedFitFunction();
                double cod = fitFunc.DoFit(inputX, inputY, GuessParameters);
                view.UpdateFitData(inputX, fitFunc.GenerateData(inputX), cod);
            }
            catch (Exception ex)
            {
                view.UpdateErrorMessage("Fit failed.\nDetail: " + ex.Message);
            }
        }

        private void View_Generate(double min, double max, int nbOfPoints)
        {
            IGenerable generatedFunc = collection.GetSelectedGenerableFunction();
            (inputX, inputY) = generatedFunc.GenerateData(min, max, nbOfPoints);
            view.UpdateRawData(inputX, inputY);
        }

        private void View_SelectGenFunc(string type)
        {
            try
            {
                collection.SetSelectedGenerableFunction(type);
                view.BindFuncGenParameters(collection.GetSelectedGenerableFunction());
            }
            catch (Exception ex)
            {
                view.UpdateErrorMessage(ex.Message);
            }
        }

        private void View_SelectFitFunc(string type)
        {
            try
            {
                collection.SetSelectedFitFunction(type);
                IFittable fitFunc = collection.GetSelectedFitFunction();
                view.BindFuncGenParameters(fitFunc);
                            GuessParameters = new List<FuncParameter>(fitFunc.Parameters);
            view.BindGuessParameters(this);
            }
            catch (Exception ex)
            {
                view.UpdateErrorMessage(ex.Message);
            }
        }
    }
}
