namespace Correlatio.Views
{
    partial class UserControlGraphView
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
            tlpMain = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            formsPlot = new ScottPlot.WinForms.FormsPlot();
            tlpExport = new System.Windows.Forms.TableLayoutPanel();
            buttonExportSvg = new System.Windows.Forms.Button();
            nudHeight = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            nudWidth = new System.Windows.Forms.NumericUpDown();
            buttonExportPng = new System.Windows.Forms.Button();
            tlpMain.SuspendLayout();
            tlpExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWidth).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpMain.Controls.Add(label1, 0, 0);
            tlpMain.Controls.Add(formsPlot, 0, 1);
            tlpMain.Controls.Add(tlpExport, 0, 2);
            tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpMain.Location = new System.Drawing.Point(0, 0);
            tlpMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpMain.Size = new System.Drawing.Size(747, 786);
            tlpMain.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.ControlLight;
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Space Grotesk Light Medium", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Margin = new System.Windows.Forms.Padding(0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(747, 25);
            label1.TabIndex = 1;
            label1.Text = "GRAPH VIEW";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formsPlot
            // 
            formsPlot.DisplayScale = 1F;
            formsPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            formsPlot.Location = new System.Drawing.Point(3, 31);
            formsPlot.Name = "formsPlot";
            formsPlot.Size = new System.Drawing.Size(741, 657);
            formsPlot.TabIndex = 2;
            // 
            // tlpExport
            // 
            tlpExport.AutoSize = true;
            tlpExport.BackColor = System.Drawing.Color.Gainsboro;
            tlpExport.ColumnCount = 4;
            tlpExport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpExport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpExport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpExport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpExport.Controls.Add(buttonExportSvg, 2, 2);
            tlpExport.Controls.Add(nudHeight, 3, 1);
            tlpExport.Controls.Add(label4, 2, 1);
            tlpExport.Controls.Add(label3, 0, 1);
            tlpExport.Controls.Add(label2, 0, 0);
            tlpExport.Controls.Add(nudWidth, 1, 1);
            tlpExport.Controls.Add(buttonExportPng, 0, 2);
            tlpExport.Dock = System.Windows.Forms.DockStyle.Left;
            tlpExport.Location = new System.Drawing.Point(3, 694);
            tlpExport.Name = "tlpExport";
            tlpExport.RowCount = 3;
            tlpExport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpExport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpExport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpExport.Size = new System.Drawing.Size(395, 89);
            tlpExport.TabIndex = 3;
            tlpExport.Visible = false;
            // 
            // buttonExportSvg
            // 
            buttonExportSvg.AutoSize = true;
            tlpExport.SetColumnSpan(buttonExportSvg, 2);
            buttonExportSvg.Dock = System.Windows.Forms.DockStyle.Top;
            buttonExportSvg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonExportSvg.Location = new System.Drawing.Point(198, 54);
            buttonExportSvg.Name = "buttonExportSvg";
            buttonExportSvg.Size = new System.Drawing.Size(194, 32);
            buttonExportSvg.TabIndex = 8;
            buttonExportSvg.Text = "Export as svg...";
            buttonExportSvg.UseVisualStyleBackColor = true;
            buttonExportSvg.Click += ButtonExportSvg_Click;
            // 
            // nudHeight
            // 
            nudHeight.Dock = System.Windows.Forms.DockStyle.Top;
            nudHeight.Location = new System.Drawing.Point(292, 23);
            nudHeight.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudHeight.Name = "nudHeight";
            nudHeight.Size = new System.Drawing.Size(100, 25);
            nudHeight.TabIndex = 6;
            nudHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudHeight.Value = new decimal(new int[] { 1080, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Location = new System.Drawing.Point(198, 20);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(88, 31);
            label4.TabIndex = 5;
            label4.Text = "Height (px):";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Location = new System.Drawing.Point(3, 20);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(83, 31);
            label3.TabIndex = 3;
            label3.Text = "Width (px):";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            tlpExport.SetColumnSpan(label2, 4);
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Font = new System.Drawing.Font("Space Grotesk Light", 10.25F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(3, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(389, 20);
            label2.TabIndex = 2;
            label2.Text = "Export graph";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudWidth
            // 
            nudWidth.Dock = System.Windows.Forms.DockStyle.Top;
            nudWidth.Location = new System.Drawing.Point(92, 23);
            nudWidth.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudWidth.Name = "nudWidth";
            nudWidth.Size = new System.Drawing.Size(100, 25);
            nudWidth.TabIndex = 4;
            nudWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudWidth.Value = new decimal(new int[] { 1920, 0, 0, 0 });
            // 
            // buttonExportPng
            // 
            buttonExportPng.AutoSize = true;
            tlpExport.SetColumnSpan(buttonExportPng, 2);
            buttonExportPng.Dock = System.Windows.Forms.DockStyle.Top;
            buttonExportPng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonExportPng.Location = new System.Drawing.Point(3, 54);
            buttonExportPng.Name = "buttonExportPng";
            buttonExportPng.Size = new System.Drawing.Size(189, 32);
            buttonExportPng.TabIndex = 7;
            buttonExportPng.Text = "Export as png...";
            buttonExportPng.UseVisualStyleBackColor = true;
            buttonExportPng.Click += ButtonExportPng_Click;
            // 
            // UserControlGraphView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tlpMain);
            Font = new System.Drawing.Font("Space Grotesk Light", 10.25F);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "UserControlGraphView";
            Size = new System.Drawing.Size(747, 786);
            tlpMain.ResumeLayout(false);
            tlpMain.PerformLayout();
            tlpExport.ResumeLayout(false);
            tlpExport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWidth).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label label1;
        private ScottPlot.WinForms.FormsPlot formsPlot;
        private System.Windows.Forms.TableLayoutPanel tlpExport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonExportPng;
        private System.Windows.Forms.Button buttonExportSvg;
    }
}
