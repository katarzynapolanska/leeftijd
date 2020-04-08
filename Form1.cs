using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifstatement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckn1_Click(object sender, EventArgs e)
        {
            int sLeeftijd = Int32.Parse(txtLeeftijd.Text);
            if (sLeeftijd >= 18)
            {
                if (sLeeftijd >= 18 && sLeeftijd <= 25)
                {
                    MessageBox.Show("ID laten zien!!");
                }
                else MessageBox.Show("U mag bier drinken ipv water, dan heb je morgen een flinke kater!");
            }
            else MessageBox.Show("Je mag nog geen alcohol drinken.");
        }
    }
}
