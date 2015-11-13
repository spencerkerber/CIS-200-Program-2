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
    public partial class Form1 : Form
    {
        internal List<Parcel> parcels;
        internal  List<Address> addresses;

        public Form1()
        {
            InitializeComponent();

           parcels = new List<Parcel>();      // List of parcels
           addresses = new List<Address>();   // List of addresses

           Address a1 = new Address("John Smith", "123 Any St.", "Apt. 45",
             "Louisville", "KY", 40202);                                                // Test Address 1
           Address a2 = new Address("Jane Doe", "987 Main St.", "",
               "Beverly Hills", "CA", 90210);                                           // Test Address 2
           Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
               "El Paso", "TX", 79901);                                                 // Test Address 3
           Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
               "Portland", "ME", 04101);                                                // Test Address 4

           Letter letter1 = new Letter(a1, a2, 3.95M);                                  // Letter test object
           GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);              // Ground test object
           NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,          // Next Day test object
               85, 7.50M);
           TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a1, 46.5, 39.5, 28.0,      // Two Day test object
               80.5, TwoDayAirPackage.Delivery.Saver);

           addresses.Add(a1);
           addresses.Add(a2);
           addresses.Add(a3);
           addresses.Add(a4);
           
           parcels.Add(letter1); 
           parcels.Add(gp1);
           parcels.Add(ndap1);
           parcels.Add(tdap1);
        }

        // Preconditions: None
        // Postconditions: Exit is clicked
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Preconditions: None
        // Postconditions: About is clicked
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Program 2{0}Spencer Kerber{0}" +
               "CIS 200-10{0}Summer 2015", System.Environment.NewLine), "About Program 2");
        }

        // Preconditions: None
        // Postconditions: Address is added
        public void addAddress(string name, string addressLine1, string addressLine2, string city,
            string state, int zip)
        {
            addresses.Add(new Address(name, addressLine1, addressLine2, city, state, zip));
        }

        // Preconditions: Insert address is clicked
        // Postconditions: Address is created 
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            AddressForm addressForm = new AddressForm();

            DialogResult result = addressForm.ShowDialog();

            Address myAddress;

            if(result==DialogResult.OK)
            {

                addresses.Add(addressForm.name, addressForm.addressLine1, addressForm.addressLine2, addressForm.city, addressForm.stateIndex.ToString(), addressForm.zip);
            }
            addressForm.Dispose();
        }

        // Preconditions: Insert Letter is clicked
        // Postconditions: Letter is created
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterform = new LetterForm();

            DialogResult result = letterform.ShowDialog();

            string originAddress;
            string destinationAddress;

            if (result == DialogResult.OK)
            {
                originAddress = letterform.originIndex.ToString();
                destinationAddress = letterform.destinationIndex.ToString();
            }
            letterform.Dispose();
        }

        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();

            foreach (Address address in addresses)
            {
                result.Append(address.ToString());
                result.Append(System.Environment.NewLine);
                result.Append(System.Environment.NewLine);
            }

            reportText.Text = result.ToString();
            reportText.SelectionStart = 0;
            
        }

        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();

            foreach (Parcel parcel in parcels)
            {
                result.Append(parcel.ToString());
                result.Append(System.Environment.NewLine);
                result.Append(System.Environment.NewLine);
            }
            reportText.Text = result.ToString();
            reportText.SelectionStart = 0;
        }
    }
}
