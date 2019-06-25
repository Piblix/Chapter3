using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatoe
{
    public partial class Form1 : Form
    {
        int statingMileage;
        int endindMileage;
        int milesTraveled;
        double rate = 0.39;
        double amountOwned;


        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(numericUpDown2.Value > numericUpDown1.Value)
            {
                statingMileage = (int)numericUpDown1.Value;
                endindMileage = (int)numericUpDown2.Value;
                milesTraveled = endindMileage - statingMileage;
                amountOwned = milesTraveled * rate;
                labelResult.Text = "$" + amountOwned;
            }
            else
            {
                MessageBox.Show("Start Mialedge can not be bigger then Ending Mileage");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + "miles", "Miles Traveled");
        }
    }
}
