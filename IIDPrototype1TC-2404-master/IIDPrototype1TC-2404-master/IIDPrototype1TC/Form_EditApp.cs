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
    public partial class Form_EditApp : Form
    {
        public Form_EditApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_MainMenu frm = new Form_MainMenu();
            frm.Show(this);
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_MenuApp frm = new Form_MenuApp();
            frm.Show(this);
            this.Hide();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            EditApp_SubForm myNewForm = new EditApp_SubForm();

            myNewForm.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.Equals("Appointment 1"))
            {
                textBox1.Text = "check up";
                textBox2.Text = "19/05/2018";
                textBox3.Text = "9:30am";
                textBox4.Text = "Dr.Dorian";
                textBox5.Text = "patient is recovering from an accident and needs to ensure revocry is going as planned";
            }

            if (listBox1.SelectedItem.Equals("Appointment 2"))
            {
                textBox1.Text = "surgery";
                textBox2.Text = "27/04/2018";
                textBox3.Text = "12:30pm";
                textBox4.Text = "Dr.Cox";
                textBox5.Text = "xxxxx";
            }

            if (listBox1.SelectedItem.Equals("Appointment 3"))
            {
                textBox1.Text = "physio-therapy";
                textBox2.Text = "29/04/2018";
                textBox3.Text = "7:30pm";
                textBox4.Text = "Dr.Celso";
                textBox5.Text = "xxxxx";
            }

            if (listBox1.SelectedItem.Equals("Appointment 4"))
            {
                textBox1.Text = "check up";
                textBox2.Text = "17/08/2018";
                textBox3.Text = "11:30am";
                textBox4.Text = "Dr.Reed";
                textBox5.Text = "xxxxx";
            }
        }
    }
}
