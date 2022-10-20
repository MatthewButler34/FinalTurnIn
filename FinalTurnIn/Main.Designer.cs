
namespace FinalTurnIn
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NeighborCountShow = new System.Windows.Forms.ToolStripMenuItem();
            this.GridShow = new System.Windows.Forms.ToolStripMenuItem();
            this.HUDButton = new System.Windows.Forms.ToolStripMenuItem();
            this.More = new System.Windows.Forms.ToolStripMenuItem();
            this.GenHUDToggle = new System.Windows.Forms.ToolStripMenuItem();
            this.CellCountHUDToggle = new System.Windows.Forms.ToolStripMenuItem();
            this.BoundaryTypeHUDToggle = new System.Windows.Forms.ToolStripMenuItem();
            this.UniverseSizeHUDToggle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToroidalButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FiniteButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RandomizeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RandomizeCell = new System.Windows.Forms.ToolStripMenuItem();
            this.RandomizeGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeColorsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.GridLineButton = new System.Windows.Forms.ToolStripMenuItem();
            this.GridCellButton = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundButton = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.GenerationCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.CellAlive = new System.Windows.Forms.ToolStripStatusLabel();
            this.ColorPicker = new System.Windows.Forms.ColorDialog();
            this.OpenButton = new System.Windows.Forms.ToolStripButton();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.PlayButton = new System.Windows.Forms.ToolStripButton();
            this.PauseButton = new System.Windows.Forms.ToolStripButton();
            this.NextButton = new System.Windows.Forms.ToolStripButton();
            this.ClearButton = new System.Windows.Forms.ToolStripButton();
            this.ResetButton = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.graphicsPanel1 = new FinalTurnIn.GraphicsPanel();
            this.UniverseSizeLabelHUD = new System.Windows.Forms.Label();
            this.BoundaryTypeHUD = new System.Windows.Forms.Label();
            this.CellLabelHUD = new System.Windows.Forms.Label();
            this.GenerationLabelHUD = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.graphicsPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.RandomizeButton,
            this.SettingsButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(573, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(154, 30);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(151, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(154, 30);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NeighborCountShow,
            this.GridShow,
            this.HUDButton,
            this.More,
            this.toolStripSeparator3,
            this.ToroidalButton,
            this.FiniteButton});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "&View";
            // 
            // NeighborCountShow
            // 
            this.NeighborCountShow.Checked = true;
            this.NeighborCountShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NeighborCountShow.Name = "NeighborCountShow";
            this.NeighborCountShow.Size = new System.Drawing.Size(160, 22);
            this.NeighborCountShow.Text = "Neighbor Count";
            this.NeighborCountShow.Click += new System.EventHandler(this.NeighborCountShow_Click);
            // 
            // GridShow
            // 
            this.GridShow.Checked = true;
            this.GridShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GridShow.Name = "GridShow";
            this.GridShow.Size = new System.Drawing.Size(160, 22);
            this.GridShow.Text = "Grid";
            this.GridShow.Click += new System.EventHandler(this.GridShow_Click);
            // 
            // HUDButton
            // 
            this.HUDButton.Checked = true;
            this.HUDButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HUDButton.Name = "HUDButton";
            this.HUDButton.Size = new System.Drawing.Size(160, 22);
            this.HUDButton.Text = "HUD";
            this.HUDButton.Click += new System.EventHandler(this.HUDButton_Click);
            // 
            // More
            // 
            this.More.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenHUDToggle,
            this.CellCountHUDToggle,
            this.BoundaryTypeHUDToggle,
            this.UniverseSizeHUDToggle});
            this.More.Name = "More";
            this.More.Size = new System.Drawing.Size(160, 22);
            this.More.Text = "More";
            // 
            // GenHUDToggle
            // 
            this.GenHUDToggle.Checked = true;
            this.GenHUDToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GenHUDToggle.Name = "GenHUDToggle";
            this.GenHUDToggle.Size = new System.Drawing.Size(180, 22);
            this.GenHUDToggle.Text = "Generation HUD";
            this.GenHUDToggle.Click += new System.EventHandler(this.GenHUDToggle_Click);
            // 
            // CellCountHUDToggle
            // 
            this.CellCountHUDToggle.Checked = true;
            this.CellCountHUDToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CellCountHUDToggle.Name = "CellCountHUDToggle";
            this.CellCountHUDToggle.Size = new System.Drawing.Size(180, 22);
            this.CellCountHUDToggle.Text = "Cell Count HUD";
            this.CellCountHUDToggle.Click += new System.EventHandler(this.CellCountHUDToggle_Click);
            // 
            // BoundaryTypeHUDToggle
            // 
            this.BoundaryTypeHUDToggle.Checked = true;
            this.BoundaryTypeHUDToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BoundaryTypeHUDToggle.Name = "BoundaryTypeHUDToggle";
            this.BoundaryTypeHUDToggle.Size = new System.Drawing.Size(180, 22);
            this.BoundaryTypeHUDToggle.Text = "Boundary Type HUD";
            this.BoundaryTypeHUDToggle.Click += new System.EventHandler(this.BoundaryTypeHUDToggle_Click);
            // 
            // UniverseSizeHUDToggle
            // 
            this.UniverseSizeHUDToggle.Checked = true;
            this.UniverseSizeHUDToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UniverseSizeHUDToggle.Name = "UniverseSizeHUDToggle";
            this.UniverseSizeHUDToggle.Size = new System.Drawing.Size(180, 22);
            this.UniverseSizeHUDToggle.Text = "Universe Size HUD";
            this.UniverseSizeHUDToggle.Click += new System.EventHandler(this.UniverseSizeHUDToggle_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(157, 6);
            // 
            // ToroidalButton
            // 
            this.ToroidalButton.Checked = true;
            this.ToroidalButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToroidalButton.Name = "ToroidalButton";
            this.ToroidalButton.Size = new System.Drawing.Size(160, 22);
            this.ToroidalButton.Text = "Toroidal";
            this.ToroidalButton.Click += new System.EventHandler(this.ToroidalButton_Click);
            // 
            // FiniteButton
            // 
            this.FiniteButton.Name = "FiniteButton";
            this.FiniteButton.Size = new System.Drawing.Size(160, 22);
            this.FiniteButton.Text = "Finite";
            this.FiniteButton.Click += new System.EventHandler(this.FiniteButton_Click);
            // 
            // RandomizeButton
            // 
            this.RandomizeButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RandomizeCell,
            this.RandomizeGrid});
            this.RandomizeButton.Name = "RandomizeButton";
            this.RandomizeButton.Size = new System.Drawing.Size(78, 20);
            this.RandomizeButton.Text = "&Randomize";
            this.RandomizeButton.Click += new System.EventHandler(this.RandomizeButton_Click);
            // 
            // RandomizeCell
            // 
            this.RandomizeCell.Name = "RandomizeCell";
            this.RandomizeCell.Size = new System.Drawing.Size(158, 22);
            this.RandomizeCell.Text = "Randomize cell";
            this.RandomizeCell.Click += new System.EventHandler(this.RandomizeCell_Click);
            // 
            // RandomizeGrid
            // 
            this.RandomizeGrid.Name = "RandomizeGrid";
            this.RandomizeGrid.Size = new System.Drawing.Size(158, 22);
            this.RandomizeGrid.Text = "Randomize Grid";
            this.RandomizeGrid.Click += new System.EventHandler(this.RandomizeGrid_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsButton,
            this.ChangeColorsButton});
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(61, 20);
            this.SettingsButton.Text = "Settings";
            // 
            // OptionsButton
            // 
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(152, 22);
            this.OptionsButton.Text = "Options";
            this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // ChangeColorsButton
            // 
            this.ChangeColorsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GridLineButton,
            this.GridCellButton,
            this.BackgroundButton});
            this.ChangeColorsButton.Name = "ChangeColorsButton";
            this.ChangeColorsButton.Size = new System.Drawing.Size(152, 22);
            this.ChangeColorsButton.Text = "Change Colors";
            // 
            // GridLineButton
            // 
            this.GridLineButton.Name = "GridLineButton";
            this.GridLineButton.Size = new System.Drawing.Size(138, 22);
            this.GridLineButton.Text = "Grid Line";
            this.GridLineButton.Click += new System.EventHandler(this.GridLineButton_Click);
            // 
            // GridCellButton
            // 
            this.GridCellButton.Name = "GridCellButton";
            this.GridCellButton.Size = new System.Drawing.Size(138, 22);
            this.GridCellButton.Text = "Grid Cell";
            this.GridCellButton.Click += new System.EventHandler(this.GridCellButton_Click);
            // 
            // BackgroundButton
            // 
            this.BackgroundButton.Name = "BackgroundButton";
            this.BackgroundButton.Size = new System.Drawing.Size(138, 22);
            this.BackgroundButton.Text = "Background";
            this.BackgroundButton.Click += new System.EventHandler(this.BackgroundButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenerationCount,
            this.CellAlive});
            this.statusStrip1.Location = new System.Drawing.Point(0, 323);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(573, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // GenerationCount
            // 
            this.GenerationCount.Name = "GenerationCount";
            this.GenerationCount.Size = new System.Drawing.Size(82, 17);
            this.GenerationCount.Text = "Generations: 0";
            this.GenerationCount.Click += new System.EventHandler(this.GenerationCount_Click);
            // 
            // CellAlive
            // 
            this.CellAlive.Name = "CellAlive";
            this.CellAlive.Size = new System.Drawing.Size(45, 17);
            this.CellAlive.Text = "Alive: 0";
            this.CellAlive.Click += new System.EventHandler(this.CellAlive_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenButton.Image")));
            this.OpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(28, 28);
            this.OpenButton.Text = "&Open";
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(28, 28);
            this.SaveButton.Text = "&Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // PlayButton
            // 
            this.PlayButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PlayButton.Image = global::FinalTurnIn.Properties.Resources.playbutton;
            this.PlayButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(28, 28);
            this.PlayButton.Text = "toolStripButton1";
            this.PlayButton.ToolTipText = "Play";
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PauseButton.Enabled = false;
            this.PauseButton.Image = global::FinalTurnIn.Properties.Resources.pausebutton;
            this.PauseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(28, 28);
            this.PauseButton.Text = "toolStripButton1";
            this.PauseButton.ToolTipText = "Pause";
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextButton.Image = global::FinalTurnIn.Properties.Resources.nextbutton;
            this.NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(28, 28);
            this.NextButton.Text = "Next Generation";
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearButton.Image = global::FinalTurnIn.Properties.Resources.clearbutton;
            this.ClearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(28, 28);
            this.ClearButton.Text = "Clear";
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ResetButton.Image = global::FinalTurnIn.Properties.Resources.resetbutton;
            this.ResetButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(28, 28);
            this.ResetButton.Text = "Reset";
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenButton,
            this.SaveButton,
            this.toolStripSeparator6,
            this.PlayButton,
            this.PauseButton,
            this.NextButton,
            this.ClearButton,
            this.ResetButton,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(573, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // graphicsPanel1
            // 
            this.graphicsPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.graphicsPanel1.Controls.Add(this.UniverseSizeLabelHUD);
            this.graphicsPanel1.Controls.Add(this.BoundaryTypeHUD);
            this.graphicsPanel1.Controls.Add(this.CellLabelHUD);
            this.graphicsPanel1.Controls.Add(this.GenerationLabelHUD);
            this.graphicsPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanel1.Location = new System.Drawing.Point(0, 55);
            this.graphicsPanel1.Name = "graphicsPanel1";
            this.graphicsPanel1.Size = new System.Drawing.Size(573, 268);
            this.graphicsPanel1.TabIndex = 3;
            this.graphicsPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel1_Paint);
            this.graphicsPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_MouseClick);
            // 
            // UniverseSizeLabelHUD
            // 
            this.UniverseSizeLabelHUD.AutoSize = true;
            this.UniverseSizeLabelHUD.CausesValidation = false;
            this.UniverseSizeLabelHUD.Location = new System.Drawing.Point(12, 237);
            this.UniverseSizeLabelHUD.Name = "UniverseSizeLabelHUD";
            this.UniverseSizeLabelHUD.Size = new System.Drawing.Size(119, 17);
            this.UniverseSizeLabelHUD.TabIndex = 3;
            this.UniverseSizeLabelHUD.Text = "Universe Size: {20, 20}";
            this.UniverseSizeLabelHUD.UseCompatibleTextRendering = true;
            // 
            // BoundaryTypeHUD
            // 
            this.BoundaryTypeHUD.AutoSize = true;
            this.BoundaryTypeHUD.Location = new System.Drawing.Point(12, 215);
            this.BoundaryTypeHUD.Name = "BoundaryTypeHUD";
            this.BoundaryTypeHUD.Size = new System.Drawing.Size(128, 17);
            this.BoundaryTypeHUD.TabIndex = 2;
            this.BoundaryTypeHUD.Text = "Boundary Type: Toroidal";
            this.BoundaryTypeHUD.UseCompatibleTextRendering = true;
            // 
            // CellLabelHUD
            // 
            this.CellLabelHUD.AutoSize = true;
            this.CellLabelHUD.Location = new System.Drawing.Point(12, 192);
            this.CellLabelHUD.Name = "CellLabelHUD";
            this.CellLabelHUD.Size = new System.Drawing.Size(70, 17);
            this.CellLabelHUD.TabIndex = 1;
            this.CellLabelHUD.Text = "Cell Count: 0";
            this.CellLabelHUD.UseCompatibleTextRendering = true;
            this.CellLabelHUD.Click += new System.EventHandler(this.CellLabelHUD_Click);
            // 
            // GenerationLabelHUD
            // 
            this.GenerationLabelHUD.AutoSize = true;
            this.GenerationLabelHUD.Location = new System.Drawing.Point(12, 170);
            this.GenerationLabelHUD.Name = "GenerationLabelHUD";
            this.GenerationLabelHUD.Size = new System.Drawing.Size(78, 17);
            this.GenerationLabelHUD.TabIndex = 0;
            this.GenerationLabelHUD.Text = "Generations: 0";
            this.GenerationLabelHUD.UseCompatibleTextRendering = true;
            this.GenerationLabelHUD.Click += new System.EventHandler(this.GenerationLabelHUD_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 345);
            this.Controls.Add(this.graphicsPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Game Of Life - Matthew Butler";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.graphicsPanel1.ResumeLayout(false);
            this.graphicsPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private GraphicsPanel graphicsPanel1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel GenerationCount;
        private System.Windows.Forms.ToolStripStatusLabel CellAlive;
        private System.Windows.Forms.ToolStripMenuItem RandomizeButton;
        private System.Windows.Forms.ToolStripMenuItem SettingsButton;
        private System.Windows.Forms.ToolStripMenuItem OptionsButton;
        private System.Windows.Forms.ToolStripMenuItem ChangeColorsButton;
        private System.Windows.Forms.ToolStripMenuItem GridLineButton;
        private System.Windows.Forms.ToolStripMenuItem GridCellButton;
        private System.Windows.Forms.ToolStripMenuItem BackgroundButton;
        private System.Windows.Forms.ColorDialog ColorPicker;
        private System.Windows.Forms.ToolStripMenuItem NeighborCountShow;
        private System.Windows.Forms.ToolStripMenuItem GridShow;
        private System.Windows.Forms.ToolStripMenuItem HUDButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ToroidalButton;
        private System.Windows.Forms.ToolStripMenuItem FiniteButton;
        private System.Windows.Forms.ToolStripMenuItem More;
        private System.Windows.Forms.ToolStripMenuItem GenHUDToggle;
        private System.Windows.Forms.ToolStripMenuItem CellCountHUDToggle;
        private System.Windows.Forms.ToolStripMenuItem BoundaryTypeHUDToggle;
        private System.Windows.Forms.ToolStripMenuItem UniverseSizeHUDToggle;
        private System.Windows.Forms.ToolStripButton OpenButton;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton PlayButton;
        private System.Windows.Forms.ToolStripButton PauseButton;
        private System.Windows.Forms.ToolStripButton NextButton;
        private System.Windows.Forms.ToolStripButton ClearButton;
        private System.Windows.Forms.ToolStripButton ResetButton;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.Label UniverseSizeLabelHUD;
        public System.Windows.Forms.Label BoundaryTypeHUD;
        public System.Windows.Forms.Label CellLabelHUD;
        public System.Windows.Forms.Label GenerationLabelHUD;
        private System.Windows.Forms.ToolStripMenuItem RandomizeCell;
        private System.Windows.Forms.ToolStripMenuItem RandomizeGrid;
    }
}

