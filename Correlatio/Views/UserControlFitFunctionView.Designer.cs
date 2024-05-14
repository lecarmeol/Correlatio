namespace PhysicsPlotter.Views
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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.tlpParam = new System.Windows.Forms.TableLayoutPanel();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.propertyGridGuess = new System.Windows.Forms.PropertyGrid();
            this.label5 = new System.Windows.Forms.Label();
            this.propertyGridFitFunc = new System.Windows.Forms.PropertyGrid();
            this.comboBoxFitFunc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxGenFunc = new System.Windows.Forms.ComboBox();
            this.propertyGridGenFunc = new System.Windows.Forms.PropertyGrid();
            this.buttonFit = new System.Windows.Forms.Button();
            this.tlpGeneratePoints = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.nudMinGen = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudMaxGen = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudNbOfPointsGen = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.tlpParam.SuspendLayout();
            this.tlpGeneratePoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbOfPointsGen)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.tlpParam);
            this.splitContainerMain.Size = new System.Drawing.Size(1188, 867);
            this.splitContainerMain.SplitterDistance = 402;
            this.splitContainerMain.SplitterWidth = 6;
            this.splitContainerMain.TabIndex = 0;
            // 
            // tlpParam
            // 
            this.tlpParam.ColumnCount = 2;
            this.tlpParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpParam.Controls.Add(this.buttonGenerate, 0, 4);
            this.tlpParam.Controls.Add(this.propertyGridGuess, 0, 9);
            this.tlpParam.Controls.Add(this.label5, 0, 8);
            this.tlpParam.Controls.Add(this.propertyGridFitFunc, 0, 7);
            this.tlpParam.Controls.Add(this.comboBoxFitFunc, 1, 6);
            this.tlpParam.Controls.Add(this.label4, 0, 6);
            this.tlpParam.Controls.Add(this.label3, 0, 5);
            this.tlpParam.Controls.Add(this.label1, 0, 0);
            this.tlpParam.Controls.Add(this.label2, 0, 1);
            this.tlpParam.Controls.Add(this.comboBoxGenFunc, 1, 1);
            this.tlpParam.Controls.Add(this.propertyGridGenFunc, 0, 2);
            this.tlpParam.Controls.Add(this.buttonFit, 0, 10);
            this.tlpParam.Controls.Add(this.tlpGeneratePoints, 0, 3);
            this.tlpParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpParam.Location = new System.Drawing.Point(0, 0);
            this.tlpParam.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tlpParam.Name = "tlpParam";
            this.tlpParam.RowCount = 11;
            this.tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpParam.Size = new System.Drawing.Size(402, 867);
            this.tlpParam.TabIndex = 0;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.AutoSize = true;
            this.tlpParam.SetColumnSpan(this.buttonGenerate, 2);
            this.buttonGenerate.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerate.Location = new System.Drawing.Point(3, 337);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(396, 32);
            this.buttonGenerate.TabIndex = 11;
            this.buttonGenerate.Text = "GENERATE";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // propertyGridGuess
            // 
            this.tlpParam.SetColumnSpan(this.propertyGridGuess, 2);
            this.propertyGridGuess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridGuess.Location = new System.Drawing.Point(3, 654);
            this.propertyGridGuess.Name = "propertyGridGuess";
            this.propertyGridGuess.Size = new System.Drawing.Size(396, 171);
            this.propertyGridGuess.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tlpParam.SetColumnSpan(this.label5, 2);
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 631);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(396, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Initial guesses: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // propertyGridFitFunc
            // 
            this.tlpParam.SetColumnSpan(this.propertyGridFitFunc, 2);
            this.propertyGridFitFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridFitFunc.Location = new System.Drawing.Point(3, 427);
            this.propertyGridFitFunc.Name = "propertyGridFitFunc";
            this.propertyGridFitFunc.Size = new System.Drawing.Size(396, 201);
            this.propertyGridFitFunc.TabIndex = 7;
            // 
            // comboBoxFitFunc
            // 
            this.comboBoxFitFunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxFitFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFitFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxFitFunc.FormattingEnabled = true;
            this.comboBoxFitFunc.Location = new System.Drawing.Point(141, 400);
            this.comboBoxFitFunc.Name = "comboBoxFitFunc";
            this.comboBoxFitFunc.Size = new System.Drawing.Size(258, 28);
            this.comboBoxFitFunc.TabIndex = 6;
            this.comboBoxFitFunc.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFitFunc_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type of function: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpParam.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Space Grotesk Light Medium", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 372);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(402, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "FUNCTION FIT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpParam.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Space Grotesk Light Medium", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "FUNCTION GENERATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type of function: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxGenFunc
            // 
            this.comboBoxGenFunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxGenFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGenFunc.FormattingEnabled = true;
            this.comboBoxGenFunc.Location = new System.Drawing.Point(141, 28);
            this.comboBoxGenFunc.Name = "comboBoxGenFunc";
            this.comboBoxGenFunc.Size = new System.Drawing.Size(258, 28);
            this.comboBoxGenFunc.TabIndex = 2;
            this.comboBoxGenFunc.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGenFunc_SelectedIndexChanged);
            // 
            // propertyGridGenFunc
            // 
            this.tlpParam.SetColumnSpan(this.propertyGridGenFunc, 2);
            this.propertyGridGenFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridGenFunc.Location = new System.Drawing.Point(3, 62);
            this.propertyGridGenFunc.Name = "propertyGridGenFunc";
            this.propertyGridGenFunc.Size = new System.Drawing.Size(396, 201);
            this.propertyGridGenFunc.TabIndex = 3;
            // 
            // buttonFit
            // 
            this.buttonFit.AutoSize = true;
            this.tlpParam.SetColumnSpan(this.buttonFit, 2);
            this.buttonFit.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFit.Location = new System.Drawing.Point(3, 831);
            this.buttonFit.Name = "buttonFit";
            this.buttonFit.Size = new System.Drawing.Size(396, 32);
            this.buttonFit.TabIndex = 10;
            this.buttonFit.Text = "FIT";
            this.buttonFit.UseVisualStyleBackColor = true;
            this.buttonFit.Click += new System.EventHandler(this.ButtonFit_Click);
            // 
            // tlpGeneratePoints
            // 
            this.tlpGeneratePoints.AutoSize = true;
            this.tlpGeneratePoints.ColumnCount = 4;
            this.tlpParam.SetColumnSpan(this.tlpGeneratePoints, 2);
            this.tlpGeneratePoints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpGeneratePoints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGeneratePoints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpGeneratePoints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGeneratePoints.Controls.Add(this.nudNbOfPointsGen, 1, 1);
            this.tlpGeneratePoints.Controls.Add(this.label8, 0, 1);
            this.tlpGeneratePoints.Controls.Add(this.nudMaxGen, 3, 0);
            this.tlpGeneratePoints.Controls.Add(this.label7, 2, 0);
            this.tlpGeneratePoints.Controls.Add(this.label6, 0, 0);
            this.tlpGeneratePoints.Controls.Add(this.nudMinGen, 1, 0);
            this.tlpGeneratePoints.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpGeneratePoints.Location = new System.Drawing.Point(3, 269);
            this.tlpGeneratePoints.Name = "tlpGeneratePoints";
            this.tlpGeneratePoints.RowCount = 2;
            this.tlpGeneratePoints.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGeneratePoints.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGeneratePoints.Size = new System.Drawing.Size(396, 62);
            this.tlpGeneratePoints.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = " Min:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudMinGen
            // 
            this.nudMinGen.DecimalPlaces = 4;
            this.nudMinGen.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudMinGen.Location = new System.Drawing.Point(106, 3);
            this.nudMinGen.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.nudMinGen.Minimum = new decimal(new int[] {
            1215752192,
            23,
            0,
            -2147483648});
            this.nudMinGen.Name = "nudMinGen";
            this.nudMinGen.Size = new System.Drawing.Size(115, 25);
            this.nudMinGen.TabIndex = 10;
            this.nudMinGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMinGen.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(227, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = " Max:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudMaxGen
            // 
            this.nudMaxGen.DecimalPlaces = 4;
            this.nudMaxGen.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudMaxGen.Location = new System.Drawing.Point(278, 3);
            this.nudMaxGen.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.nudMaxGen.Minimum = new decimal(new int[] {
            1215752192,
            23,
            0,
            -2147483648});
            this.nudMaxGen.Name = "nudMaxGen";
            this.nudMaxGen.Size = new System.Drawing.Size(115, 25);
            this.nudMaxGen.TabIndex = 12;
            this.nudMaxGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMaxGen.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 31);
            this.label8.TabIndex = 13;
            this.label8.Text = "Nb of points:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudNbOfPointsGen
            // 
            this.nudNbOfPointsGen.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudNbOfPointsGen.Location = new System.Drawing.Point(106, 34);
            this.nudNbOfPointsGen.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudNbOfPointsGen.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNbOfPointsGen.Name = "nudNbOfPointsGen";
            this.nudNbOfPointsGen.Size = new System.Drawing.Size(115, 25);
            this.nudNbOfPointsGen.TabIndex = 14;
            this.nudNbOfPointsGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNbOfPointsGen.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // UserControlFitFunctionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerMain);
            this.Font = new System.Drawing.Font("Space Grotesk Light", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UserControlFitFunctionView";
            this.Size = new System.Drawing.Size(1188, 867);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.tlpParam.ResumeLayout(false);
            this.tlpParam.PerformLayout();
            this.tlpGeneratePoints.ResumeLayout(false);
            this.tlpGeneratePoints.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbOfPointsGen)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.PropertyGrid propertyGridGuess;
        private System.Windows.Forms.Label label5;
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
