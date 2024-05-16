namespace Correlatio.Views
{
    partial class UserControlFitFunctionView
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
            splitContainerMain = new System.Windows.Forms.SplitContainer();
            tlpParam = new System.Windows.Forms.TableLayoutPanel();
            buttonGenerate = new System.Windows.Forms.Button();
            propertyGridFitFunc = new System.Windows.Forms.PropertyGrid();
            comboBoxFitFunc = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            comboBoxGenFunc = new System.Windows.Forms.ComboBox();
            propertyGridGenFunc = new System.Windows.Forms.PropertyGrid();
            buttonFit = new System.Windows.Forms.Button();
            tlpGeneratePoints = new System.Windows.Forms.TableLayoutPanel();
            nudNbOfPointsGen = new System.Windows.Forms.NumericUpDown();
            label8 = new System.Windows.Forms.Label();
            nudMaxGen = new System.Windows.Forms.NumericUpDown();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            nudMinGen = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.SuspendLayout();
            tlpParam.SuspendLayout();
            tlpGeneratePoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNbOfPointsGen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxGen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinGen).BeginInit();
            SuspendLayout();
            // 
            // splitContainerMain
            // 
            splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainerMain.Location = new System.Drawing.Point(0, 0);
            splitContainerMain.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.Controls.Add(tlpParam);
            splitContainerMain.Size = new System.Drawing.Size(1188, 867);
            splitContainerMain.SplitterDistance = 402;
            splitContainerMain.SplitterWidth = 6;
            splitContainerMain.TabIndex = 0;
            // 
            // tlpParam
            // 
            tlpParam.ColumnCount = 2;
            tlpParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpParam.Controls.Add(buttonGenerate, 0, 4);
            tlpParam.Controls.Add(propertyGridFitFunc, 0, 7);
            tlpParam.Controls.Add(comboBoxFitFunc, 1, 6);
            tlpParam.Controls.Add(label4, 0, 6);
            tlpParam.Controls.Add(label3, 0, 5);
            tlpParam.Controls.Add(label1, 0, 0);
            tlpParam.Controls.Add(label2, 0, 1);
            tlpParam.Controls.Add(comboBoxGenFunc, 1, 1);
            tlpParam.Controls.Add(propertyGridGenFunc, 0, 2);
            tlpParam.Controls.Add(buttonFit, 0, 8);
            tlpParam.Controls.Add(tlpGeneratePoints, 0, 3);
            tlpParam.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpParam.Location = new System.Drawing.Point(0, 0);
            tlpParam.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            tlpParam.Name = "tlpParam";
            tlpParam.RowCount = 9;
            tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tlpParam.Size = new System.Drawing.Size(402, 867);
            tlpParam.TabIndex = 0;
            // 
            // buttonGenerate
            // 
            buttonGenerate.AutoSize = true;
            tlpParam.SetColumnSpan(buttonGenerate, 2);
            buttonGenerate.Dock = System.Windows.Forms.DockStyle.Top;
            buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonGenerate.Location = new System.Drawing.Point(3, 432);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new System.Drawing.Size(396, 32);
            buttonGenerate.TabIndex = 11;
            buttonGenerate.Text = "GENERATE";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += ButtonGenerate_Click;
            // 
            // propertyGridFitFunc
            // 
            tlpParam.SetColumnSpan(propertyGridFitFunc, 2);
            propertyGridFitFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            propertyGridFitFunc.Location = new System.Drawing.Point(3, 529);
            propertyGridFitFunc.Name = "propertyGridFitFunc";
            propertyGridFitFunc.Size = new System.Drawing.Size(396, 296);
            propertyGridFitFunc.TabIndex = 7;
            // 
            // comboBoxFitFunc
            // 
            comboBoxFitFunc.Dock = System.Windows.Forms.DockStyle.Top;
            comboBoxFitFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxFitFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboBoxFitFunc.FormattingEnabled = true;
            comboBoxFitFunc.Location = new System.Drawing.Point(141, 495);
            comboBoxFitFunc.Name = "comboBoxFitFunc";
            comboBoxFitFunc.Size = new System.Drawing.Size(258, 28);
            comboBoxFitFunc.TabIndex = 6;
            comboBoxFitFunc.SelectedIndexChanged += ComboBoxFitFunc_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Location = new System.Drawing.Point(3, 492);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(132, 34);
            label4.TabIndex = 5;
            label4.Text = "Type of function: ";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.SystemColors.ControlLight;
            tlpParam.SetColumnSpan(label3, 2);
            label3.Dock = System.Windows.Forms.DockStyle.Top;
            label3.Font = new System.Drawing.Font("Space Grotesk Light Medium", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(0, 467);
            label3.Margin = new System.Windows.Forms.Padding(0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(402, 25);
            label3.TabIndex = 4;
            label3.Text = "FUNCTION FIT";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.ControlLight;
            tlpParam.SetColumnSpan(label1, 2);
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Space Grotesk Light Medium", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Margin = new System.Windows.Forms.Padding(0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(402, 25);
            label1.TabIndex = 0;
            label1.Text = "FUNCTION GENERATION";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(3, 25);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(132, 34);
            label2.TabIndex = 1;
            label2.Text = "Type of function: ";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxGenFunc
            // 
            comboBoxGenFunc.Dock = System.Windows.Forms.DockStyle.Top;
            comboBoxGenFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxGenFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboBoxGenFunc.FormattingEnabled = true;
            comboBoxGenFunc.Location = new System.Drawing.Point(141, 28);
            comboBoxGenFunc.Name = "comboBoxGenFunc";
            comboBoxGenFunc.Size = new System.Drawing.Size(258, 28);
            comboBoxGenFunc.TabIndex = 2;
            comboBoxGenFunc.SelectedIndexChanged += ComboBoxGenFunc_SelectedIndexChanged;
            // 
            // propertyGridGenFunc
            // 
            tlpParam.SetColumnSpan(propertyGridGenFunc, 2);
            propertyGridGenFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            propertyGridGenFunc.Location = new System.Drawing.Point(3, 62);
            propertyGridGenFunc.Name = "propertyGridGenFunc";
            propertyGridGenFunc.Size = new System.Drawing.Size(396, 296);
            propertyGridGenFunc.TabIndex = 3;
            // 
            // buttonFit
            // 
            buttonFit.AutoSize = true;
            tlpParam.SetColumnSpan(buttonFit, 2);
            buttonFit.Dock = System.Windows.Forms.DockStyle.Top;
            buttonFit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonFit.Location = new System.Drawing.Point(3, 831);
            buttonFit.Name = "buttonFit";
            buttonFit.Size = new System.Drawing.Size(396, 32);
            buttonFit.TabIndex = 10;
            buttonFit.Text = "FIT";
            buttonFit.UseVisualStyleBackColor = true;
            buttonFit.Click += ButtonFit_Click;
            // 
            // tlpGeneratePoints
            // 
            tlpGeneratePoints.AutoSize = true;
            tlpGeneratePoints.ColumnCount = 4;
            tlpParam.SetColumnSpan(tlpGeneratePoints, 2);
            tlpGeneratePoints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpGeneratePoints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpGeneratePoints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpGeneratePoints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpGeneratePoints.Controls.Add(nudNbOfPointsGen, 1, 1);
            tlpGeneratePoints.Controls.Add(label8, 0, 1);
            tlpGeneratePoints.Controls.Add(nudMaxGen, 3, 0);
            tlpGeneratePoints.Controls.Add(label7, 2, 0);
            tlpGeneratePoints.Controls.Add(label6, 0, 0);
            tlpGeneratePoints.Controls.Add(nudMinGen, 1, 0);
            tlpGeneratePoints.Dock = System.Windows.Forms.DockStyle.Top;
            tlpGeneratePoints.Location = new System.Drawing.Point(3, 364);
            tlpGeneratePoints.Name = "tlpGeneratePoints";
            tlpGeneratePoints.RowCount = 2;
            tlpGeneratePoints.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGeneratePoints.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGeneratePoints.Size = new System.Drawing.Size(396, 62);
            tlpGeneratePoints.TabIndex = 12;
            // 
            // nudNbOfPointsGen
            // 
            nudNbOfPointsGen.Dock = System.Windows.Forms.DockStyle.Top;
            nudNbOfPointsGen.Location = new System.Drawing.Point(106, 34);
            nudNbOfPointsGen.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudNbOfPointsGen.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudNbOfPointsGen.Name = "nudNbOfPointsGen";
            nudNbOfPointsGen.Size = new System.Drawing.Size(115, 25);
            nudNbOfPointsGen.TabIndex = 14;
            nudNbOfPointsGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudNbOfPointsGen.Value = new decimal(new int[] { 21, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = System.Windows.Forms.DockStyle.Fill;
            label8.Location = new System.Drawing.Point(3, 31);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(97, 31);
            label8.TabIndex = 13;
            label8.Text = "Nb of points:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudMaxGen
            // 
            nudMaxGen.DecimalPlaces = 4;
            nudMaxGen.Dock = System.Windows.Forms.DockStyle.Top;
            nudMaxGen.Location = new System.Drawing.Point(278, 3);
            nudMaxGen.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            nudMaxGen.Minimum = new decimal(new int[] { 1215752192, 23, 0, int.MinValue });
            nudMaxGen.Name = "nudMaxGen";
            nudMaxGen.Size = new System.Drawing.Size(115, 25);
            nudMaxGen.TabIndex = 12;
            nudMaxGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudMaxGen.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = System.Windows.Forms.DockStyle.Fill;
            label7.Location = new System.Drawing.Point(227, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(45, 31);
            label7.TabIndex = 11;
            label7.Text = " Max:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = System.Windows.Forms.DockStyle.Fill;
            label6.Location = new System.Drawing.Point(3, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(97, 31);
            label6.TabIndex = 9;
            label6.Text = " Min:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudMinGen
            // 
            nudMinGen.DecimalPlaces = 4;
            nudMinGen.Dock = System.Windows.Forms.DockStyle.Top;
            nudMinGen.Location = new System.Drawing.Point(106, 3);
            nudMinGen.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            nudMinGen.Minimum = new decimal(new int[] { 1215752192, 23, 0, int.MinValue });
            nudMinGen.Name = "nudMinGen";
            nudMinGen.Size = new System.Drawing.Size(115, 25);
            nudMinGen.TabIndex = 10;
            nudMinGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudMinGen.Value = new decimal(new int[] { 10, 0, 0, int.MinValue });
            // 
            // UserControlFitFunctionView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(splitContainerMain);
            Font = new System.Drawing.Font("Space Grotesk Light", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            Name = "UserControlFitFunctionView";
            Size = new System.Drawing.Size(1188, 867);
            splitContainerMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            tlpParam.ResumeLayout(false);
            tlpParam.PerformLayout();
            tlpGeneratePoints.ResumeLayout(false);
            tlpGeneratePoints.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNbOfPointsGen).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxGen).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinGen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TableLayoutPanel tlpParam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxGenFunc;
        private System.Windows.Forms.PropertyGrid propertyGridGenFunc;
        private System.Windows.Forms.PropertyGrid propertyGridFitFunc;
        private System.Windows.Forms.ComboBox comboBoxFitFunc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonFit;
        private System.Windows.Forms.TableLayoutPanel tlpGeneratePoints;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudMinGen;
        private System.Windows.Forms.NumericUpDown nudMaxGen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudNbOfPointsGen;
        private System.Windows.Forms.Label label8;
    }
}
