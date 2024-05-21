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
using ScottPlot.Plottables;
using ScottPlot.DataSources;
using System.Drawing.Imaging;

namespace Correlatio.Views
{
    public partial class UserControlGraphView : UserControl, IGraphView
    {
        private ScatterSourceDoubleArray genData, fitData;
        private readonly Crosshair crosshair;
        private readonly SaveFileDialog sfd = new();

        public UserControlGraphView()
        {
            InitializeComponent();
            labelTitle.ForeColor = ColorTheme.Title;
            tlpExport.BackColor = ColorTheme.BG;
            formsPlot.BackColor = ColorTheme.BG;
            labelExportTitle.ForeColor = ColorTheme.SubTitle;

            // Custom context menu
            formsPlot.Menu.AddSeparator();
            formsPlot.Menu.Add("Show/Hide legend", formsPlot =>
            {
                var legend = formsPlot.Plot.Legend;
                legend.AllowMultiline = true;
                if (legend.IsVisible) legend.Hide();
                else legend.Show();
                formsPlot.Refresh();
            });
            formsPlot.Menu.Add("Autoscale", formsPlot =>
            {
                formsPlot.Refresh();
            });
            formsPlot.Menu.Add("Show/Hide export panel", _ =>
            {
                if (tlpExport.Visible) tlpExport.Hide();
                else tlpExport.Show();
            });

            // Read value
            crosshair = formsPlot.Plot.Add.Crosshair(0, 0);
            crosshair.IsVisible = false;

            formsPlot.MouseMove += FormsPlot_MouseMove;
        }

        private void FormsPlot_MouseMove(object sender, MouseEventArgs e)
        {
            // determine where the mouse is and get the nearest point
            Pixel mousePixel = new(e.Location.X, e.Location.Y);
            Coordinates mouseLocation = formsPlot.Plot.GetCoordinates(mousePixel);
            if (genData != null)
            {
                DataPoint nearest = genData.GetNearest(mouseLocation, formsPlot.Plot.LastRender);

                // place the crosshair over the highlighted point
                if (nearest.IsReal)
                {
                    crosshair.IsVisible = true;
                    crosshair.Position = nearest.Coordinates;
                    formsPlot.Refresh();
                    //Text = $"Selected Index={nearest.Index}, X={nearest.X:0.##}, Y={nearest.Y:0.##}";
                }

                // hide the crosshair when no point is selected
                if (!nearest.IsReal && crosshair.IsVisible)
                {
                    crosshair.IsVisible = false;
                    formsPlot.Refresh();
                    //Text = $"No point selected";
                }
            }
        }

        public void UpdateErrorMessage(string message)
        {
            MessageBox.Show(this, message);
        }

        public void UpdateFitData(double[] xData, double[] yData, string fitInfo)
        {
            fitData = new ScatterSourceDoubleArray(xData, yData);
            UpdatePlot(fitInfo);
        }

        public void UpdateInputData(double[] xData, double[] yData)
        {
            genData = new ScatterSourceDoubleArray(xData, yData);
            fitData = null;
            UpdatePlot();
        }

        private void UpdatePlot(string fitInfo = null)
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
                fitPlot.Label = fitInfo;
            }
            formsPlot.Plot.Axes.AutoScale();
            formsPlot.Refresh();
        }

        public void UpdateInputInfo(string title, string xLabel, string yLabel)
        {
            formsPlot.Plot.Title(title);
            formsPlot.Plot.XLabel(xLabel);
            formsPlot.Plot.YLabel(yLabel);
        }

        private void ButtonExportPng_Click(object sender, EventArgs e)
        {
            sfd.Filter = "Png bitmap | *.png";
            sfd.DefaultExt = "png";
            SaveGraph();
        }

        private void ButtonExportSvg_Click(object sender, EventArgs e)
        {
            sfd.Filter = "Svg vector | *.svg";
            sfd.DefaultExt = "svg";
            SaveGraph();
        }

        private void SaveGraph()
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                switch (sfd.DefaultExt)
                {
                    case "png":
                        formsPlot.Plot.SavePng(sfd.FileName, (int)nudWidth.Value, (int)nudHeight.Value);
                        break;
                    case "svg":
                        formsPlot.Plot.SaveSvg(sfd.FileName, (int)nudWidth.Value, (int)nudHeight.Value);
                        break;
                }
            }
        }
    }
}
