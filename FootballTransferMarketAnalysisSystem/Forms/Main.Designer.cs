
namespace DotNetClips.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.AgeLabel = new System.Windows.Forms.Label();
            this.AgeBox = new System.Windows.Forms.ComboBox();
            this.FootLabel = new System.Windows.Forms.Label();
            this.StyleLabel = new System.Windows.Forms.Label();
            this.FootBox = new System.Windows.Forms.ComboBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.PotentialLabel = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.HeadLabel = new System.Windows.Forms.Label();
            this.ResultButton = new System.Windows.Forms.Button();
            this.AppMenu = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PotentialBox = new System.Windows.Forms.NumericUpDown();
            this.ValueBox = new System.Windows.Forms.NumericUpDown();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.LocateClipsButton = new System.Windows.Forms.Button();
            this.LoadingSpinner = new System.Windows.Forms.PictureBox();
            this.PositionBox = new System.Windows.Forms.ComboBox();
            this.ResultCountlabel = new System.Windows.Forms.Label();
            this.DataCountBox = new System.Windows.Forms.NumericUpDown();
            this.RandomizeButton = new System.Windows.Forms.Button();
            this.StyleBox = new System.Windows.Forms.ComboBox();
            this.AppMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PotentialBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataCountBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(9, 115);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(51, 13);
            this.AgeLabel.TabIndex = 7;
            this.AgeLabel.Text = "Max Age";
            // 
            // AgeBox
            // 
            this.AgeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AgeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgeBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeBox.FormattingEnabled = true;
            this.AgeBox.Location = new System.Drawing.Point(11, 131);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(121, 21);
            this.AgeBox.TabIndex = 8;
            // 
            // FootLabel
            // 
            this.FootLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FootLabel.AutoSize = true;
            this.FootLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FootLabel.Location = new System.Drawing.Point(278, 115);
            this.FootLabel.Name = "FootLabel";
            this.FootLabel.Size = new System.Drawing.Size(98, 13);
            this.FootLabel.TabIndex = 9;
            this.FootLabel.Text = "Max Market Value";
            // 
            // StyleLabel
            // 
            this.StyleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StyleLabel.AutoSize = true;
            this.StyleLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StyleLabel.Location = new System.Drawing.Point(144, 156);
            this.StyleLabel.Name = "StyleLabel";
            this.StyleLabel.Size = new System.Drawing.Size(54, 13);
            this.StyleLabel.TabIndex = 11;
            this.StyleLabel.Text = "Play Style";
            // 
            // FootBox
            // 
            this.FootBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FootBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FootBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FootBox.FormattingEnabled = true;
            this.FootBox.Location = new System.Drawing.Point(11, 172);
            this.FootBox.Name = "FootBox";
            this.FootBox.Size = new System.Drawing.Size(121, 21);
            this.FootBox.TabIndex = 14;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(8, 156);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(81, 13);
            this.PriceLabel.TabIndex = 13;
            this.PriceLabel.Text = "Preferred Foot";
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(98, 245);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(104, 27);
            this.ResetButton.TabIndex = 15;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // PotentialLabel
            // 
            this.PotentialLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PotentialLabel.AutoSize = true;
            this.PotentialLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotentialLabel.Location = new System.Drawing.Point(277, 156);
            this.PotentialLabel.Name = "PotentialLabel";
            this.PotentialLabel.Size = new System.Drawing.Size(77, 13);
            this.PotentialLabel.TabIndex = 18;
            this.PotentialLabel.Text = "Max Potential";
            // 
            // PositionLabel
            // 
            this.PositionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionLabel.Location = new System.Drawing.Point(144, 115);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(49, 13);
            this.PositionLabel.TabIndex = 16;
            this.PositionLabel.Text = "Position";
            // 
            // HeadLabel
            // 
            this.HeadLabel.AutoSize = true;
            this.HeadLabel.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLabel.Location = new System.Drawing.Point(57, 31);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(296, 64);
            this.HeadLabel.TabIndex = 0;
            this.HeadLabel.Text = "Football Transfer Market\r\nAnalysis System";
            this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultButton
            // 
            this.ResultButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResultButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultButton.Location = new System.Drawing.Point(98, 278);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(214, 27);
            this.ResultButton.TabIndex = 21;
            this.ResultButton.Text = "Get Result";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // AppMenu
            // 
            this.AppMenu.BackColor = System.Drawing.Color.Transparent;
            this.AppMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.AppMenu.Location = new System.Drawing.Point(0, 0);
            this.AppMenu.Name = "AppMenu";
            this.AppMenu.Size = new System.Drawing.Size(411, 24);
            this.AppMenu.TabIndex = 22;
            this.AppMenu.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // PotentialBox
            // 
            this.PotentialBox.Location = new System.Drawing.Point(280, 173);
            this.PotentialBox.Name = "PotentialBox";
            this.PotentialBox.Size = new System.Drawing.Size(120, 20);
            this.PotentialBox.TabIndex = 24;
            // 
            // ValueBox
            // 
            this.ValueBox.Location = new System.Drawing.Point(280, 132);
            this.ValueBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(120, 20);
            this.ValueBox.TabIndex = 25;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.Location = new System.Drawing.Point(208, 245);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(104, 27);
            this.BrowseButton.TabIndex = 27;
            this.BrowseButton.Text = "Select CLP File";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // LocateClipsButton
            // 
            this.LocateClipsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LocateClipsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LocateClipsButton.Location = new System.Drawing.Point(98, 212);
            this.LocateClipsButton.Name = "LocateClipsButton";
            this.LocateClipsButton.Size = new System.Drawing.Size(214, 27);
            this.LocateClipsButton.TabIndex = 28;
            this.LocateClipsButton.Text = "Locate CLIPS";
            this.LocateClipsButton.UseVisualStyleBackColor = true;
            this.LocateClipsButton.Click += new System.EventHandler(this.LocateClipsButton_Click);
            // 
            // LoadingSpinner
            // 
            this.LoadingSpinner.Image = ((System.Drawing.Image)(resources.GetObject("LoadingSpinner.Image")));
            this.LoadingSpinner.Location = new System.Drawing.Point(371, 0);
            this.LoadingSpinner.Name = "LoadingSpinner";
            this.LoadingSpinner.Size = new System.Drawing.Size(40, 40);
            this.LoadingSpinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadingSpinner.TabIndex = 29;
            this.LoadingSpinner.TabStop = false;
            this.LoadingSpinner.Visible = false;
            // 
            // PositionBox
            // 
            this.PositionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositionBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PositionBox.FormattingEnabled = true;
            this.PositionBox.Location = new System.Drawing.Point(147, 131);
            this.PositionBox.Name = "PositionBox";
            this.PositionBox.Size = new System.Drawing.Size(121, 21);
            this.PositionBox.TabIndex = 30;
            // 
            // ResultCountlabel
            // 
            this.ResultCountlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultCountlabel.AutoSize = true;
            this.ResultCountlabel.Location = new System.Drawing.Point(330, 214);
            this.ResultCountlabel.Name = "ResultCountlabel";
            this.ResultCountlabel.Size = new System.Drawing.Size(61, 13);
            this.ResultCountlabel.TabIndex = 32;
            this.ResultCountlabel.Text = "Data Count";
            // 
            // DataCountBox
            // 
            this.DataCountBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DataCountBox.Location = new System.Drawing.Point(333, 230);
            this.DataCountBox.Maximum = new decimal(new int[] {
            18945,
            0,
            0,
            0});
            this.DataCountBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DataCountBox.Name = "DataCountBox";
            this.DataCountBox.Size = new System.Drawing.Size(67, 20);
            this.DataCountBox.TabIndex = 33;
            this.DataCountBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DataCountBox.ValueChanged += new System.EventHandler(this.DataCountBox_ValueChanged);
            // 
            // RandomizeButton
            // 
            this.RandomizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RandomizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomizeButton.Location = new System.Drawing.Point(370, 260);
            this.RandomizeButton.Name = "RandomizeButton";
            this.RandomizeButton.Size = new System.Drawing.Size(30, 30);
            this.RandomizeButton.TabIndex = 35;
            this.RandomizeButton.Text = "R";
            this.RandomizeButton.UseVisualStyleBackColor = true;
            this.RandomizeButton.Click += new System.EventHandler(this.RandomizeButton_Click);
            // 
            // StyleBox
            // 
            this.StyleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StyleBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StyleBox.FormattingEnabled = true;
            this.StyleBox.Location = new System.Drawing.Point(147, 172);
            this.StyleBox.Name = "StyleBox";
            this.StyleBox.Size = new System.Drawing.Size(121, 21);
            this.StyleBox.TabIndex = 36;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 328);
            this.Controls.Add(this.StyleBox);
            this.Controls.Add(this.RandomizeButton);
            this.Controls.Add(this.DataCountBox);
            this.Controls.Add(this.ResultCountlabel);
            this.Controls.Add(this.PositionBox);
            this.Controls.Add(this.LoadingSpinner);
            this.Controls.Add(this.LocateClipsButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.PotentialBox);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.HeadLabel);
            this.Controls.Add(this.PotentialLabel);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.FootBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.StyleLabel);
            this.Controls.Add(this.FootLabel);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.AppMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.AppMenu;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Football Transfer Market Analysis System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.AppMenu.ResumeLayout(false);
            this.AppMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PotentialBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataCountBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.ComboBox AgeBox;
        private System.Windows.Forms.Label FootLabel;
        private System.Windows.Forms.Label StyleLabel;
        private System.Windows.Forms.ComboBox FootBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label PotentialLabel;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.MenuStrip AppMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown PotentialBox;
        private System.Windows.Forms.NumericUpDown ValueBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button LocateClipsButton;
        private System.Windows.Forms.PictureBox LoadingSpinner;
        private System.Windows.Forms.ComboBox PositionBox;
        private System.Windows.Forms.Label ResultCountlabel;
        private System.Windows.Forms.NumericUpDown DataCountBox;
        private System.Windows.Forms.Button RandomizeButton;
        private System.Windows.Forms.ComboBox StyleBox;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

