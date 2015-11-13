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
    public partial class AddressForm : Form
    {
        private List<Address> addresses;

        public AddressForm()
        {

            InitializeComponent();
        }

        public String name
        {
            // Preconditions: None
            // Postconditions: name is returned 
            get
            {
                return nameText.Text;
            }
            // Preconditions: None
            // Postconditions: name is set to the specified value
            set
            {
                nameText.Text = value;
            }
        }

        public String addressLine1
        {
            // Preconditions: None
            // Postconditions: Address Line 1 is returned 
            get
            {
                return addressLine1Text.Text;
            }
            // Preconditions: None
            // Postconditions: Address Line 1 is set to the specified value
            set
            {
                addressLine1Text.Text = value;
            }
        }

        public String addressLine2
        {
            // Preconditions: None
            // Postconditions: Address Line 2 is returned 
            get
            {
                return addressLine2Text.Text;
            }
            // Preconditions: None
            // Postconditions: Address Line 2 is set to the specified value
            set
            {
                addressLine2Text.Text = value;
            }
        }

        public String city
        {
            // Preconditions: None
            // Postconditions: City is returned 
            get
            {
                return cityText.Text;
            }
            // Preconditions: None
            // Postconditions: City is set to the specified value
            set
            {
                cityText.Text = value;
            }
        }

        private void AddressForm_Load(object sender, EventArgs e)
        {
            foreach (Address address in addresses)
                stateComboBox.Items.Add(address.State);
        }
        public int stateIndex
        {
            // Preconditions: None
            // Postconditions: combo box index is returned 
            get
            {
                return stateComboBox.SelectedIndex;
            }
        }

        public String zip
        {
            // Preconditions: None
            // Postconditions: Zip is returned 
            get
            {
                return zipText.Text;
            }
            // Preconditions: None
            // Postconditions: Zip is set to the specified value
            set
            {
                zipText.Text = value;
            }
        }

        // Preconditions: Focus is shifting from nameText
        // Postconditions: If text is invalid, focus remains and error provider
        //                 highlights the field
        private void nameTextValidating(object sender, CancelEventArgs e)
        {
            if (addressLine1Text.TextLength == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(addressLine1Text, "Must Provide Address");
            }
        }

        // Preconditions: Validating of nameText not cancelled, so data OK
        // Postconditions: Error provider cleared and focus allowed to change
        private void nameTextValidated(object sender, EventArgs e)
        {
            errorProvider.SetError(addressLine1Text, "");
        }

        // Preconditions: Focus is shifting from addressLine1Text 
        // Postconditions: If text is invalid, focus remains and error provider
        //                 highlights the field
        private void addressLine1TextValidating(object sender, CancelEventArgs e)
        {
            if(addressLine1Text.TextLength==0)
            {
                e.Cancel=true;
                errorProvider.SetError(addressLine1Text, "Must Provide Address");
            }
        }

        // Preconditions: Validating of addressLine1Text not cancelled, so data OK
        // Postconditions: Error provider cleared and focus allowed to change
        private void addressLine1TextValidated(object sender, EventArgs e)
        {
            errorProvider.SetError(addressLine1Text, "");
        }

        // Preconditions:  Focus is shifting from cityText
        // Postconditions: If text is invalid, focus remains and error provider
        //                 highlights the field
        private void cityTextValidating(object sender, CancelEventArgs e)
        {
            if (addressLine1Text.TextLength == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(addressLine1Text, "Must Provide Address");
            }
        }

        // Preconditions: Validating of cityText not cancelled, so data OK
        // Postconditions: Error provider cleared and focus allowed to change
        private void cityTextValidated(object sender, EventArgs e)
        {
            errorProvider.SetError(addressLine1Text, "");
        }

        // Preconditions: Focus is shifting from stateComboBox 
        // Postconditions: If text is invalid, focus remains and error provider
        //                 highlights the field
        private void stateComboBoxValidating(object sender, CancelEventArgs e)
        {
            if (stateComboBox.SelectedIndex == -1)
                e.Cancel = true;
            errorProvider.SetError(stateComboBox, "Must select state");
        }

        // Preconditions: Validating of stateComboBox not cancelled, so data OK
        // Postconditions: Error provider cleared and focus allowed to change
        private void stateComboBoxValidated(object sender, EventArgs e)
        {
            errorProvider.SetError(stateComboBox, "");
        }

        // Preconditions: Ok is clicked
        // Postconditions: Address is added
        private void AddressOKButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        // Preconditions: Focus is shifting from zipText 
        // Postconditions: If text is invalid, focus remains and error provider
        //                 highlights the field
        private void zipText_Validating(object sender, CancelEventArgs e)
        {
            int zip;            // Zip code
            bool valid = true;  // Tests zip code validity

            if (!int.TryParse(zipText.Text, out zip)) 
                valid = false;
            else if (zip < 0)
                valid = false;

            if (!valid) 
            {
                e.Cancel = true;
                zipText.SelectAll();
                errorProvider.SetError(zipText, "Invalid zip code");
            }
        }

        // Preconditions: Validating of zipText not cancelled, so data OK
        // Postconditions: Error provider cleared and focus allowed to change
        private void zipText_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(zipText, "");
        }

        // Preconditions: Cancel is clicked 
        // Postconditions: Form is closed 
        private void addressCancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
