namespace Al_Maidah_Foundation.Al_Maidah_Forms
{
    partial class DonationsForm
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
            this.PhonetextBox_Donation = new System.Windows.Forms.TextBox();
            this.Phonelabel_Donation = new System.Windows.Forms.Label();
            this.NameTextBox_Donation = new System.Windows.Forms.TextBox();
            this.Namelabel_Donation = new System.Windows.Forms.Label();
            this.btnClear_Donation = new System.Windows.Forms.Button();
            this.btnUpdate_Donation = new System.Windows.Forms.Button();
            this.btnDelete_Donation = new System.Windows.Forms.Button();
            this.btnAdd_Donation = new System.Windows.Forms.Button();
            this.DatedatePicker_Donation = new System.Windows.Forms.DateTimePicker();
            this.othertextBox_Donation = new System.Windows.Forms.TextBox();
            this.otherlabel_Donation = new System.Windows.Forms.Label();
            this.Datelabel_Donation = new System.Windows.Forms.Label();
            this.AmountTextBox_Donation = new System.Windows.Forms.TextBox();
            this.Amountlabel_Donation = new System.Windows.Forms.Label();
            this.dataGridView_Donation = new System.Windows.Forms.DataGridView();
            this.txtBoxDonId = new System.Windows.Forms.TextBox();
            this.DonationIdlabel = new System.Windows.Forms.Label();
            this.txtBoxSearchDonation = new System.Windows.Forms.TextBox();
            this.lblSearchDoc = new System.Windows.Forms.Label();
            this.OtherTyperadioButtonDon = new System.Windows.Forms.RadioButton();
            this.DateradioButtonDon = new System.Windows.Forms.RadioButton();
            this.NameRadioButtonDon = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Donation)).BeginInit();
            this.SuspendLayout();
            // 
            // PhonetextBox_Donation
            // 
            this.PhonetextBox_Donation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhonetextBox_Donation.Location = new System.Drawing.Point(562, 134);
            this.PhonetextBox_Donation.Name = "PhonetextBox_Donation";
            this.PhonetextBox_Donation.Size = new System.Drawing.Size(219, 26);
            this.PhonetextBox_Donation.TabIndex = 4;
            this.PhonetextBox_Donation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhonetextBox_Donation_KeyPress);
            // 
            // Phonelabel_Donation
            // 
            this.Phonelabel_Donation.AutoSize = true;
            this.Phonelabel_Donation.BackColor = System.Drawing.Color.Transparent;
            this.Phonelabel_Donation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phonelabel_Donation.Location = new System.Drawing.Point(445, 137);
            this.Phonelabel_Donation.Name = "Phonelabel_Donation";
            this.Phonelabel_Donation.Size = new System.Drawing.Size(81, 20);
            this.Phonelabel_Donation.TabIndex = 166;
            this.Phonelabel_Donation.Text = "Phone No";
            // 
            // NameTextBox_Donation
            // 
            this.NameTextBox_Donation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox_Donation.Location = new System.Drawing.Point(119, 134);
            this.NameTextBox_Donation.Name = "NameTextBox_Donation";
            this.NameTextBox_Donation.Size = new System.Drawing.Size(219, 26);
            this.NameTextBox_Donation.TabIndex = 2;
            // 
            // Namelabel_Donation
            // 
            this.Namelabel_Donation.AutoSize = true;
            this.Namelabel_Donation.BackColor = System.Drawing.Color.Transparent;
            this.Namelabel_Donation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel_Donation.Location = new System.Drawing.Point(21, 137);
            this.Namelabel_Donation.Name = "Namelabel_Donation";
            this.Namelabel_Donation.Size = new System.Drawing.Size(53, 20);
            this.Namelabel_Donation.TabIndex = 164;
            this.Namelabel_Donation.Text = "Name";
            // 
            // btnClear_Donation
            // 
            this.btnClear_Donation.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnClear_Donation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear_Donation.ForeColor = System.Drawing.Color.White;
            this.btnClear_Donation.Location = new System.Drawing.Point(669, 313);
            this.btnClear_Donation.Name = "btnClear_Donation";
            this.btnClear_Donation.Size = new System.Drawing.Size(112, 37);
            this.btnClear_Donation.TabIndex = 18;
            this.btnClear_Donation.Text = "Clear";
            this.btnClear_Donation.UseVisualStyleBackColor = false;
            this.btnClear_Donation.Click += new System.EventHandler(this.btnClear_Donation_Click);
            // 
            // btnUpdate_Donation
            // 
            this.btnUpdate_Donation.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate_Donation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_Donation.ForeColor = System.Drawing.Color.White;
            this.btnUpdate_Donation.Location = new System.Drawing.Point(261, 313);
            this.btnUpdate_Donation.Name = "btnUpdate_Donation";
            this.btnUpdate_Donation.Size = new System.Drawing.Size(112, 37);
            this.btnUpdate_Donation.TabIndex = 16;
            this.btnUpdate_Donation.Text = "Update";
            this.btnUpdate_Donation.UseVisualStyleBackColor = false;
            this.btnUpdate_Donation.Click += new System.EventHandler(this.btnUpdate_Donation_Click);
            // 
            // btnDelete_Donation
            // 
            this.btnDelete_Donation.BackColor = System.Drawing.Color.Red;
            this.btnDelete_Donation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_Donation.ForeColor = System.Drawing.Color.White;
            this.btnDelete_Donation.Location = new System.Drawing.Point(143, 313);
            this.btnDelete_Donation.Name = "btnDelete_Donation";
            this.btnDelete_Donation.Size = new System.Drawing.Size(112, 37);
            this.btnDelete_Donation.TabIndex = 14;
            this.btnDelete_Donation.Text = "Delete";
            this.btnDelete_Donation.UseVisualStyleBackColor = false;
            this.btnDelete_Donation.Click += new System.EventHandler(this.btnDelete_Donation_Click);
            // 
            // btnAdd_Donation
            // 
            this.btnAdd_Donation.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAdd_Donation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_Donation.ForeColor = System.Drawing.Color.White;
            this.btnAdd_Donation.Location = new System.Drawing.Point(25, 313);
            this.btnAdd_Donation.Name = "btnAdd_Donation";
            this.btnAdd_Donation.Size = new System.Drawing.Size(112, 37);
            this.btnAdd_Donation.TabIndex = 12;
            this.btnAdd_Donation.Text = "Add";
            this.btnAdd_Donation.UseVisualStyleBackColor = false;
            this.btnAdd_Donation.Click += new System.EventHandler(this.btnAdd_Donation_Click);
            // 
            // DatedatePicker_Donation
            // 
            this.DatedatePicker_Donation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatedatePicker_Donation.Location = new System.Drawing.Point(120, 264);
            this.DatedatePicker_Donation.Name = "DatedatePicker_Donation";
            this.DatedatePicker_Donation.Size = new System.Drawing.Size(661, 26);
            this.DatedatePicker_Donation.TabIndex = 10;
            // 
            // othertextBox_Donation
            // 
            this.othertextBox_Donation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othertextBox_Donation.Location = new System.Drawing.Point(562, 200);
            this.othertextBox_Donation.Name = "othertextBox_Donation";
            this.othertextBox_Donation.Size = new System.Drawing.Size(219, 26);
            this.othertextBox_Donation.TabIndex = 8;
            // 
            // otherlabel_Donation
            // 
            this.otherlabel_Donation.AutoSize = true;
            this.otherlabel_Donation.BackColor = System.Drawing.Color.Transparent;
            this.otherlabel_Donation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherlabel_Donation.Location = new System.Drawing.Point(445, 203);
            this.otherlabel_Donation.Name = "otherlabel_Donation";
            this.otherlabel_Donation.Size = new System.Drawing.Size(88, 20);
            this.otherlabel_Donation.TabIndex = 157;
            this.otherlabel_Donation.Text = "Other type";
            // 
            // Datelabel_Donation
            // 
            this.Datelabel_Donation.AutoSize = true;
            this.Datelabel_Donation.BackColor = System.Drawing.Color.Transparent;
            this.Datelabel_Donation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelabel_Donation.Location = new System.Drawing.Point(21, 264);
            this.Datelabel_Donation.Name = "Datelabel_Donation";
            this.Datelabel_Donation.Size = new System.Drawing.Size(45, 20);
            this.Datelabel_Donation.TabIndex = 156;
            this.Datelabel_Donation.Text = "Date";
            // 
            // AmountTextBox_Donation
            // 
            this.AmountTextBox_Donation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountTextBox_Donation.Location = new System.Drawing.Point(119, 200);
            this.AmountTextBox_Donation.Name = "AmountTextBox_Donation";
            this.AmountTextBox_Donation.Size = new System.Drawing.Size(219, 26);
            this.AmountTextBox_Donation.TabIndex = 6;
            this.AmountTextBox_Donation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountTextBox_Donation_KeyPress);
            // 
            // Amountlabel_Donation
            // 
            this.Amountlabel_Donation.AutoSize = true;
            this.Amountlabel_Donation.BackColor = System.Drawing.Color.Transparent;
            this.Amountlabel_Donation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amountlabel_Donation.Location = new System.Drawing.Point(21, 203);
            this.Amountlabel_Donation.Name = "Amountlabel_Donation";
            this.Amountlabel_Donation.Size = new System.Drawing.Size(70, 20);
            this.Amountlabel_Donation.TabIndex = 154;
            this.Amountlabel_Donation.Text = "Amount ";
            // 
            // dataGridView_Donation
            // 
            this.dataGridView_Donation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Donation.Location = new System.Drawing.Point(25, 414);
            this.dataGridView_Donation.Name = "dataGridView_Donation";
            this.dataGridView_Donation.Size = new System.Drawing.Size(756, 157);
            this.dataGridView_Donation.TabIndex = 28;
            this.dataGridView_Donation.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Donation_RowHeaderMouseClick);
            // 
            // txtBoxDonId
            // 
            this.txtBoxDonId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDonId.Location = new System.Drawing.Point(119, 74);
            this.txtBoxDonId.Name = "txtBoxDonId";
            this.txtBoxDonId.ReadOnly = true;
            this.txtBoxDonId.Size = new System.Drawing.Size(219, 26);
            this.txtBoxDonId.TabIndex = 152;
            // 
            // DonationIdlabel
            // 
            this.DonationIdlabel.AutoSize = true;
            this.DonationIdlabel.BackColor = System.Drawing.Color.Transparent;
            this.DonationIdlabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonationIdlabel.Location = new System.Drawing.Point(21, 77);
            this.DonationIdlabel.Name = "DonationIdlabel";
            this.DonationIdlabel.Size = new System.Drawing.Size(96, 20);
            this.DonationIdlabel.TabIndex = 151;
            this.DonationIdlabel.Text = "Donation ID";
            // 
            // txtBoxSearchDonation
            // 
            this.txtBoxSearchDonation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchDonation.Location = new System.Drawing.Point(88, 374);
            this.txtBoxSearchDonation.Name = "txtBoxSearchDonation";
            this.txtBoxSearchDonation.Size = new System.Drawing.Size(285, 26);
            this.txtBoxSearchDonation.TabIndex = 20;
            this.txtBoxSearchDonation.TextChanged += new System.EventHandler(this.txtBoxSearchDonation_TextChanged);
            // 
            // lblSearchDoc
            // 
            this.lblSearchDoc.AutoSize = true;
            this.lblSearchDoc.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchDoc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchDoc.Location = new System.Drawing.Point(21, 377);
            this.lblSearchDoc.Name = "lblSearchDoc";
            this.lblSearchDoc.Size = new System.Drawing.Size(64, 21);
            this.lblSearchDoc.TabIndex = 172;
            this.lblSearchDoc.Text = "Search";
            this.lblSearchDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OtherTyperadioButtonDon
            // 
            this.OtherTyperadioButtonDon.AutoSize = true;
            this.OtherTyperadioButtonDon.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtherTyperadioButtonDon.Location = new System.Drawing.Point(477, 373);
            this.OtherTyperadioButtonDon.Name = "OtherTyperadioButtonDon";
            this.OtherTyperadioButtonDon.Size = new System.Drawing.Size(110, 24);
            this.OtherTyperadioButtonDon.TabIndex = 26;
            this.OtherTyperadioButtonDon.TabStop = true;
            this.OtherTyperadioButtonDon.Text = "Other  type";
            this.OtherTyperadioButtonDon.UseVisualStyleBackColor = true;
            // 
            // DateradioButtonDon
            // 
            this.DateradioButtonDon.AutoSize = true;
            this.DateradioButtonDon.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateradioButtonDon.Location = new System.Drawing.Point(593, 373);
            this.DateradioButtonDon.Name = "DateradioButtonDon";
            this.DateradioButtonDon.Size = new System.Drawing.Size(63, 24);
            this.DateradioButtonDon.TabIndex = 26;
            this.DateradioButtonDon.TabStop = true;
            this.DateradioButtonDon.Text = "Date";
            this.DateradioButtonDon.UseVisualStyleBackColor = true;
            // 
            // NameRadioButtonDon
            // 
            this.NameRadioButtonDon.AutoSize = true;
            this.NameRadioButtonDon.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameRadioButtonDon.Location = new System.Drawing.Point(400, 374);
            this.NameRadioButtonDon.Name = "NameRadioButtonDon";
            this.NameRadioButtonDon.Size = new System.Drawing.Size(71, 24);
            this.NameRadioButtonDon.TabIndex = 22;
            this.NameRadioButtonDon.TabStop = true;
            this.NameRadioButtonDon.Text = "Name";
            this.NameRadioButtonDon.UseVisualStyleBackColor = true;
            // 
            // DonationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 583);
            this.Controls.Add(this.OtherTyperadioButtonDon);
            this.Controls.Add(this.DateradioButtonDon);
            this.Controls.Add(this.NameRadioButtonDon);
            this.Controls.Add(this.txtBoxSearchDonation);
            this.Controls.Add(this.lblSearchDoc);
            this.Controls.Add(this.PhonetextBox_Donation);
            this.Controls.Add(this.Phonelabel_Donation);
            this.Controls.Add(this.NameTextBox_Donation);
            this.Controls.Add(this.Namelabel_Donation);
            this.Controls.Add(this.btnClear_Donation);
            this.Controls.Add(this.btnUpdate_Donation);
            this.Controls.Add(this.btnDelete_Donation);
            this.Controls.Add(this.btnAdd_Donation);
            this.Controls.Add(this.DatedatePicker_Donation);
            this.Controls.Add(this.othertextBox_Donation);
            this.Controls.Add(this.otherlabel_Donation);
            this.Controls.Add(this.Datelabel_Donation);
            this.Controls.Add(this.AmountTextBox_Donation);
            this.Controls.Add(this.Amountlabel_Donation);
            this.Controls.Add(this.dataGridView_Donation);
            this.Controls.Add(this.txtBoxDonId);
            this.Controls.Add(this.DonationIdlabel);
            this.Name = "DonationsForm";
            this.Text = "DonationsForm";
            this.Load += new System.EventHandler(this.DonationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Donation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PhonetextBox_Donation;
        private System.Windows.Forms.Label Phonelabel_Donation;
        private System.Windows.Forms.TextBox NameTextBox_Donation;
        private System.Windows.Forms.Label Namelabel_Donation;
        private System.Windows.Forms.Button btnClear_Donation;
        private System.Windows.Forms.Button btnUpdate_Donation;
        private System.Windows.Forms.Button btnDelete_Donation;
        private System.Windows.Forms.Button btnAdd_Donation;
        private System.Windows.Forms.DateTimePicker DatedatePicker_Donation;
        private System.Windows.Forms.TextBox othertextBox_Donation;
        private System.Windows.Forms.Label otherlabel_Donation;
        private System.Windows.Forms.Label Datelabel_Donation;
        private System.Windows.Forms.TextBox AmountTextBox_Donation;
        private System.Windows.Forms.Label Amountlabel_Donation;
        private System.Windows.Forms.DataGridView dataGridView_Donation;
        private System.Windows.Forms.TextBox txtBoxDonId;
        private System.Windows.Forms.Label DonationIdlabel;
        private System.Windows.Forms.TextBox txtBoxSearchDonation;
        private System.Windows.Forms.Label lblSearchDoc;
        private System.Windows.Forms.RadioButton OtherTyperadioButtonDon;
        private System.Windows.Forms.RadioButton DateradioButtonDon;
        private System.Windows.Forms.RadioButton NameRadioButtonDon;
    }
}