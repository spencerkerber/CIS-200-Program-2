namespace Prog2
{
    partial class LetterForm
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
            this.originAddressComboBox = new System.Windows.Forms.ComboBox();
            this.destinationAddressComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.letterOKButton = new System.Windows.Forms.Button();
            this.letterCancelButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // originAddressComboBox
            // 
            this.originAddressComboBox.FormattingEnabled = true;
            this.originAddressComboBox.Location = new System.Drawing.Point(172, 43);
            this.originAddressComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.originAddressComboBox.Name = "originAddressComboBox";
            this.originAddressComboBox.Size = new System.Drawing.Size(270, 28);
            this.originAddressComboBox.TabIndex = 0;
            // 
            // destinationAddressComboBox
            // 
            this.destinationAddressComboBox.FormattingEnabled = true;
            this.destinationAddressComboBox.Location = new System.Drawing.Point(172, 85);
            this.destinationAddressComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.destinationAddressComboBox.Name = "destinationAddressComboBox";
            this.destinationAddressComboBox.Size = new System.Drawing.Size(270, 28);
            this.destinationAddressComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Origin Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination Address: ";
            // 
            // letterOKButton
            // 
            this.letterOKButton.Location = new System.Drawing.Point(103, 140);
            this.letterOKButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.letterOKButton.Name = "letterOKButton";
            this.letterOKButton.Size = new System.Drawing.Size(112, 35);
            this.letterOKButton.TabIndex = 4;
            this.letterOKButton.Text = "OK";
            this.letterOKButton.UseVisualStyleBackColor = true;
            this.letterOKButton.Click += new System.EventHandler(this.letterOKButton_Click);
            // 
            // letterCancelButton
            // 
            this.letterCancelButton.Location = new System.Drawing.Point(223, 140);
            this.letterCancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.letterCancelButton.Name = "letterCancelButton";
            this.letterCancelButton.Size = new System.Drawing.Size(112, 35);
            this.letterCancelButton.TabIndex = 5;
            this.letterCancelButton.Text = "Cancel";
            this.letterCancelButton.UseVisualStyleBackColor = true;
            this.letterCancelButton.Click += new System.EventHandler(this.letterCancelButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 6;
            // 
            // LetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 210);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.letterCancelButton);
            this.Controls.Add(this.letterOKButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destinationAddressComboBox);
            this.Controls.Add(this.originAddressComboBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LetterForm";
            this.Text = "Letter";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox originAddressComboBox;
        private System.Windows.Forms.ComboBox destinationAddressComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button letterOKButton;
        private System.Windows.Forms.Button letterCancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label3;
    }
}