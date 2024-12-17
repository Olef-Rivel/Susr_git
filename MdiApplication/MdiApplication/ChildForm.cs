using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace MdiApplication
{
    public partial class ChildForm : Form
    {
        

        public ChildForm()
        {
            InitializeComponent();
           

            timer1.Interval = 1;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToggleMenuItem_Click(object sender, EventArgs e)
        {
            if (ToggleMenuItem.Checked)
            {
                ToggleMenuItem.Checked = false;
                ChildTextBox.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                ToggleMenuItem.Checked = true;
            }
        }

        private void ChildForm_Load(object sender, EventArgs e)
        {
             label1.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
