// Spencer Kerber
// CIS 200-10
// Program 2
// GUI Parcel Program
// Due 6/11/15

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class LetterForm : Form
    {
        private List<Address> addresses;    // List of addresses

        // Preconditions: None
        // Postconditions: List of addresses is created 
        public LetterForm()
        {
            InitializeComponent();  
        }

        // Preconditions: Form is loaded
        // Postconditions: Combo boxes are populated 
        private void LetterForm_Load(object sender, EventArgs e)
        {
            foreach (Address address in addresses)
                originAddressComboBox.Items.Add(address.Name);

            foreach (Address address in addresses)
                destinationAddressComboBox.Items.Add(address.Name);
        }

        public int originIndex
        {
            // Preconditions: None
            // Postconditions: Origin address combo box index is returned 
            get
            {
                return originAddressComboBox.SelectedIndex;
            }
        }

        public int destinationIndex
        {
            // Preconditions: None
            // Postconditions: Destination address combo box index is returned 
            get
            {
                return destinationAddressComboBox.SelectedIndex;
            }
        }

        // Preconditions: Focus is shifting from originAddressComboBox
        // Postconditions: If text is invalid, focus remains and error provider
        //                 highlights the field
        private void originAddressComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (originAddressComboBox.SelectedIndex == -1) 
            {
                e.Cancel = true;
                errorProvider.SetError(originAddressComboBox, "Must select origin address");
            }
        }

        // Preconditions: Validating of originAddressComboBox not cancelled, so data OK
        // Postconditions: Error provider cleared and focus allowed to change
        private void originAddressComboBox_Validated(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(originAddressComboBox, "");
        }

        // Preconditions: Focus is shifting from destinationAddressComboBox
        // Postconditions: If text is invalid, focus remains and error provider
        //                 highlights the field
        private void destinationAddressComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (destinationAddressComboBox.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider.SetError(destinationAddressComboBox, "Must select destination address");
            }
        }

        // Preconditions: Validating of destinationAddressComboBox not cancelled, so data OK
        // Postconditions: Error provider cleared and focus allowed to change
        private void destinationAddressComboBox_Validated(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(destinationAddressComboBox, "");
        }

        // Preconditions: Ok is clicked 
        // Postconditions: Letter is added 
        private void letterOKButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        // Preconditions: Cancel is clicked 
        // Postconditions: Form closes
        private void letterCancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
