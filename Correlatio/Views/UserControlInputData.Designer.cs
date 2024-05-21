namespace Correlatio.Views
{
    partial class UserControlInputData
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
            labelTitle = new System.Windows.Forms.Label();
            labelFromFile = new System.Windows.Forms.Label();
            tlpFromFile = new System.Windows.Forms.TableLayoutPanel();
            textBoxTitle = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            textBoxColumnSep = new System.Windows.Forms.TextBox();
            checkBoxHeader = new System.Windows.Forms.CheckBox();
            buttonLoadFromFile = new System.Windows.Forms.Button();
            labelFromFunction = new System.Windows.Forms.Label();
            tlpFunction = new System.Windows.Forms.TableLayoutPanel();
            propertyGridGenFunc = new System.Windows.Forms.PropertyGrid();
            comboBoxGenFunc = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            buttonGenerate = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            nudMinGen = new System.Windows.Forms.NumericUpDown();
            label7 = new System.Windows.Forms.Label();
            nudMaxGen = new System.Windows.Forms.NumericUpDown();
            label8 = new System.Windows.Forms.Label();
            nudNbOfPointsGen = new System.Windows.Forms.NumericUpDown();
            tlpMain = new System.Windows.Forms.TableLayoutPanel();
            tlpFromFile.SuspendLayout();
            tlpFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinGen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxGen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNbOfPointsGen).BeginInit();
            tlpMain.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            labelTitle.Font = new System.Drawing.Font("Space Grotesk Light Medium", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelTitle.Location = new System.Drawing.Point(0, 0);
            labelTitle.Margin = new System.Windows.Forms.Padding(0);
            labelTitle.Name = "labelTitle";
            labelTitle.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            labelTitle.Size = new System.Drawing.Size(546, 37);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "INPUT DATA";
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFromFile
            // 
            labelFromFile.AutoSize = true;
            labelFromFile.Dock = System.Windows.Forms.DockStyle.Top;
            labelFromFile.Font = new System.Drawing.Font("Space Grotesk Light Medium", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelFromFile.Location = new System.Drawing.Point(6, 49);
            labelFromFile.Margin = new System.Windows.Forms.Padding(6, 12, 6, 0);
            labelFromFile.Name = "labelFromFile";
            labelFromFile.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            labelFromFile.Size = new System.Drawing.Size(534, 31);
            labelFromFile.TabIndex = 2;
            labelFromFile.Text = "From file";
            labelFromFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelFromFile.Click += LabelFromFile_Click;
            labelFromFile.MouseEnter += LabelSubtitle_MouseEnter;
            labelFromFile.MouseLeave += LabelSubtitle_MouseLeave;
            // 
            // tlpFromFile
            // 
            tlpFromFile.AutoSize = true;
            tlpFromFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tlpFromFile.ColumnCount = 2;
            tlpFromFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpFromFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpFromFile.Controls.Add(textBoxTitle, 1, 2);
            tlpFromFile.Controls.Add(label4, 0, 2);
            tlpFromFile.Controls.Add(label3, 0, 0);
            tlpFromFile.Controls.Add(textBoxColumnSep, 1, 0);
            tlpFromFile.Controls.Add(checkBoxHeader, 0, 1);
            tlpFromFile.Controls.Add(buttonLoadFromFile, 0, 3);
            tlpFromFile.Dock = System.Windows.Forms.DockStyle.Top;
            tlpFromFile.Location = new System.Drawing.Point(6, 80);
            tlpFromFile.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            tlpFromFile.Name = "tlpFromFile";
            tlpFromFile.RowCount = 4;
            tlpFromFile.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpFromFile.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpFromFile.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpFromFile.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpFromFile.Size = new System.Drawing.Size(534, 136);
            tlpFromFile.TabIndex = 3;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Dock = System.Windows.Forms.DockStyle.Top;
            textBoxTitle.Location = new System.Drawing.Point(145, 64);
            textBoxTitle.Margin = new System.Windows.Forms.Padding(6, 3, 18, 3);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new System.Drawing.Size(371, 25);
            textBoxTitle.TabIndex = 6;
            textBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Location = new System.Drawing.Point(3, 61);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(133, 31);
            label4.TabIndex = 5;
            label4.Text = "Title (optional):";
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
            textBoxColumnSep.Dock = System.Windows.Forms.DockStyle.Left;
            textBoxColumnSep.Location = new System.Drawing.Point(145, 3);
            textBoxColumnSep.Margin = new System.Windows.Forms.Padding(6, 3, 18, 3);
            textBoxColumnSep.Name = "textBoxColumnSep";
            textBoxColumnSep.Size = new System.Drawing.Size(67, 25);
            textBoxColumnSep.TabIndex = 3;
            textBoxColumnSep.Text = ",";
            textBoxColumnSep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxHeader
            // 
            checkBoxHeader.AutoSize = true;
            checkBoxHeader.Location = new System.Drawing.Point(3, 34);
            checkBoxHeader.Name = "checkBoxHeader";
            checkBoxHeader.Size = new System.Drawing.Size(109, 24);
            checkBoxHeader.TabIndex = 4;
            checkBoxHeader.Text = "With header";
            checkBoxHeader.UseVisualStyleBackColor = true;
            // 
            // buttonLoadFromFile
            // 
            buttonLoadFromFile.AutoSize = true;
            tlpFromFile.SetColumnSpan(buttonLoadFromFile, 2);
            buttonLoadFromFile.Dock = System.Windows.Forms.DockStyle.Top;
            buttonLoadFromFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonLoadFromFile.Font = new System.Drawing.Font("Space Grotesk Light", 10.25F, System.Drawing.FontStyle.Bold);
            buttonLoadFromFile.Location = new System.Drawing.Point(18, 98);
            buttonLoadFromFile.Margin = new System.Windows.Forms.Padding(18, 6, 18, 6);
            buttonLoadFromFile.Name = "buttonLoadFromFile";
            buttonLoadFromFile.Size = new System.Drawing.Size(498, 32);
            buttonLoadFromFile.TabIndex = 7;
            buttonLoadFromFile.Text = "Load...";
            buttonLoadFromFile.UseVisualStyleBackColor = false;
            buttonLoadFromFile.Click += ButtonLoadFromFile_Click;
            // 
            // labelFromFunction
            // 
            labelFromFunction.AutoSize = true;
            labelFromFunction.Dock = System.Windows.Forms.DockStyle.Top;
            labelFromFunction.Font = new System.Drawing.Font("Space Grotesk Light Medium", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelFromFunction.Location = new System.Drawing.Point(6, 228);
            labelFromFunction.Margin = new System.Windows.Forms.Padding(6, 12, 6, 0);
            labelFromFunction.Name = "labelFromFunction";
            labelFromFunction.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            labelFromFunction.Size = new System.Drawing.Size(534, 31);
            labelFromFunction.TabIndex = 4;
            labelFromFunction.Text = "From function";
            labelFromFunction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelFromFunction.Click += LabelFromFunction_Click;
            labelFromFunction.MouseEnter += LabelSubtitle_MouseEnter;
            labelFromFunction.MouseLeave += LabelSubtitle_MouseLeave;
            // 
            // tlpFunction
            // 
            tlpFunction.AutoSize = true;
            tlpFunction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tlpFunction.ColumnCount = 5;
            tlpFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpFunction.Controls.Add(propertyGridGenFunc, 0, 1);
            tlpFunction.Controls.Add(comboBoxGenFunc, 2, 0);
            tlpFunction.Controls.Add(label5, 0, 0);
            tlpFunction.Controls.Add(buttonGenerate, 0, 4);
            tlpFunction.Controls.Add(label6, 0, 2);
            tlpFunction.Controls.Add(nudMinGen, 1, 2);
            tlpFunction.Controls.Add(label7, 2, 2);
            tlpFunction.Controls.Add(nudMaxGen, 3, 2);
            tlpFunction.Controls.Add(label8, 0, 3);
            tlpFunction.Controls.Add(nudNbOfPointsGen, 1, 3);
            tlpFunction.Dock = System.Windows.Forms.DockStyle.Top;
            tlpFunction.Location = new System.Drawing.Point(6, 259);
            tlpFunction.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            tlpFunction.Name = "tlpFunction";
            tlpFunction.RowCount = 5;
            tlpFunction.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpFunction.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpFunction.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpFunction.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpFunction.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpFunction.Size = new System.Drawing.Size(534, 446);
            tlpFunction.TabIndex = 5;
            tlpFunction.Visible = false;
            // 
            // propertyGridGenFunc
            // 
            tlpFunction.SetColumnSpan(propertyGridGenFunc, 5);
            propertyGridGenFunc.Dock = System.Windows.Forms.DockStyle.Top;
            propertyGridGenFunc.HelpBackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            propertyGridGenFunc.Location = new System.Drawing.Point(3, 37);
            propertyGridGenFunc.Name = "propertyGridGenFunc";
            propertyGridGenFunc.Size = new System.Drawing.Size(528, 296);
            propertyGridGenFunc.TabIndex = 9;
            // 
            // comboBoxGenFunc
            // 
            tlpFunction.SetColumnSpan(comboBoxGenFunc, 3);
            comboBoxGenFunc.Dock = System.Windows.Forms.DockStyle.Top;
            comboBoxGenFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxGenFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboBoxGenFunc.FormattingEnabled = true;
            comboBoxGenFunc.Location = new System.Drawing.Point(200, 3);
            comboBoxGenFunc.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            comboBoxGenFunc.Name = "comboBoxGenFunc";
            comboBoxGenFunc.Size = new System.Drawing.Size(328, 28);
            comboBoxGenFunc.TabIndex = 8;
            comboBoxGenFunc.SelectedIndexChanged += ComboBoxGenFunc_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            tlpFunction.SetColumnSpan(label5, 2);
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Location = new System.Drawing.Point(3, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(188, 34);
            label5.TabIndex = 2;
            label5.Text = "Type of function:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonGenerate
            // 
            buttonGenerate.AutoSize = true;
            tlpFunction.SetColumnSpan(buttonGenerate, 5);
            buttonGenerate.Dock = System.Windows.Forms.DockStyle.Top;
            buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonGenerate.Font = new System.Drawing.Font("Space Grotesk Light", 10.25F, System.Drawing.FontStyle.Bold);
            buttonGenerate.Location = new System.Drawing.Point(18, 408);
            buttonGenerate.Margin = new System.Windows.Forms.Padding(18, 6, 18, 6);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new System.Drawing.Size(498, 32);
            buttonGenerate.TabIndex = 7;
            buttonGenerate.Text = "Generate";
            buttonGenerate.UseVisualStyleBackColor = false;
            buttonGenerate.Click += ButtonGenerate_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = System.Windows.Forms.DockStyle.Fill;
            label6.Location = new System.Drawing.Point(3, 336);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(97, 33);
            label6.TabIndex = 13;
            label6.Text = " Min:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudMinGen
            // 
            nudMinGen.DecimalPlaces = 4;
            nudMinGen.Dock = System.Windows.Forms.DockStyle.Top;
            nudMinGen.Location = new System.Drawing.Point(106, 340);
            nudMinGen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            nudMinGen.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            nudMinGen.Minimum = new decimal(new int[] { 1215752192, 23, 0, int.MinValue });
            nudMinGen.Name = "nudMinGen";
            nudMinGen.Size = new System.Drawing.Size(85, 25);
            nudMinGen.TabIndex = 14;
            nudMinGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudMinGen.Value = new decimal(new int[] { 10, 0, 0, int.MinValue });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = System.Windows.Forms.DockStyle.Fill;
            label7.Location = new System.Drawing.Point(197, 336);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(45, 33);
            label7.TabIndex = 15;
            label7.Text = " Max:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudMaxGen
            // 
            nudMaxGen.DecimalPlaces = 4;
            nudMaxGen.Location = new System.Drawing.Point(248, 340);
            nudMaxGen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            nudMaxGen.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            nudMaxGen.Minimum = new decimal(new int[] { 1215752192, 23, 0, int.MinValue });
            nudMaxGen.Name = "nudMaxGen";
            nudMaxGen.Size = new System.Drawing.Size(88, 25);
            nudMaxGen.TabIndex = 16;
            nudMaxGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudMaxGen.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = System.Windows.Forms.DockStyle.Fill;
            label8.Location = new System.Drawing.Point(3, 369);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(97, 33);
            label8.TabIndex = 17;
            label8.Text = "Nb of points:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudNbOfPointsGen
            // 
            nudNbOfPointsGen.Dock = System.Windows.Forms.DockStyle.Top;
            nudNbOfPointsGen.Location = new System.Drawing.Point(106, 373);
            nudNbOfPointsGen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            nudNbOfPointsGen.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudNbOfPointsGen.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudNbOfPointsGen.Name = "nudNbOfPointsGen";
            nudNbOfPointsGen.Size = new System.Drawing.Size(85, 25);
            nudNbOfPointsGen.TabIndex = 18;
            nudNbOfPointsGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudNbOfPointsGen.Value = new decimal(new int[] { 21, 0, 0, 0 });
            // 
            // tlpMain
            // 
            tlpMain.AutoSize = true;
            tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpMain.Controls.Add(tlpFunction, 0, 4);
            tlpMain.Controls.Add(labelFromFunction, 0, 3);
            tlpMain.Controls.Add(tlpFromFile, 0, 2);
            tlpMain.Controls.Add(labelFromFile, 0, 1);
            tlpMain.Controls.Add(labelTitle, 0, 0);
            tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpMain.Location = new System.Drawing.Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            tlpMain.RowCount = 5;
            tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpMain.Size = new System.Drawing.Size(546, 717);
            tlpMain.TabIndex = 6;
            // 
            // UserControlInputData
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            Controls.Add(tlpMain);
            Font = new System.Drawing.Font("Space Grotesk Light", 10.25F);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "UserControlInputData";
            Size = new System.Drawing.Size(546, 717);
            tlpFromFile.ResumeLayout(false);
            tlpFromFile.PerformLayout();
            tlpFunction.ResumeLayout(false);
            tlpFunction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinGen).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxGen).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNbOfPointsGen).EndInit();
            tlpMain.ResumeLayout(false);
            tlpMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelFromFile;
        private System.Windows.Forms.TableLayoutPanel tlpFromFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxColumnSep;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxHeader;
        private System.Windows.Forms.Button buttonLoadFromFile;
        private System.Windows.Forms.Label labelFromFunction;
        private System.Windows.Forms.TableLayoutPanel tlpFunction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.ComboBox comboBoxGenFunc;
        private System.Windows.Forms.PropertyGrid propertyGridGenFunc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudMinGen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudMaxGen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudNbOfPointsGen;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
    }
}
