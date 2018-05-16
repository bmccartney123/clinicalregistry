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
    public partial class EditApp_SubForm : Form
    {
        public EditApp_SubForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to update the changes made?";
            string title = "Update changes";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                string update_message = "Your update request has been sent";
                string update_title = "Update changes";
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

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to cancel?";
            string title = "Cancel changes";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }

        }
    }
}
