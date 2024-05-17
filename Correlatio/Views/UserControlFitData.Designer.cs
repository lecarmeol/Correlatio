namespace Correlatio.Views
{
    partial class UserControlFitData
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            labelFromFunction = new System.Windows.Forms.Label();
            tlpFunction = new System.Windows.Forms.TableLayoutPanel();
            propertyGridFitFunc = new System.Windows.Forms.PropertyGrid();
            comboBoxFitFunc = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            buttonDoFit = new System.Windows.Forms.Button();
            labelFromFile = new System.Windows.Forms.Label();
            tlpExport = new System.Windows.Forms.TableLayoutPanel();
            textBoxDecimalSep = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            textBoxColumnSep = new System.Windows.Forms.TextBox();
            buttonExport = new System.Windows.Forms.Button();
            checkBoxHeader = new System.Windows.Forms.CheckBox();
            checkBoxInputData = new System.Windows.Forms.CheckBox();
            tlpMain = new System.Windows.Forms.TableLayoutPanel();
            tlpFunction.SuspendLayout();
            tlpExport.SuspendLayout();
            tlpMain.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(190, 190, 190);
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Space Grotesk Light Medium", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Margin = new System.Windows.Forms.Padding(0);
            label1.Name = "label1";
            label1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            label1.Size = new System.Drawing.Size(368, 37);
            label1.TabIndex = 1;
            label1.Text = "FIT";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFromFunction
            // 
            labelFromFunction.AutoSize = true;
            labelFromFunction.BackColor = System.Drawing.Color.FromArgb(210, 210, 210);
            labelFromFunction.Dock = System.Windows.Forms.DockStyle.Top;
            labelFromFunction.Font = new System.Drawing.Font("Space Grotesk Light Medium", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelFromFunction.Location = new System.Drawing.Point(6, 43);
            labelFromFunction.Margin = new System.Windows.Forms.Padding(6, 6, 6, 0);
            labelFromFunction.Name = "labelFromFunction";
            labelFromFunction.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            labelFromFunction.Size = new System.Drawing.Size(356, 37);
            labelFromFunction.TabIndex = 4;
            labelFromFunction.Text = "Configuration";
            labelFromFunction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelFromFunction.Click += LabelFromFunction_Click;
            // 
            // tlpFunction
            // 
            tlpFunction.AutoSize = true;
            tlpFunction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tlpFunction.BackColor = System.Drawing.Color.FromArgb(210, 210, 210);
            tlpFunction.ColumnCount = 2;
            tlpFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpFunction.Controls.Add(propertyGridFitFunc, 0, 1);
            tlpFunction.Controls.Add(comboBoxFitFunc, 1, 0);
            tlpFunction.Controls.Add(label5, 0, 0);
            tlpFunction.Controls.Add(buttonDoFit, 0, 2);
            tlpFunction.Dock = System.Windows.Forms.DockStyle.Top;
            tlpFunction.Location = new System.Drawing.Point(6, 80);
            tlpFunction.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            tlpFunction.Name = "tlpFunction";
            tlpFunction.RowCount = 3;
            tlpFunction.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpFunction.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpFunction.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpFunction.Size = new System.Drawing.Size(356, 380);
            tlpFunction.TabIndex = 5;
            // 
            // propertyGridFitFunc
            // 
            tlpFunction.SetColumnSpan(propertyGridFitFunc, 2);
            propertyGridFitFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            propertyGridFitFunc.Location = new System.Drawing.Point(3, 37);
            propertyGridFitFunc.Name = "propertyGridFitFunc";
            propertyGridFitFunc.Size = new System.Drawing.Size(350, 296);
            propertyGridFitFunc.TabIndex = 9;
            // 
            // comboBoxFitFunc
            // 
            comboBoxFitFunc.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            comboBoxFitFunc.Dock = System.Windows.Forms.DockStyle.Top;
            comboBoxFitFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxFitFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboBoxFitFunc.FormattingEnabled = true;
            comboBoxFitFunc.Location = new System.Drawing.Point(137, 3);
            comboBoxFitFunc.Name = "comboBoxFitFunc";
            comboBoxFitFunc.Size = new System.Drawing.Size(216, 28);
            comboBoxFitFunc.TabIndex = 8;
            comboBoxFitFunc.SelectedIndexChanged += ComboBoxFitFunc_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Location = new System.Drawing.Point(3, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(128, 34);
            label5.TabIndex = 2;
            label5.Text = "Type of function:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonDoFit
            // 
            buttonDoFit.AutoSize = true;
            buttonDoFit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            buttonDoFit.BackColor = System.Drawing.Color.FromArgb(190, 190, 190);
            tlpFunction.SetColumnSpan(buttonDoFit, 2);
            buttonDoFit.Dock = System.Windows.Forms.DockStyle.Top;
            buttonDoFit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonDoFit.Location = new System.Drawing.Point(12, 342);
            buttonDoFit.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            buttonDoFit.Name = "buttonDoFit";
            buttonDoFit.Size = new System.Drawing.Size(332, 32);
            buttonDoFit.TabIndex = 7;
            buttonDoFit.Text = "Do fit";
            buttonDoFit.UseVisualStyleBackColor = false;
            buttonDoFit.Click += ButtonDoFit_Click;
            // 
            // labelFromFile
            // 
            labelFromFile.AutoSize = true;
            labelFromFile.BackColor = System.Drawing.Color.FromArgb(210, 210, 210);
            labelFromFile.Dock = System.Windows.Forms.DockStyle.Top;
            labelFromFile.Font = new System.Drawing.Font("Space Grotesk Light Medium", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelFromFile.Location = new System.Drawing.Point(6, 466);
            labelFromFile.Margin = new System.Windows.Forms.Padding(6, 6, 6, 0);
            labelFromFile.Name = "labelFromFile";
            labelFromFile.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            labelFromFile.Size = new System.Drawing.Size(356, 37);
            labelFromFile.TabIndex = 6;
            labelFromFile.Text = "Export";
            labelFromFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelFromFile.Click += LabelFromFile_Click;
            // 
            // tlpExport
            // 
            tlpExport.AutoSize = true;
            tlpExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tlpExport.BackColor = System.Drawing.Color.FromArgb(210, 210, 210);
            tlpExport.ColumnCount = 2;
            tlpExport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpExport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpExport.Controls.Add(textBoxDecimalSep, 1, 1);
            tlpExport.Controls.Add(label4, 0, 1);
            tlpExport.Controls.Add(label3, 0, 0);
            tlpExport.Controls.Add(textBoxColumnSep, 1, 0);
            tlpExport.Controls.Add(buttonExport, 0, 3);
            tlpExport.Controls.Add(checkBoxHeader, 0, 2);
            tlpExport.Controls.Add(checkBoxInputData, 1, 2);
            tlpExport.Dock = System.Windows.Forms.DockStyle.Top;
            tlpExport.Location = new System.Drawing.Point(6, 503);
            tlpExport.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            tlpExport.Name = "tlpExport";
            tlpExport.RowCount = 4;
            tlpExport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpExport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpExport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpExport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpExport.Size = new System.Drawing.Size(356, 136);
            tlpExport.TabIndex = 7;
            tlpExport.Visible = false;
            // 
            // textBoxDecimalSep
            // 
            textBoxDecimalSep.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            textBoxDecimalSep.Dock = System.Windows.Forms.DockStyle.Top;
            textBoxDecimalSep.Location = new System.Drawing.Point(142, 34);
            textBoxDecimalSep.Name = "textBoxDecimalSep";
            textBoxDecimalSep.Size = new System.Drawing.Size(211, 25);
            textBoxDecimalSep.TabIndex = 6;
            textBoxDecimalSep.Text = ".";
            textBoxDecimalSep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Location = new System.Drawing.Point(3, 31);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(133, 31);
            label4.TabIndex = 5;
            label4.Text = "Decimal separator:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Location = new System.Drawing.Point(3, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(133, 31);
            label3.TabIndex = 2;
            label3.Text = "Column separator:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxColumnSep
            // 
            textBoxColumnSep.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            textBoxColumnSep.Dock = System.Windows.Forms.DockStyle.Top;
            textBoxColumnSep.Location = new System.Drawing.Point(142, 3);
            textBoxColumnSep.Name = "textBoxColumnSep";
            textBoxColumnSep.Size = new System.Drawing.Size(211, 25);
            textBoxColumnSep.TabIndex = 3;
            textBoxColumnSep.Text = ",";
            textBoxColumnSep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonExport
            // 
            buttonExport.AutoSize = true;
            buttonExport.BackColor = System.Drawing.Color.FromArgb(190, 190, 190);
            tlpExport.SetColumnSpan(buttonExport, 2);
            buttonExport.Dock = System.Windows.Forms.DockStyle.Top;
            buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonExport.Location = new System.Drawing.Point(12, 98);
            buttonExport.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new System.Drawing.Size(332, 32);
            buttonExport.TabIndex = 7;
            buttonExport.Text = "Export...";
            buttonExport.UseVisualStyleBackColor = false;
            buttonExport.Click += ButtonExport_Click;
            // 
            // checkBoxHeader
            // 
            checkBoxHeader.AutoSize = true;
            checkBoxHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            checkBoxHeader.Location = new System.Drawing.Point(3, 65);
            checkBoxHeader.Name = "checkBoxHeader";
            checkBoxHeader.Size = new System.Drawing.Size(106, 24);
            checkBoxHeader.TabIndex = 4;
            checkBoxHeader.Text = "With header";
            checkBoxHeader.UseVisualStyleBackColor = true;
            // 
            // checkBoxInputData
            // 
            checkBoxInputData.AutoSize = true;
            checkBoxInputData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            checkBoxInputData.Location = new System.Drawing.Point(142, 65);
            checkBoxInputData.Name = "checkBoxInputData";
            checkBoxInputData.Size = new System.Drawing.Size(130, 24);
            checkBoxInputData.TabIndex = 8;
            checkBoxInputData.Text = "With input data";
            checkBoxInputData.UseVisualStyleBackColor = true;
            // 
            // tlpMain
            // 
            tlpMain.AutoSize = true;
            tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tlpMain.BackColor = System.Drawing.Color.FromArgb(190, 190, 190);
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpMain.Controls.Add(tlpExport, 0, 4);
            tlpMain.Controls.Add(labelFromFile, 0, 3);
            tlpMain.Controls.Add(tlpFunction, 0, 2);
            tlpMain.Controls.Add(labelFromFunction, 0, 1);
            tlpMain.Controls.Add(label1, 0, 0);
            tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpMain.Location = new System.Drawing.Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 5;
            tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpMain.Size = new System.Drawing.Size(368, 639);
            tlpMain.TabIndex = 2;
            // 
            // UserControlFitData
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            Controls.Add(tlpMain);
            Font = new System.Drawing.Font("Space Grotesk Light", 10.25F);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "UserControlFitData";
            Size = new System.Drawing.Size(368, 639);
            tlpFunction.ResumeLayout(false);
            tlpFunction.PerformLayout();
            tlpExport.ResumeLayout(false);
            tlpExport.PerformLayout();
            tlpMain.ResumeLayout(false);
            tlpMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFromFunction;
        private System.Windows.Forms.TableLayoutPanel tlpFunction;
        private System.Windows.Forms.PropertyGrid propertyGridFitFunc;
        private System.Windows.Forms.ComboBox comboBoxFitFunc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDoFit;
        private System.Windows.Forms.Label labelFromFile;
        private System.Windows.Forms.TableLayoutPanel tlpExport;
        private System.Windows.Forms.TextBox textBoxDecimalSep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxColumnSep;
        private System.Windows.Forms.CheckBox checkBoxHeader;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.CheckBox checkBoxInputData;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
    }
}
