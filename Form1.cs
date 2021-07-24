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
            foreach(string activity in lstBoxEvents.SelectedItems) // Using SelectedItems
            {
                /*
                 * It is worth noting that to select multiple entries from a listbox it is necessary 
                 * to use .SelectedItems, .SelectedIndices, or .Items
                 * .SelectedIndices is a collection of indexes from 0-n. 
                 * If a listbox only allows for one selection then the no plural accessors can be used. 
                 * If a listbox only allows for one, then Text can be used too.
                 */
                result += activity + " ";
            }
            this.txtBoxResult.Text = result;

            this.txtBoxResult.Clear(); // Clears the box so that the second foreach example can populate the textbox. 

            foreach(int i in lstBoxEvents.SelectedIndices) // Using SelectedIndices 
            {
                /*
                 * The result of this foreach is pretty much the same as the above example, but it traverses
                 * the selected items in a different way. It uses the index of the selected items. 
                 */
                this.txtBoxResult.Text += this.lstBoxEvents.Items[i] + " ";
            }

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            lstBoxEvents.Items.Add(txtBoxAddItem.Text);
            txtBoxAddItem.Clear();
        }
    }
}
