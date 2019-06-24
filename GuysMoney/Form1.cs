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
            bankText.Text = "Bank has " + bank + "$;";

        }
    }
}
