using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Priority
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.WhiteSmoke;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.WhiteSmoke;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form np = new non_Preemptive();
            np.Show();
            this.Hide();
        }
    }
}
