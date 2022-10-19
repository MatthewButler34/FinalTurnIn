
namespace FinalTurnIn
{
    partial class OptionsMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.HeightOfGrid = new System.Windows.Forms.Label();
            this.WidthOfGrid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HeightVal = new System.Windows.Forms.NumericUpDown();
            this.WidthVal = new System.Windows.Forms.NumericUpDown();
            this.TimerVal = new System.Windows.Forms.NumericUpDown();
            this.DoneButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimerVal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.DoneButton);
            this.panel1.Controls.Add(this.TimerVal);
            this.panel1.Controls.Add(this.WidthVal);
            this.panel1.Controls.Add(this.HeightVal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.WidthOfGrid);
            this.panel1.Controls.Add(this.HeightOfGrid);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 193);
            this.panel1.TabIndex = 0;
            // 
            // HeightOfGrid
            // 
            this.HeightOfGrid.AutoSize = true;
            this.HeightOfGrid.Location = new System.Drawing.Point(15, 25);
            this.HeightOfGrid.Name = "HeightOfGrid";
            this.HeightOfGrid.Size = new System.Drawing.Size(72, 13);
            this.HeightOfGrid.TabIndex = 0;
            this.HeightOfGrid.Text = "Height of Grid";
            // 
            // WidthOfGrid
            // 
            this.WidthOfGrid.AutoSize = true;
            this.WidthOfGrid.Location = new System.Drawing.Point(15, 67);
            this.WidthOfGrid.Name = "WidthOfGrid";
            this.WidthOfGrid.Size = new System.Drawing.Size(69, 13);
            this.WidthOfGrid.TabIndex = 1;
            this.WidthOfGrid.Text = "Width of Grid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time in milliseconds";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // HeightVal
            // 
            this.HeightVal.Location = new System.Drawing.Point(146, 23);
            this.HeightVal.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.HeightVal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HeightVal.Name = "HeightVal";
            this.HeightVal.Size = new System.Drawing.Size(62, 20);
            this.HeightVal.TabIndex = 3;
            this.HeightVal.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // WidthVal
            // 
            this.WidthVal.Location = new System.Drawing.Point(146, 60);
            this.WidthVal.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.WidthVal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthVal.Name = "WidthVal";
            this.WidthVal.Size = new System.Drawing.Size(62, 20);
            this.WidthVal.TabIndex = 4;
            this.WidthVal.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // TimerVal
            // 
            this.TimerVal.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.TimerVal.Location = new System.Drawing.Point(146, 99);
            this.TimerVal.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.TimerVal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TimerVal.Name = "TimerVal";
            this.TimerVal.Size = new System.Drawing.Size(62, 20);
            this.TimerVal.TabIndex = 5;
            this.TimerVal.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DoneButton.Location = new System.Drawing.Point(71, 142);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(85, 34);
            this.DoneButton.TabIndex = 8;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // OptionsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 185);
            this.Controls.Add(this.panel1);
            this.Name = "OptionsMenu";
            this.Text = "OptionsMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimerVal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label WidthOfGrid;
        private System.Windows.Forms.Label HeightOfGrid;
        private System.Windows.Forms.NumericUpDown TimerVal;
        private System.Windows.Forms.NumericUpDown WidthVal;
        private System.Windows.Forms.NumericUpDown HeightVal;
        private System.Windows.Forms.Button DoneButton;
    }
}