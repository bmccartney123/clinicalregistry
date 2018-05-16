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
    public partial class Form_RequestApp : Form
    {
        public Form_RequestApp()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Column == 1)
            {
                e.Graphics.FillRectangle(Brushes.Transparent, e.CellBounds);
            }
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_CellPaint_1(object sender, TableLayoutCellPaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            dateTimePicker1.Text = "";
            textBox3.Clear();
            comboBox1.Text = "";
            textBox5.Clear();

            dateTimePicker1.Enabled = false;
            textBox3.Enabled = false;
            comboBox1.Enabled = false;
            textBox5.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if((textBox1.Text !="")&&(textBox3.Text != "")&&(textBox5.Text != "")&&(comboBox1.Text!=""))
            {
                bool cancel = false;

                string message = "Are you sure you all infromation in the reuest is correct?";
                string title = "Request Appointment";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    string update_message = "Your Appointment request has been sent";
                    string update_title = "Reuqest Appointment";
                    MessageBoxButtons button = MessageBoxButtons.OK;

                    DialogResult update = MessageBox.Show(update_message, update_title, button);
                    if (result == DialogResult.OK)
                    {

                        this.Close();
                    }
                    else { }
                    
                }
                else
                {
                    cancel = true;
                }



                if (cancel == false)
                {
                    Form_MainMenu frm = new Form_MainMenu();
                    frm.Show(this);
                    this.Hide(); ;

                }
                

            }
            else
            {
                MessageBox.Show("Error, Not All Fields Entered");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
        }

        private void dateTimePicker1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form_MainMenu frm = new Form_MainMenu();
            frm.Show(this);
            this.Hide(); ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_MenuApp frm = new Form_MenuApp();
            frm.Show(this);
            this.Hide();
        }
    } 
}
