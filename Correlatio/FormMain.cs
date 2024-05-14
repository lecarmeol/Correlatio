using PhysicsPlotter.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsPlotter
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(UserControlFitFunctionView userControlFitFunctionView) : this()
        {
            this.Controls.Add(userControlFitFunctionView);
            userControlFitFunctionView.Dock = DockStyle.Fill;
        }
    }
}
