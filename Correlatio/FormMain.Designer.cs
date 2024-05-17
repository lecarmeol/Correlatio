namespace Correlatio
{
    partial class FormMain
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            splitContainerMain = new System.Windows.Forms.SplitContainer();
            tlpParam = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainerMain
            // 
            splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainerMain.Location = new System.Drawing.Point(0, 0);
            splitContainerMain.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.Controls.Add(tlpParam);
            splitContainerMain.Size = new System.Drawing.Size(933, 519);
            splitContainerMain.SplitterDistance = 315;
            splitContainerMain.SplitterWidth = 6;
            splitContainerMain.TabIndex = 1;
            // 
            // tlpParam
            // 
            tlpParam.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tlpParam.ColumnCount = 1;
            tlpParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpParam.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpParam.Location = new System.Drawing.Point(0, 0);
            tlpParam.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            tlpParam.Name = "tlpParam";
            tlpParam.RowCount = 2;
            tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpParam.Size = new System.Drawing.Size(313, 517);
            tlpParam.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(splitContainerMain);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormMain";
            Text = "Correlatio";
            splitContainerMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TableLayoutPanel tlpParam;
    }
}

