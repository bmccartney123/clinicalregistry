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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUserID.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "")
            {
                MessageBox.Show("Invaid UserName or Password");
                txtPassword.Clear();
                txtUserID.Clear();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Invaid UserName or Password");
                txtPassword.Clear();
                txtUserID.Clear();
            }
            else
            {
                
                Form_MainMenu frm = new Form_MainMenu();
                frm.Show(this);
                this.Hide();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to exit?";
            string title = "Shut Down";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                string update_message = "Thank you for using Magee Medical Appointment System";
                string update_title = "Shut Down";
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
        }
    }
}
