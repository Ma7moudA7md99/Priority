using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Priority
{
    public partial class non_Preemptive : Form
    {
        public non_Preemptive()
        {
            InitializeComponent();
        }

        private void solveBtn_Click(object sender, EventArgs e)
        {
            if(
                burstTB1.Text == "" || burstTB2.Text == ""
                || burstTB3.Text == "" || burstTB4.Text == ""
                || burstTB1.Text == "" || burstTB2.Text == ""
                || burstTB3.Text == "" || burstTB4.Text == ""
                || priorityTB1.Text == "" || priorityTB2.Text == ""
                || priorityTB3.Text == "" || priorityTB4.Text == ""
                || processTB1.Text == "" || processTB2.Text == ""
                || processTB3.Text == "" || processTB4.Text == ""
                )
            {
                MessageBox.Show("Enter value(s) First", "Priority", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double[] priority = new double[]
                {
                    Convert.ToDouble(priorityTB1.Text),
                    Convert.ToDouble(priorityTB2.Text),
                    Convert.ToDouble(priorityTB3.Text),
                    Convert.ToDouble(priorityTB4.Text)
                };
                for (int i = 0; i < priority.Length; i++)
                {
                    if (priority[i] <= 0)
                        MessageBox.Show("Priority must be greater than 0 ", "Priority", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                double[] burst = new double[]
                {
                    Convert.ToDouble(burstTB1.Text),
                    Convert.ToDouble(burstTB2.Text),
                    Convert.ToDouble(burstTB3.Text),
                    Convert.ToDouble(burstTB4.Text)
                };
                for (int i = 0; i < burst.Length; i++)
                {
                    if (burst[i] <= 0)
                        MessageBox.Show("Burst time must be greater than 0 ", "Priority", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string[] process = new string[]
                {
                    processTB1.Text,
                    processTB2.Text,
                    processTB3.Text,
                    processTB4.Text
                };


                double swapP, swapB;
                string swapProcess;
                // sorting arrays ascending to the priority
                for (int i = 0; i < priority.Length - 1; i++)
                {
                    for (int j = i + 1; j < priority.Length; j++)
                    {
                        if (priority[i] > priority[j])
                        {
                            // swapping priority
                            swapP = priority[i];
                            priority[i] = priority[j];
                            priority[j] = swapP;

                            // swapping burst
                            swapB = burst[i];
                            burst[i] = burst[j];
                            burst[j] = swapB;

                            // swapping process
                            swapProcess = process[i];
                            process[i] = process[j];
                            process[j] = swapProcess;

                        }
                    }
                }
                double[] times = new double[]
                {   0,
                    burst[0],
                    burst[0] + burst[1],
                    burst[0] + burst[1] + burst[2],
                    burst[0] + burst[1] + burst[2] + burst[3]
                };
                // gantt chart 
                // process 1
                timeLbl1.Text = "0";
                pLbl1.Text = process[0];
                timeLbl2.Text = Convert.ToString(times[1]);

                // process 2
                timeLbl3.Text = Convert.ToString(times[1]);
                pLbl2.Text = process[1];
                timeLbl4.Text = Convert.ToString(times[2]);

                // process 3
                timeLbl5.Text = Convert.ToString(times[2]);
                pLbl3.Text = process[2];
                timeLbl6.Text = Convert.ToString(times[3]);

                // process 4
                timeLbl7.Text = Convert.ToString(times[3]);
                pLbl4.Text = process[3];
                timeLbl8.Text = Convert.ToString(times[4]);

                // waiting time
                waitingTB1.Text = Convert.ToString(process[0] + " = " + times[0]);
                waitingTB2.Text = Convert.ToString(process[1] + " = " + times[1]);
                waitingTB3.Text = Convert.ToString(process[2] + " = " + times[2]);
                waitingTB4.Text = Convert.ToString(process[3] + " = " + times[3]);


                // average waiting time
                valuelbl.Text = Convert.ToString("( " + times[0] + " + " + times[1] + " + " + times[2] + " + " + times[3] + " ) / " + times.Length + " = " + ((times[0] + times[1] + times[2] + times[3]) / times.Length));
                valuelbl.Visible = true;
                awtlbl.Visible = true;
            } 
        }

        private void burstTB1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
