namespace MdiApplication
{
    partial class ChildForm
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
            components = new System.ComponentModel.Container();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ChildWindowMenu = new MenuStrip();
            FormatMenuItem = new ToolStripMenuItem();
            ToggleMenuItem = new ToolStripMenuItem();
            ChildTextBox = new RichTextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            ChildWindowMenu.SuspendLayout();
            SuspendLayout();
            // 
            // ChildWindowMenu
            // 
            ChildWindowMenu.ImageScalingSize = new Size(20, 20);
            ChildWindowMenu.Items.AddRange(new ToolStripItem[] { FormatMenuItem });
            ChildWindowMenu.Location = new Point(0, 0);
            ChildWindowMenu.Name = "ChildWindowMenu";
            ChildWindowMenu.Size = new Size(800, 28);
            ChildWindowMenu.TabIndex = 0;
            ChildWindowMenu.Text = "Format";
            // 
            // FormatMenuItem
            // 
            FormatMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ToggleMenuItem });
            FormatMenuItem.MergeAction = MergeAction.Insert;
            FormatMenuItem.Name = "FormatMenuItem";
            FormatMenuItem.Size = new Size(70, 24);
            FormatMenuItem.Text = "Format";
            // 
            // ToggleMenuItem
            // 
            ToggleMenuItem.Name = "ToggleMenuItem";
            ToggleMenuItem.Size = new Size(219, 26);
            ToggleMenuItem.Text = "Toggle Foreground";
            ToggleMenuItem.Click += ToggleMenuItem_Click;
            // 
            // ChildTextBox
            // 
            ChildTextBox.Dock = DockStyle.Fill;
            ChildTextBox.Location = new Point(0, 28);
            ChildTextBox.Name = "ChildTextBox";
            ChildTextBox.Size = new Size(800, 422);
            ChildTextBox.TabIndex = 1;
            ChildTextBox.Text = "";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(384, 126);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            // 
            // ChildForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(ChildTextBox);
            Controls.Add(ChildWindowMenu);
            MainMenuStrip = ChildWindowMenu;
            Name = "ChildForm";
            Text = "ChildForm";
            Load += ChildForm_Load;
            ChildWindowMenu.ResumeLayout(false);
            ChildWindowMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MenuStrip ChildWindowMenu;
        private ToolStripMenuItem FormatMenuItem;
        private ToolStripMenuItem ToggleMenuItem;
        private RichTextBox ChildTextBox;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}