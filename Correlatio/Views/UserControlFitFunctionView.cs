using ScottPlot.WinForms;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsPlotter.Views
{
    public partial class UserControlFitFunctionView : UserControl, IFitFunctionView
    {
        private readonly FormsPlot formsPlot = new();
        private IScatterSource genData, fitData;

        public UserControlFitFunctionView()
        {
            InitializeComponent();
            splitContainerMain.Panel2.Controls.Add(formsPlot);
            formsPlot.Dock = DockStyle.Fill;
            formsPlot.BackColor = System.Drawing.Color.White;
        }

        public event Action<double, double, int> Generate;
        public event Action Fit;
        public event Action<string> SelectGenFunc;
        public event Action<string> SelectFitFunc;

        public void BindFuncFitParameters(object parameters)
        {
            propertyGridFitFunc.SelectedObject = parameters;
        }

        public void BindFuncGenParameters(object parameters)
        {
            propertyGridGenFunc.SelectedObject = parameters;
        }

        public void BindGuessParameters(object parameters)
        {
            propertyGridGuess.SelectedObject = parameters;
        }

        public void InitFittableList(List<string> fittableList, int defaultSelectedIdx)
        {
            comboBoxFitFunc.Items.AddRange(fittableList.ToArray());
            comboBoxFitFunc.SelectedIndex = defaultSelectedIdx;
        }

        public void InitGenerableList(List<string> generableList, int defaultSelectedIdx)
        {
            comboBoxGenFunc.Items.AddRange(generableList.ToArray());
            comboBoxGenFunc.SelectedIndex = defaultSelectedIdx;
        }

        public void UpdateErrorMessage(string message)
        {
            MessageBox.Show(this, message);
        }

        public void UpdateFitData(double[] xData, double[] yData, double cod)
        {
            fitData = new ScottPlot.DataSources.ScatterSourceDoubleArray(xData, yData);
            UpdatePlot();
            propertyGridFitFunc.Refresh();
        }

        public void UpdateRawData(double[] xData, double[] yData)
        {
            genData = new ScottPlot.DataSources.ScatterSourceDoubleArray(xData, yData);
            fitData = null;
            UpdatePlot();
            propertyGridGenFunc.Refresh();
        }

        private void ComboBoxGenFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectGenFunc?.Invoke((sender as ComboBox).SelectedItem.ToString());
        }

        private void ComboBoxFitFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectFitFunc?.Invoke((sender as ComboBox).SelectedItem.ToString());
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            Generate?.Invoke((double)nudMinGen.Value, (double)nudMaxGen.Value, (int)nudNbOfPointsGen.Value);
        }

        private void ButtonFit_Click(object sender, EventArgs e)
        {
            Fit?.Invoke();
        }

        private void UpdatePlot(bool addCod = false, string cod = "")
        {
            formsPlot.Plot.Clear();
            if (genData != null)
            {
                formsPlot.Plot.Add.Scatter(genData);

            }
            if (fitData != null)
            {

                var fitPlot = formsPlot.Plot.Add.ScatterLine(fitData);
                fitPlot.LineWidth = 3;
                if (addCod)
                {
                    formsPlot.Plot.Add.Text(cod, formsPlot.Plot.Axes.Bottom.Min, formsPlot.Plot.Axes.Left.Min);
                }
            }
            formsPlot.Plot.Axes.AutoScale();
            formsPlot.Refresh();
        }
    }
}
