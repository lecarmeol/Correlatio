using Correlatio.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Correlatio
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            BackColor = ColorTheme.BG;
            ForeColor = ColorTheme.Text;
        }

        public FormMain(UserControlGraphView graphView, UserControlInputData inputDataView, UserControlFitData fitDataView) : this()
        {
            splitContainerMain.Panel2.Controls.Add(graphView);
            graphView.Dock = DockStyle.Fill;
            tlpParam.Controls.Add(inputDataView, 0, 0);
            tlpParam.Controls.Add(fitDataView, 0, 1);
            inputDataView.Dock = DockStyle.Fill;
            fitDataView.Dock = DockStyle.Fill;
        }
    }
}
