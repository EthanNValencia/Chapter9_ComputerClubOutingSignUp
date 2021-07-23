using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter9_ComputerClubOutingSignUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            // The first two this.txtBoxResult... produce the same results, but have different signatures. 
            // this.txtBoxResult.Text = this.lstBoxEvents.SelectedItem.ToString(); // For the single select mode. 
            // this.txtBoxResult.Text = this.lstBoxEvents.Text; // For the single select mode. 
            string result = " ";
            foreach(string activity in lstBoxEvents.SelectedItems)
            {
                result += activity + " ";
            }
            this.txtBoxResult.Text = result;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            lstBoxEvents.Items.Add(txtBoxAddItem.Text);
            txtBoxAddItem.Clear();
        }
    }
}
