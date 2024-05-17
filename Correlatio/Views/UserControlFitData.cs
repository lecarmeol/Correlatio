using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Correlatio.Views
{
    public partial class UserControlFitData : UserControl, IFitDataView
    {
        public UserControlFitData()
        {
            InitializeComponent();
        }

        public event Action Fit;
        public event Action<string> SelectFitFunc;
        public event Action<string, string, string, bool, bool> Export;

        public void BindFuncFitParameters(object parameters)
        {
            propertyGridFitFunc.SelectedObject = parameters;
        }

        public void InitExportOptions(string decimalSeparator = ".", string columnDelimiter = ",", bool addHeader = false, bool addInputData = true)
        {
            textBoxDecimalSep.Text = decimalSeparator;
            textBoxColumnSep.Text = columnDelimiter;
            checkBoxHeader.Checked = addHeader;
            checkBoxInputData.Checked = addInputData;
        }

        public void InitFittableList(List<string> fittableList, int defaultSelectedIdx)
        {
            comboBoxFitFunc.Items.AddRange(fittableList.ToArray());
            comboBoxFitFunc.SelectedIndex = defaultSelectedIdx;
        }

        private void ComboBoxFitFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectFitFunc?.Invoke((sender as ComboBox).SelectedItem.ToString());
        }

        private void ButtonDoFit_Click(object sender, EventArgs e)
        {
            Fit?.Invoke();
        }

        private void ButtonExport_Click(object sender, EventArgs e)
        {
            using SaveFileDialog sfd = new();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export?.Invoke(sfd.FileName, textBoxDecimalSep.Text, textBoxColumnSep.Text, checkBoxHeader.Checked, checkBoxInputData.Checked);
            }
        }

        private void LabelFromFunction_Click(object sender, EventArgs e)
        {
            tlpFunction.Visible = !tlpFunction.Visible;
        }

        private void LabelFromFile_Click(object sender, EventArgs e)
        {
            tlpExport.Visible = !tlpExport.Visible;
        }

        public void UpdateErrorMessage(string errorMessage)
        {
            MessageBox.Show(this, errorMessage);
        }
    }
}
