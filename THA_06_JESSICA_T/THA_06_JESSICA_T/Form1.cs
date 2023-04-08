using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_06_JESSICA_T
{
    public partial class Form1 : Form
    {
        public static int inputan;
        public Form1()
        {
            InitializeComponent();
        }

        private void label_set_Click(object sender, EventArgs e)
        {

        }

        private void button_Play_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (Convert.ToInt32(textBox_InputUser.Text) > 3)
            {
                if (Convert.ToInt32(textBox_InputUser.Text) >= 100)
                {
                    MessageBox.Show("whoy bnyak bgt apa ga cape??");
                }
                else
                {
                    inputan = Convert.ToInt32(textBox_InputUser.Text);
                    form2.Show();
                }
            }
            else
            {
                MessageBox.Show("Please input more than 3");
            }

        }

        private void textBox_InputUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
