namespace CSharpCompilerMVP
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.crystalDarkTheme = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.fileMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.newMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.openMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.saveAsMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem2 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.exitMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.editMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.undoMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.redoMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem3 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.cutMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.copyMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.pasteMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem4 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.selectAllMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.buildMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.runMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.helpMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.aboutMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.radPanel = new Telerik.WinControls.UI.RadPanel();
            this.runButton = new Telerik.WinControls.UI.RadButton();
            this.openFileButton = new Telerik.WinControls.UI.RadButton();
            this.newFileButton = new Telerik.WinControls.UI.RadButton();
            this.redoButton = new Telerik.WinControls.UI.RadButton();
            this.undoButton = new Telerik.WinControls.UI.RadButton();
            this.visualStudio2012DarkTheme = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.fluentDarkTheme = new Telerik.WinControls.Themes.FluentDarkTheme();
            this.radSplitContainer = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.radTreeView = new Telerik.WinControls.UI.RadTreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.radPageView = new Telerik.WinControls.UI.RadPageView();
            this.darkTheme = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.menuStripPanel = new Telerik.WinControls.UI.RadMenu();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel)).BeginInit();
            this.radPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFileButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newFileButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.undoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer)).BeginInit();
            this.radSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuStripPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.newMenuItem,
            this.openMenuItem,
            this.radMenuSeparatorItem1,
            this.saveAsMenuItem,
            this.radMenuSeparatorItem2,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Text = "File";
            // 
            // newMenuItem
            // 
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.Text = "New";
            this.newMenuItem.Click += new System.EventHandler(this.newMenuItem_Click);
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Text = "Open";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.Text = "Save As";
            this.saveAsMenuItem.Click += new System.EventHandler(this.saveAsMenuItem_Click);
            // 
            // radMenuSeparatorItem2
            // 
            this.radMenuSeparatorItem2.Name = "radMenuSeparatorItem2";
            this.radMenuSeparatorItem2.Text = "radMenuSeparatorItem2";
            this.radMenuSeparatorItem2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.AutoSize = true;
            this.editMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.undoMenuItem,
            this.redoMenuItem,
            this.radMenuSeparatorItem3,
            this.cutMenuItem,
            this.copyMenuItem,
            this.pasteMenuItem,
            this.radMenuSeparatorItem4,
            this.selectAllMenuItem});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Text = "Edit";
            // 
            // undoMenuItem
            // 
            this.undoMenuItem.Name = "undoMenuItem";
            this.undoMenuItem.Text = "Undo";
            this.undoMenuItem.Click += new System.EventHandler(this.undoMenuItem_Click);
            // 
            // redoMenuItem
            // 
            this.redoMenuItem.Name = "redoMenuItem";
            this.redoMenuItem.Text = "Redo";
            this.redoMenuItem.Click += new System.EventHandler(this.redoMenuItem_Click);
            // 
            // radMenuSeparatorItem3
            // 
            this.radMenuSeparatorItem3.Name = "radMenuSeparatorItem3";
            this.radMenuSeparatorItem3.Text = "radMenuSeparatorItem3";
            this.radMenuSeparatorItem3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cutMenuItem
            // 
            this.cutMenuItem.Name = "cutMenuItem";
            this.cutMenuItem.Text = "Cut";
            this.cutMenuItem.Click += new System.EventHandler(this.cutMenuItem_Click);
            // 
            // copyMenuItem
            // 
            this.copyMenuItem.Name = "copyMenuItem";
            this.copyMenuItem.Text = "Copy";
            this.copyMenuItem.Click += new System.EventHandler(this.copyMenuItem_Click);
            // 
            // pasteMenuItem
            // 
            this.pasteMenuItem.Name = "pasteMenuItem";
            this.pasteMenuItem.Text = "Paste";
            this.pasteMenuItem.Click += new System.EventHandler(this.pasteMenuItem_Click);
            // 
            // radMenuSeparatorItem4
            // 
            this.radMenuSeparatorItem4.Name = "radMenuSeparatorItem4";
            this.radMenuSeparatorItem4.Text = "radMenuSeparatorItem4";
            this.radMenuSeparatorItem4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // selectAllMenuItem
            // 
            this.selectAllMenuItem.Name = "selectAllMenuItem";
            this.selectAllMenuItem.Text = "Select All";
            this.selectAllMenuItem.Click += new System.EventHandler(this.selectAllMenuItem_Click);
            // 
            // buildMenuItem
            // 
            this.buildMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.runMenuItem});
            this.buildMenuItem.Name = "buildMenuItem";
            this.buildMenuItem.Text = "Build";
            // 
            // runMenuItem
            // 
            this.runMenuItem.Name = "runMenuItem";
            this.runMenuItem.Text = "Run";
            this.runMenuItem.Click += new System.EventHandler(this.runMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.aboutMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Text = "Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Text = "About";
            // 
            // radPanel
            // 
            this.radPanel.Controls.Add(this.runButton);
            this.radPanel.Controls.Add(this.openFileButton);
            this.radPanel.Controls.Add(this.newFileButton);
            this.radPanel.Controls.Add(this.redoButton);
            this.radPanel.Controls.Add(this.undoButton);
            this.radPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel.Location = new System.Drawing.Point(0, 34);
            this.radPanel.Name = "radPanel";
            this.radPanel.Size = new System.Drawing.Size(1016, 33);
            this.radPanel.TabIndex = 1;
            this.radPanel.ThemeName = "CrystalDark";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel.GetChildAt(0).GetChildAt(1))).BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel.GetChildAt(0).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel.GetChildAt(0).GetChildAt(1))).AutoSize = true;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel.GetChildAt(0).GetChildAt(1))).Padding = new System.Windows.Forms.Padding(2);
            // 
            // runButton
            // 
            this.runButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.runButton.Image = ((System.Drawing.Image)(resources.GetObject("runButton.Image")));
            this.runButton.Location = new System.Drawing.Point(938, 0);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(78, 33);
            this.runButton.TabIndex = 2;
            this.runButton.Text = "Run";
            this.runButton.ThemeName = "FluentDark";
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.openFileButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.openFileButton.Image = ((System.Drawing.Image)(resources.GetObject("openFileButton.Image")));
            this.openFileButton.Location = new System.Drawing.Point(96, 0);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(32, 33);
            this.openFileButton.TabIndex = 2;
            this.openFileButton.Text = "radButton3";
            this.openFileButton.ThemeName = "FluentDark";
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // newFileButton
            // 
            this.newFileButton.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.newFileButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.newFileButton.Image = ((System.Drawing.Image)(resources.GetObject("newFileButton.Image")));
            this.newFileButton.Location = new System.Drawing.Point(64, 0);
            this.newFileButton.Name = "newFileButton";
            this.newFileButton.Size = new System.Drawing.Size(32, 33);
            this.newFileButton.TabIndex = 4;
            this.newFileButton.Text = "radButton5";
            this.newFileButton.ThemeName = "FluentDark";
            this.newFileButton.Click += new System.EventHandler(this.newFileButton_Click);
            // 
            // redoButton
            // 
            this.redoButton.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.redoButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.redoButton.Image = ((System.Drawing.Image)(resources.GetObject("redoButton.Image")));
            this.redoButton.Location = new System.Drawing.Point(32, 0);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(32, 33);
            this.redoButton.TabIndex = 1;
            this.redoButton.Text = "radButton2";
            this.redoButton.ThemeName = "FluentDark";
            this.redoButton.Click += new System.EventHandler(this.redoButton_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.redoButton.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.redoButton.GetChildAt(0))).DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            ((Telerik.WinControls.UI.RadButtonElement)(this.redoButton.GetChildAt(0))).Text = "radButton2";
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.redoButton.GetChildAt(0).GetChildAt(1))).Enabled = true;
            // 
            // undoButton
            // 
            this.undoButton.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.undoButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.undoButton.Image = ((System.Drawing.Image)(resources.GetObject("undoButton.Image")));
            this.undoButton.Location = new System.Drawing.Point(0, 0);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(32, 33);
            this.undoButton.TabIndex = 0;
            this.undoButton.Text = "radButton1";
            this.undoButton.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.undoButton.ThemeName = "FluentDark";
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // radSplitContainer
            // 
            this.radSplitContainer.Controls.Add(this.splitPanel1);
            this.radSplitContainer.Controls.Add(this.splitPanel2);
            this.radSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSplitContainer.Location = new System.Drawing.Point(0, 67);
            this.radSplitContainer.Name = "radSplitContainer";
            // 
            // 
            // 
            this.radSplitContainer.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer.Size = new System.Drawing.Size(1016, 508);
            this.radSplitContainer.SplitterWidth = 3;
            this.radSplitContainer.TabIndex = 2;
            this.radSplitContainer.TabStop = false;
            this.radSplitContainer.ThemeName = "VisualStudio2012Dark";
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.radTreeView);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(265, 508);
            this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.2384008F, 0F);
            this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(-241, 0);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            this.splitPanel1.ThemeName = "VisualStudio2012Dark";
            // 
            // radTreeView
            // 
            this.radTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTreeView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radTreeView.ImageList = this.imageList;
            this.radTreeView.Location = new System.Drawing.Point(0, 0);
            this.radTreeView.Name = "radTreeView";
            this.radTreeView.Size = new System.Drawing.Size(265, 508);
            this.radTreeView.TabIndex = 0;
            this.radTreeView.ThemeName = "VisualStudio2012Dark";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "tree-view-folder-icon.png");
            this.imageList.Images.SetKeyName(1, "tree-view-file-icon.png");
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.radPageView);
            this.splitPanel2.Location = new System.Drawing.Point(268, 0);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(748, 508);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.2384008F, 0F);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(241, 0);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            this.splitPanel2.ThemeName = "VisualStudio2012Dark";
            // 
            // radPageView
            // 
            this.radPageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPageView.Location = new System.Drawing.Point(0, 0);
            this.radPageView.Name = "radPageView";
            this.radPageView.Size = new System.Drawing.Size(748, 508);
            this.radPageView.TabIndex = 0;
            this.radPageView.ThemeName = "VisualStudio2012Dark";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 575);
            // 
            // menuStripPanel
            // 
            this.menuStripPanel.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.buildMenuItem,
            this.helpMenuItem});
            this.menuStripPanel.Location = new System.Drawing.Point(0, 0);
            this.menuStripPanel.Name = "menuStripPanel";
            this.menuStripPanel.Size = new System.Drawing.Size(1016, 34);
            this.menuStripPanel.TabIndex = 0;
            this.menuStripPanel.ThemeName = "CrystalDark";
            this.Controls.Add(this.radSplitContainer);
            this.Controls.Add(this.radPanel);
            this.Controls.Add(this.menuStripPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(480, 320);
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# Compiler";
            this.ThemeName = "FluentDark";
            ((System.ComponentModel.ISupportInitialize)(this.radPanel)).EndInit();
            this.radPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.runButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFileButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newFileButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.undoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer)).EndInit();
            this.radSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPageView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuStripPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme;
        private Telerik.WinControls.UI.RadMenuItem fileMenuItem;
        private Telerik.WinControls.UI.RadMenuItem editMenuItem;
        private Telerik.WinControls.UI.RadMenuItem buildMenuItem;
        private Telerik.WinControls.UI.RadMenuItem helpMenuItem;
        private Telerik.WinControls.UI.RadMenuItem newMenuItem;
        private Telerik.WinControls.UI.RadMenuItem openMenuItem;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.UI.RadMenuItem saveAsMenuItem;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem2;
        private Telerik.WinControls.UI.RadMenuItem exitMenuItem;
        private Telerik.WinControls.UI.RadMenuItem undoMenuItem;
        private Telerik.WinControls.UI.RadMenuItem redoMenuItem;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem3;
        private Telerik.WinControls.UI.RadMenuItem cutMenuItem;
        private Telerik.WinControls.UI.RadMenuItem copyMenuItem;
        private Telerik.WinControls.UI.RadMenuItem pasteMenuItem;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem4;
        private Telerik.WinControls.UI.RadMenuItem selectAllMenuItem;
        private Telerik.WinControls.UI.RadMenuItem runMenuItem;
        private Telerik.WinControls.UI.RadMenuItem aboutMenuItem;
        private Telerik.WinControls.UI.RadPanel radPanel;
        private Telerik.WinControls.UI.RadButton redoButton;
        private Telerik.WinControls.UI.RadButton undoButton;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme;
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkTheme;
        private Telerik.WinControls.UI.RadButton openFileButton;
        private Telerik.WinControls.UI.RadButton newFileButton;
        private Telerik.WinControls.UI.RadButton runButton;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private Telerik.WinControls.UI.RadPageView radPageView;
        private Telerik.WinControls.UI.RadTreeView radTreeView;
        private System.Windows.Forms.ImageList imageList;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme darkTheme;
        private Telerik.WinControls.UI.RadMenu menuStripPanel;
    }
}