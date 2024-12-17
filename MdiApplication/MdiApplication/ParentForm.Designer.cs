namespace MdiApplication
{
    partial class ParentForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentForm));
            MdiMenu = new MenuStrip();
            FileMenuItem = new ToolStripMenuItem();
            ExitMenuItem = new ToolStripMenuItem();
            NewMenuItem = new ToolStripMenuItem();
            WindowMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tileToolStripMenuItem = new ToolStripMenuItem();
            WindowTileMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            spWin = new ToolStripStatusLabel();
            spData = new ToolStripStatusLabel();
            MdiMenu.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MdiMenu
            // 
            MdiMenu.ImageScalingSize = new Size(20, 20);
            MdiMenu.Items.AddRange(new ToolStripItem[] { FileMenuItem, WindowMenuItem });
            MdiMenu.Location = new Point(0, 0);
            MdiMenu.Name = "MdiMenu";
            MdiMenu.Size = new Size(432, 28);
            MdiMenu.TabIndex = 1;
            MdiMenu.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            FileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ExitMenuItem, NewMenuItem });
            FileMenuItem.Name = "FileMenuItem";
            FileMenuItem.Size = new Size(46, 24);
            FileMenuItem.Text = "&File";
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(122, 26);
            ExitMenuItem.Text = "&Exit";
            ExitMenuItem.Click += ExitMenuItem_Click;
            // 
            // NewMenuItem
            // 
            NewMenuItem.Image = Properties.Resources.istockphoto_688550958_612x612;
            NewMenuItem.Name = "NewMenuItem";
            NewMenuItem.Size = new Size(122, 26);
            NewMenuItem.Text = "New";
            NewMenuItem.Click += NewMenuItem_Click;
            // 
            // WindowMenuItem
            // 
            WindowMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascadeToolStripMenuItem, tileToolStripMenuItem, WindowTileMenuItem });
            WindowMenuItem.Name = "WindowMenuItem";
            WindowMenuItem.Size = new Size(78, 24);
            WindowMenuItem.Text = "&Window";
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(269, 26);
            cascadeToolStripMenuItem.Text = "WindowCascadeMenuItem";
            // 
            // tileToolStripMenuItem
            // 
            tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            tileToolStripMenuItem.Size = new Size(269, 26);
            tileToolStripMenuItem.Text = "&Cascsde";
            tileToolStripMenuItem.Click += tileToolStripMenuItem_Click;
            // 
            // WindowTileMenuItem
            // 
            WindowTileMenuItem.Name = "WindowTileMenuItem";
            WindowTileMenuItem.Size = new Size(269, 26);
            WindowTileMenuItem.Text = "&Tile";
            WindowTileMenuItem.Click += WindowTileMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(432, 27);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Tag = "NewDoc";
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.ToolTipText = "Create new document";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Tag = "Cascade";
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.ToolTipText = "Windows cascade";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.istockphoto_688550958_612x612;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 24);
            toolStripButton3.Tag = "Title";
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.ToolTipText = "Windows title";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { spWin, spData });
            statusStrip1.Location = new Point(0, 277);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(432, 26);
            statusStrip1.TabIndex = 5;
            // 
            // spWin
            // 
            spWin.Name = "spWin";
            spWin.Size = new Size(49, 20);
            spWin.Text = "Status";
            // 
            // spData
            // 
            spData.Name = "spData";
            spData.Size = new Size(41, 20);
            spData.Text = "Data";
            // 
            // ParentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 303);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(MdiMenu);
            IsMdiContainer = true;
            MainMenuStrip = MdiMenu;
            Name = "ParentForm";
            Text = "ParentForm";
            MdiMenu.ResumeLayout(false);
            MdiMenu.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MdiMenu;
        private ToolStripMenuItem FileMenuItem;
        private ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem WindowMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem tileToolStripMenuItem;
        private ToolStripMenuItem WindowTileMenuItem;
        private ToolStripMenuItem NewMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel spWin;
        private ToolStripStatusLabel spData;
    }
}
