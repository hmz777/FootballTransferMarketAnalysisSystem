
namespace DotNetClips.Forms
{
    partial class PlayerList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerList));
            this.label1 = new System.Windows.Forms.Label();
            this.PList = new BrightIdeasSoftware.FastDataListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label2 = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "The best players that match your parameters are:";
            // 
            // PList
            // 
            this.PList.AllColumns.Add(this.olvColumn1);
            this.PList.AllColumns.Add(this.olvColumn2);
            this.PList.AllColumns.Add(this.olvColumn5);
            this.PList.AllColumns.Add(this.olvColumn6);
            this.PList.AllColumns.Add(this.olvColumn3);
            this.PList.AllColumns.Add(this.olvColumn4);
            this.PList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PList.CellEditUseWholeCell = false;
            this.PList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn5,
            this.olvColumn6,
            this.olvColumn3,
            this.olvColumn4});
            this.PList.Cursor = System.Windows.Forms.Cursors.Default;
            this.PList.DataSource = null;
            this.PList.FullRowSelect = true;
            this.PList.HideSelection = false;
            this.PList.Location = new System.Drawing.Point(12, 49);
            this.PList.MultiSelect = false;
            this.PList.Name = "PList";
            this.PList.ShowGroups = false;
            this.PList.Size = new System.Drawing.Size(831, 389);
            this.PList.TabIndex = 2;
            this.PList.UseCompatibleStateImageBehavior = false;
            this.PList.View = System.Windows.Forms.View.Details;
            this.PList.VirtualMode = true;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Name";
            this.olvColumn1.MaximumWidth = 250;
            this.olvColumn1.MinimumWidth = 250;
            this.olvColumn1.Text = "Name";
            this.olvColumn1.Width = 250;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Age";
            this.olvColumn2.MaximumWidth = 75;
            this.olvColumn2.MinimumWidth = 75;
            this.olvColumn2.Text = "Age";
            this.olvColumn2.Width = 75;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "Potential";
            this.olvColumn5.MaximumWidth = 75;
            this.olvColumn5.MinimumWidth = 75;
            this.olvColumn5.Text = "Potential";
            this.olvColumn5.Width = 75;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "Value";
            this.olvColumn6.MaximumWidth = 120;
            this.olvColumn6.MinimumWidth = 120;
            this.olvColumn6.Text = "Value (€)";
            this.olvColumn6.Width = 120;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Nationality";
            this.olvColumn3.MaximumWidth = 230;
            this.olvColumn3.MinimumWidth = 230;
            this.olvColumn3.Text = "Nationality";
            this.olvColumn3.Width = 230;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Club";
            this.olvColumn4.MaximumWidth = 250;
            this.olvColumn4.MinimumWidth = 250;
            this.olvColumn4.Text = "Club";
            this.olvColumn4.Width = 250;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(795, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result(s)";
            // 
            // CountLabel
            // 
            this.CountLabel.Location = new System.Drawing.Point(689, 16);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(100, 16);
            this.CountLabel.TabIndex = 4;
            this.CountLabel.Text = "0";
            this.CountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlayerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlayerList";
            this.ShowInTaskbar = false;
            this.Text = "Player List";
            this.Load += new System.EventHandler(this.PlayerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private BrightIdeasSoftware.FastDataListView PList;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CountLabel;
    }
}