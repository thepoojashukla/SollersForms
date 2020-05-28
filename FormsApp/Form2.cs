using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnTimeConsumingWork_Click(object sender, EventArgs e)
        {
            BtnTimeConsumingWork.Enabled = false;
            BtnTimeConsumingWork.Enabled = false;

            DoTimeConsumingWork();

            BtnTimeConsumingWork.Enabled = true;
            BtnTimeConsumingWork.Enabled = true;
        }

        private void DoTimeConsumingWork()
        {
            // Make the thread sleep, to introduce artifical latency
            Thread.Sleep(5000);
        }

        private void BtnPrintNumbers_Click(object sender, EventArgs e)
        {
            for (int i = 1; i<= 10; i++)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
