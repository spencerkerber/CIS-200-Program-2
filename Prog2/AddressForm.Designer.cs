namespace Prog2
{
    partial class AddressForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addressLine1Text = new System.Windows.Forms.TextBox();
            this.addressLine2Text = new System.Windows.Forms.TextBox();
            this.cityText = new System.Windows.Forms.TextBox();
            this.zipText = new System.Windows.Forms.TextBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.AddressOKButton = new System.Windows.Forms.Button();
            this.addressCancelButton = new System.Windows.Forms.Button();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address Line 1: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address Line 2: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "State:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "ZIP Code:";
            // 
            // addressLine1Text
            // 
            this.addressLine1Text.Location = new System.Drawing.Point(132, 60);
            this.addressLine1Text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addressLine1Text.Name = "addressLine1Text";
            this.addressLine1Text.Size = new System.Drawing.Size(266, 26);
            this.addressLine1Text.TabIndex = 5;
            // 
            // addressLine2Text
            // 
            this.addressLine2Text.Location = new System.Drawing.Point(132, 100);
            this.addressLine2Text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addressLine2Text.Name = "addressLine2Text";
            this.addressLine2Text.Size = new System.Drawing.Size(266, 26);
            this.addressLine2Text.TabIndex = 6;
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(132, 140);
            this.cityText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(266, 26);
            this.cityText.TabIndex = 7;
            // 
            // zipText
            // 
            this.zipText.Location = new System.Drawing.Point(132, 222);
            this.zipText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zipText.Name = "zipText";
            this.zipText.Size = new System.Drawing.Size(148, 26);
            this.zipText.TabIndex = 8;
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(132, 180);
            this.stateComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(79, 28);
            this.stateComboBox.TabIndex = 9;
            // 
            // AddressOKButton
            // 
            this.AddressOKButton.Location = new System.Drawing.Point(52, 282);
            this.AddressOKButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddressOKButton.Name = "AddressOKButton";
            this.AddressOKButton.Size = new System.Drawing.Size(160, 35);
            this.AddressOKButton.TabIndex = 10;
            this.AddressOKButton.Text = "OK";
            this.AddressOKButton.UseVisualStyleBackColor = true;
            this.AddressOKButton.Click += new System.EventHandler(this.AddressOKButton_Click);
            // 
            // addressCancelButton
            // 
            this.addressCancelButton.Location = new System.Drawing.Point(222, 282);
            this.addressCancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addressCancelButton.Name = "addressCancelButton";
            this.addressCancelButton.Size = new System.Drawing.Size(160, 35);
            this.addressCancelButton.TabIndex = 11;
            this.addressCancelButton.Text = "Cancel";
            this.addressCancelButton.UseVisualStyleBackColor = true;
            this.addressCancelButton.Click += new System.EventHandler(this.addressCancelButton_Click);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(132, 23);
            this.nameText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(266, 26);
            this.nameText.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Name:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 345);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.addressCancelButton);
            this.Controls.Add(this.AddressOKButton);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.zipText);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.addressLine2Text);
            this.Controls.Add(this.addressLine1Text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddressForm";
            this.Text = "Address";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addressLine1Text;
        private System.Windows.Forms.TextBox addressLine2Text;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.TextBox zipText;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.Button AddressOKButton;
        private System.Windows.Forms.Button addressCancelButton;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}