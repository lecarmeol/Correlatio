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
    public partial class UserControlInputData : UserControl, IInputDataView
    {
        private readonly Color titleMouseOut;
        private readonly Color titleMouseIn;

        public UserControlInputData()
        {
            InitializeComponent();
            BackColor = ColorTheme.BG;
            tlpFromFile.BackColor = ColorTheme.BGPanel;
            tlpFunction.BackColor = ColorTheme.BGPanel;
            labelTitle.ForeColor = ColorTheme.Title;
            labelFromFile.ForeColor = ColorTheme.SubTitle;
            labelFromFunction.ForeColor = ColorTheme.SubTitle;
            titleMouseOut = ColorTheme.BGPanel;
            titleMouseIn = ColorTheme.AdjustLuminance(ColorTheme.BGPanel, -10);
            labelFromFile.BackColor = titleMouseOut;
            labelFromFunction.BackColor = titleMouseOut;
            buttonLoadFromFile.BackColor = ColorTheme.SubTitle2;
            buttonGenerate.BackColor = ColorTheme.SubTitle2;
            buttonLoadFromFile.ForeColor = ColorTheme.BG;
            buttonGenerate.BackColor= ColorTheme.BG;
        }

        public event Action<double, double, int> Generate;
        public event Action<string> SelectGenFunc;
        public event Action<string, string, string, bool, string> LoadFromFile;

        public void BindFuncGenParameters(object parameters)
        {
            propertyGridGenFunc.SelectedObject = parameters;
        }

        public void InitGenerableList(List<string> generableList, int defaultSelectedIdx)
        {
            comboBoxGenFunc.Items.AddRange(generableList.ToArray());
            comboBoxGenFunc.SelectedIndex = defaultSelectedIdx;
        }

        public void InitLoadFileSettings(string decimalSeparator = ".", string columnDelimiter = ",", bool hasHeader = false, string title = null)
        {
            textBoxColumnSep.Text = columnDelimiter;
            checkBoxHeader.Checked = hasHeader;
            textBoxTitle.Text = title;
        }

        private void ButtonLoadFromFile_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new()
            {
                Filter = "csv files (*.csv)|*.csv|data files (*.dat)|*.dat|txt files (*.txt)|*.txt|All files (*.*)|*.*"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LoadFromFile?.Invoke(ofd.FileName, ".", textBoxColumnSep.Text, checkBoxHeader.Checked, textBoxTitle.Text);
            }

        }

        private void ComboBoxGenFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectGenFunc?.Invoke((sender as ComboBox).SelectedItem.ToString());
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            Generate?.Invoke((double)nudMinGen.Value, (double)nudMaxGen.Value, (int)nudNbOfPointsGen.Value);
        }

        private void LabelFromFile_Click(object sender, EventArgs e)
        {
            tlpFromFile.Visible = !tlpFromFile.Visible;
        }

        private void LabelFromFunction_Click(object sender, EventArgs e)
        {
            tlpFunction.Visible = !tlpFunction.Visible;
        }

        public void UpdateErrorMessage(string errorMessage)
        {
            MessageBox.Show(this, errorMessage);
        }

        private void LabelSubtitle_MouseEnter(object sender, EventArgs e)
        {
            (sender as Control).BackColor = titleMouseIn;
        }

        private void LabelSubtitle_MouseLeave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = titleMouseOut;
        }
    }
}
