namespace TestList
{
    partial class Form1
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
            groupeBox = new GroupBox();
            memberList = new CheckedListBox();
            peopleList = new ComboBox();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonSort = new Button();
            groupeBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupeBox
            // 
            groupeBox.Controls.Add(memberList);
            groupeBox.Location = new Point(23, 25);
            groupeBox.Name = "groupeBox";
            groupeBox.Size = new Size(236, 170);
            groupeBox.TabIndex = 0;
            groupeBox.TabStop = false;
            groupeBox.Text = "Список участников";
            // 
            // memberList
            // 
            memberList.FormattingEnabled = true;
            memberList.Location = new Point(6, 26);
            memberList.Name = "memberList";
            memberList.Size = new Size(150, 114);
            memberList.TabIndex = 0;
            // 
            // peopleList
            // 
            peopleList.BackColor = Color.Beige;
            peopleList.FormattingEnabled = true;
            peopleList.Items.AddRange(new object[] { "Пушло М.Н", "Позняк В.И", "Поня В.В" });
            peopleList.Location = new Point(23, 201);
            peopleList.Name = "peopleList";
            peopleList.Size = new Size(151, 28);
            peopleList.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(282, 50);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(282, 101);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(282, 155);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(94, 29);
            buttonSort.TabIndex = 4;
            buttonSort.Text = "Сортировать";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += buttonSort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(388, 259);
            Controls.Add(buttonSort);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(peopleList);
            Controls.Add(groupeBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Работа со списками";
            groupeBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupeBox;
        private CheckedListBox memberList;
        private ComboBox peopleList;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonSort;
    }
}
