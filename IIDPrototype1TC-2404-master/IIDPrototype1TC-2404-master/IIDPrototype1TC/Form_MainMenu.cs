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
    public partial class Form_MainMenu : Form
    {
        public Form_MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Login frm = new Form_Login();
            frm.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_MenuApp frm = new Form_MenuApp();
            frm.Show(this);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Prescriptions frm = new Form_Prescriptions();
            frm.Show(this);
            this.Hide();
        }
    }
}
