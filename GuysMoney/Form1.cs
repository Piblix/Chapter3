using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuysMoney
{
    public partial class Form1 : Form
    {

        Guy joe;
        Guy bob;
        int bank = 100;
        public Form1()
        {
            InitializeComponent();
            bob = new Guy(){ Cash = 100, Name = "Bob" };
            joe = new Guy() { Cash = 50, Name = "Joe" };
            UpdateForm();           
        }

        private void UpdateForm()
        {
            bobText.Text = "Bob has " + bob.Cash + "$";
            joeText.Text = "Joe has " + joe.Cash + "$";
            bankText.Text = "Bank has " + bank + "$";

        }

        private void GiveButton_Click(object sender, EventArgs e)
        {
            if(bank >= 10)
            {
                bank -= joe.RecieveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out og money");
            }
        }

        private void ReceiveButton_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }
    }
}
