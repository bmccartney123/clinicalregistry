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
    public partial class Form_Prescriptions : Form
    {
        public Form_Prescriptions()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
                button3.Enabled = true;
            
             

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button6.Enabled = true;
            button3.Enabled = false;
            
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
            button4.Enabled = false; 

            if (listBox2.Items.Count== 0 )
            {
                button6.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox1.Items.Clear();

            listBox1.Items.Add("Inhaler");
            listBox1.Items.Add("Neoclaritan");
            listBox1.Items.Add("Paracetamal");
            listBox1.Items.Add("Piritin");
            listBox1.Items.Add("Ambioxindrill");

            
            button6.Enabled = false;
           
        }

        private void button6_Click(object sender, EventArgs e)
        {

            string message = "Are you sure your prescripiton order is correct?";
            string title = "Prescription Order";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                string update_message = "Presciption order has been sent";
                string update_title = "Prescription Order";
                MessageBoxButtons button = MessageBoxButtons.OK;

                DialogResult update = MessageBox.Show(update_message, update_title, button);
                if (result == DialogResult.OK)
                {

                    this.Close();
                }
                else { }
                this.Close();
            }
            else
            {

            }

            Form_MainMenu frm = new Form_MainMenu();
            frm.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_MainMenu frm = new Form_MainMenu();
            frm.Show(this);
            this.Hide();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
        }
    }
}
