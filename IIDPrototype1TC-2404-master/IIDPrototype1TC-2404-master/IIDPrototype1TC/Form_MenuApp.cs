using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IIDPrototype1TC
{
    public partial class Form_MenuApp : Form
    {
        public Form_MenuApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_ViewApp frm = new Form_ViewApp();
            frm.Show(this);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_RequestApp frm = new Form_RequestApp();
            frm.Show(this);
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_EditApp frm = new Form_EditApp();
            frm.Show(this);
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_MainMenu frm = new Form_MainMenu();
            frm.Show(this);
            this.Hide();
        }
    }
}
