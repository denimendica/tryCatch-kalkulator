using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            int a, b, zbroj;

            try
            {
                a = Convert.ToInt32(txtBrojA.Text);
                b = Convert.ToInt32(txtBrojB.Text);
                zbroj = a + b;
                txtIspisB.Text = Convert.ToString(zbroj);
            }
            catch(Exception greska)
            {
                DialogResult poruka = MessageBox.Show(greska.Message, "Pogreška!", 
                    MessageBoxButtons.YesNoCancel, 
                    MessageBoxIcon.Error);
                if (poruka == DialogResult.Yes)
                { txtIspisB.Text = "Yes"; }
                else if (poruka == DialogResult.No)
                { txtIspisB.Text = "No"; }
                else { txtIspisB.Text = "Cancel"; }
            }
        }
    }
}
