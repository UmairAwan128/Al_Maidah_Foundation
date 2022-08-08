namespace Al_Maidah_Foundation.Al_Maidah_Forms
{
    partial class PatientsForm
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
            this.MedCampIdcomboBox_Patient = new System.Windows.Forms.ComboBox();
            this.MedCampIdlabel_Patient = new System.Windows.Forms.Label();
            this.DocIdcomboBox_Patient = new System.Windows.Forms.ComboBox();
            this.DoctorIdlabel_Patient = new System.Windows.Forms.Label();
            this.btnClear_Patient = new System.Windows.Forms.Button();
            this.btnUpdate_Patient = new System.Windows.Forms.Button();
            this.btnDelete_Patient = new System.Windows.Forms.Button();
            this.btnAdd_Patient = new System.Windows.Forms.Button();
            this.GendercomboBox_Patient = new System.Windows.Forms.ComboBox();
            this.Genderlabel_Patient = new System.Windows.Forms.Label();
            this.AreatextBox_Patient = new System.Windows.Forms.TextBox();
            this.Arealabel_Patient = new System.Windows.Forms.Label();
            this.PhonetextBox_Patient = new System.Windows.Forms.TextBox();
            this.Phonelabel_Patient = new System.Windows.Forms.Label();
            this.AgetextBox_Patient = new System.Windows.Forms.TextBox();
            this.Agelabel_Patient = new System.Windows.Forms.Label();
            this.NameTextBox_Patient = new System.Windows.Forms.TextBox();
            this.Namelabel_Patient = new System.Windows.Forms.Label();
            this.dataGridView_Patient = new System.Windows.Forms.DataGridView();
            this.txtBoxPatientId = new System.Windows.Forms.TextBox();
            this.PatientIdlabel = new System.Windows.Forms.Label();
            this.txtBoxSearchPatient = new System.Windows.Forms.TextBox();
            this.lblSearchDoc = new System.Windows.Forms.Label();
            this.NameRadioButtonPatient = new System.Windows.Forms.RadioButton();
            this.AgeradioButtonPat = new System.Windows.Forms.RadioButton();
            this.ArearadioButtonPat = new System.Windows.Forms.RadioButton();
            this.DocIDradioButtonPat = new System.Windows.Forms.RadioButton();
            this.GenderradioButtonPat = new System.Windows.Forms.RadioButton();
            this.MedCampIDradioButtonPat = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Patient)).BeginInit();
            this.SuspendLayout();
            // 
            // MedCampIdcomboBox_Patient
            // 
            this.MedCampIdcomboBox_Patient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MedCampIdcomboBox_Patient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedCampIdcomboBox_Patient.FormattingEnabled = true;
            this.MedCampIdcomboBox_Patient.Location = new System.Drawing.Point(557, 248);
            this.MedCampIdcomboBox_Patient.Name = "MedCampIdcomboBox_Patient";
            this.MedCampIdcomboBox_Patient.Size = new System.Drawing.Size(219, 28);
            this.MedCampIdcomboBox_Patient.TabIndex = 14;
            // 
            // MedCampIdlabel_Patient
            // 
            this.MedCampIdlabel_Patient.AutoSize = true;
            this.MedCampIdlabel_Patient.BackColor = System.Drawing.Color.Transparent;
            this.MedCampIdlabel_Patient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedCampIdlabel_Patient.Location = new System.Drawing.Point(440, 250);
            this.MedCampIdlabel_Patient.Name = "MedCampIdlabel_Patient";
            this.MedCampIdlabel_Patient.Size = new System.Drawing.Size(113, 20);
            this.MedCampIdlabel_Patient.TabIndex = 93;
            this.MedCampIdlabel_Patient.Text = "Med Camp ID";
            // 
            // DocIdcomboBox_Patient
            // 
            this.DocIdcomboBox_Patient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DocIdcomboBox_Patient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocIdcomboBox_Patient.FormattingEnabled = true;
            this.DocIdcomboBox_Patient.ItemHeight = 20;
            this.DocIdcomboBox_Patient.Location = new System.Drawing.Point(114, 246);
            this.DocIdcomboBox_Patient.Name = "DocIdcomboBox_Patient";
            this.DocIdcomboBox_Patient.Size = new System.Drawing.Size(219, 28);
            this.DocIdcomboBox_Patient.TabIndex = 12;
            // 
            // DoctorIdlabel_Patient
            // 
            this.DoctorIdlabel_Patient.AutoSize = true;
            this.DoctorIdlabel_Patient.BackColor = System.Drawing.Color.Transparent;
            this.DoctorIdlabel_Patient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorIdlabel_Patient.Location = new System.Drawing.Point(12, 250);
            this.DoctorIdlabel_Patient.Name = "DoctorIdlabel_Patient";
            this.DoctorIdlabel_Patient.Size = new System.Drawing.Size(80, 20);
            this.DoctorIdlabel_Patient.TabIndex = 91;
            this.DoctorIdlabel_Patient.Text = "Doctor ID";
            // 
            // btnClear_Patient
            // 
            this.btnClear_Patient.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnClear_Patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear_Patient.ForeColor = System.Drawing.Color.White;
            this.btnClear_Patient.Location = new System.Drawing.Point(664, 294);
            this.btnClear_Patient.Name = "btnClear_Patient";
            this.btnClear_Patient.Size = new System.Drawing.Size(112, 37);
            this.btnClear_Patient.TabIndex = 22;
            this.btnClear_Patient.Text = "Clear";
            this.btnClear_Patient.UseVisualStyleBackColor = false;
            this.btnClear_Patient.Click += new System.EventHandler(this.btnClear_Patient_Click);
            // 
            // btnUpdate_Patient
            // 
            this.btnUpdate_Patient.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate_Patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_Patient.ForeColor = System.Drawing.Color.White;
            this.btnUpdate_Patient.Location = new System.Drawing.Point(256, 294);
            this.btnUpdate_Patient.Name = "btnUpdate_Patient";
            this.btnUpdate_Patient.Size = new System.Drawing.Size(112, 37);
            this.btnUpdate_Patient.TabIndex = 20;
            this.btnUpdate_Patient.Text = "Update";
            this.btnUpdate_Patient.UseVisualStyleBackColor = false;
            this.btnUpdate_Patient.Click += new System.EventHandler(this.btnUpdate_Patient_Click);
            // 
            // btnDelete_Patient
            // 
            this.btnDelete_Patient.BackColor = System.Drawing.Color.Red;
            this.btnDelete_Patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_Patient.ForeColor = System.Drawing.Color.White;
            this.btnDelete_Patient.Location = new System.Drawing.Point(138, 294);
            this.btnDelete_Patient.Name = "btnDelete_Patient";
            this.btnDelete_Patient.Size = new System.Drawing.Size(112, 37);
            this.btnDelete_Patient.TabIndex = 18;
            this.btnDelete_Patient.Text = "Delete";
            this.btnDelete_Patient.UseVisualStyleBackColor = false;
            this.btnDelete_Patient.Click += new System.EventHandler(this.btnDelete_Patient_Click);
            // 
            // btnAdd_Patient
            // 
            this.btnAdd_Patient.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAdd_Patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_Patient.ForeColor = System.Drawing.Color.White;
            this.btnAdd_Patient.Location = new System.Drawing.Point(20, 294);
            this.btnAdd_Patient.Name = "btnAdd_Patient";
            this.btnAdd_Patient.Size = new System.Drawing.Size(112, 37);
            this.btnAdd_Patient.TabIndex = 16;
            this.btnAdd_Patient.Text = "Add";
            this.btnAdd_Patient.UseVisualStyleBackColor = false;
            this.btnAdd_Patient.Click += new System.EventHandler(this.btnAdd_Patient_Click);
            // 
            // GendercomboBox_Patient
            // 
            this.GendercomboBox_Patient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GendercomboBox_Patient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GendercomboBox_Patient.FormattingEnabled = true;
            this.GendercomboBox_Patient.Location = new System.Drawing.Point(557, 198);
            this.GendercomboBox_Patient.Name = "GendercomboBox_Patient";
            this.GendercomboBox_Patient.Size = new System.Drawing.Size(219, 28);
            this.GendercomboBox_Patient.TabIndex = 10;
            // 
            // Genderlabel_Patient
            // 
            this.Genderlabel_Patient.AutoSize = true;
            this.Genderlabel_Patient.BackColor = System.Drawing.Color.Transparent;
            this.Genderlabel_Patient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genderlabel_Patient.Location = new System.Drawing.Point(440, 200);
            this.Genderlabel_Patient.Name = "Genderlabel_Patient";
            this.Genderlabel_Patient.Size = new System.Drawing.Size(66, 20);
            this.Genderlabel_Patient.TabIndex = 85;
            this.Genderlabel_Patient.Text = "Gender";
            // 
            // AreatextBox_Patient
            // 
            this.AreatextBox_Patient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreatextBox_Patient.Location = new System.Drawing.Point(114, 153);
            this.AreatextBox_Patient.Name = "AreatextBox_Patient";
            this.AreatextBox_Patient.Size = new System.Drawing.Size(662, 26);
            this.AreatextBox_Patient.TabIndex = 6;
            // 
            // Arealabel_Patient
            // 
            this.Arealabel_Patient.AutoSize = true;
            this.Arealabel_Patient.BackColor = System.Drawing.Color.Transparent;
            this.Arealabel_Patient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arealabel_Patient.Location = new System.Drawing.Point(16, 156);
            this.Arealabel_Patient.Name = "Arealabel_Patient";
            this.Arealabel_Patient.Size = new System.Drawing.Size(45, 20);
            this.Arealabel_Patient.TabIndex = 83;
            this.Arealabel_Patient.Text = "Area";
            // 
            // PhonetextBox_Patient
            // 
            this.PhonetextBox_Patient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhonetextBox_Patient.Location = new System.Drawing.Point(557, 111);
            this.PhonetextBox_Patient.Name = "PhonetextBox_Patient";
            this.PhonetextBox_Patient.Size = new System.Drawing.Size(219, 26);
            this.PhonetextBox_Patient.TabIndex = 4;
            this.PhonetextBox_Patient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhonetextBox_Patient_KeyPress);
            // 
            // Phonelabel_Patient
            // 
            this.Phonelabel_Patient.AutoSize = true;
            this.Phonelabel_Patient.BackColor = System.Drawing.Color.Transparent;
            this.Phonelabel_Patient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phonelabel_Patient.Location = new System.Drawing.Point(440, 114);
            this.Phonelabel_Patient.Name = "Phonelabel_Patient";
            this.Phonelabel_Patient.Size = new System.Drawing.Size(81, 20);
            this.Phonelabel_Patient.TabIndex = 81;
            this.Phonelabel_Patient.Text = "Phone No";
            // 
            // AgetextBox_Patient
            // 
            this.AgetextBox_Patient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgetextBox_Patient.Location = new System.Drawing.Point(114, 197);
            this.AgetextBox_Patient.Name = "AgetextBox_Patient";
            this.AgetextBox_Patient.Size = new System.Drawing.Size(219, 26);
            this.AgetextBox_Patient.TabIndex = 8;
            this.AgetextBox_Patient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AgetextBox_Patient_KeyPress);
            // 
            // Agelabel_Patient
            // 
            this.Agelabel_Patient.AutoSize = true;
            this.Agelabel_Patient.BackColor = System.Drawing.Color.Transparent;
            this.Agelabel_Patient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agelabel_Patient.Location = new System.Drawing.Point(16, 200);
            this.Agelabel_Patient.Name = "Agelabel_Patient";
            this.Agelabel_Patient.Size = new System.Drawing.Size(40, 20);
            this.Agelabel_Patient.TabIndex = 79;
            this.Agelabel_Patient.Text = "Age";
            // 
            // NameTextBox_Patient
            // 
            this.NameTextBox_Patient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox_Patient.Location = new System.Drawing.Point(114, 111);
            this.NameTextBox_Patient.Name = "NameTextBox_Patient";
            this.NameTextBox_Patient.Size = new System.Drawing.Size(219, 26);
            this.NameTextBox_Patient.TabIndex = 2;
            // 
            // Namelabel_Patient
            // 
            this.Namelabel_Patient.AutoSize = true;
            this.Namelabel_Patient.BackColor = System.Drawing.Color.Transparent;
            this.Namelabel_Patient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel_Patient.Location = new System.Drawing.Point(16, 114);
            this.Namelabel_Patient.Name = "Namelabel_Patient";
            this.Namelabel_Patient.Size = new System.Drawing.Size(53, 20);
            this.Namelabel_Patient.TabIndex = 77;
            this.Namelabel_Patient.Text = "Name";
            // 
            // dataGridView_Patient
            // 
            this.dataGridView_Patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Patient.Location = new System.Drawing.Point(20, 384);
            this.dataGridView_Patient.Name = "dataGridView_Patient";
            this.dataGridView_Patient.Size = new System.Drawing.Size(756, 148);
            this.dataGridView_Patient.TabIndex = 76;
            this.dataGridView_Patient.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Patient_RowHeaderMouseClick);
            // 
            // txtBoxPatientId
            // 
            this.txtBoxPatientId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPatientId.Location = new System.Drawing.Point(114, 71);
            this.txtBoxPatientId.Name = "txtBoxPatientId";
            this.txtBoxPatientId.ReadOnly = true;
            this.txtBoxPatientId.Size = new System.Drawing.Size(219, 26);
            this.txtBoxPatientId.TabIndex = 75;
            // 
            // PatientIdlabel
            // 
            this.PatientIdlabel.AutoSize = true;
            this.PatientIdlabel.BackColor = System.Drawing.Color.Transparent;
            this.PatientIdlabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientIdlabel.Location = new System.Drawing.Point(12, 74);
            this.PatientIdlabel.Name = "PatientIdlabel";
            this.PatientIdlabel.Size = new System.Drawing.Size(80, 20);
            this.PatientIdlabel.TabIndex = 74;
            this.PatientIdlabel.Text = "Patient ID";
            // 
            // txtBoxSearchPatient
            // 
            this.txtBoxSearchPatient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchPatient.Location = new System.Drawing.Point(83, 348);
            this.txtBoxSearchPatient.Name = "txtBoxSearchPatient";
            this.txtBoxSearchPatient.Size = new System.Drawing.Size(250, 26);
            this.txtBoxSearchPatient.TabIndex = 24;
            this.txtBoxSearchPatient.TextChanged += new System.EventHandler(this.txtBoxSearchPatient_TextChanged);
            // 
            // lblSearchDoc
            // 
            this.lblSearchDoc.AutoSize = true;
            this.lblSearchDoc.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchDoc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchDoc.Location = new System.Drawing.Point(16, 351);
            this.lblSearchDoc.Name = "lblSearchDoc";
            this.lblSearchDoc.Size = new System.Drawing.Size(64, 21);
            this.lblSearchDoc.TabIndex = 99;
            this.lblSearchDoc.Text = "Search";
            this.lblSearchDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameRadioButtonPatient
            // 
            this.NameRadioButtonPatient.AutoSize = true;
            this.NameRadioButtonPatient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameRadioButtonPatient.Location = new System.Drawing.Point(339, 351);
            this.NameRadioButtonPatient.Name = "NameRadioButtonPatient";
            this.NameRadioButtonPatient.Size = new System.Drawing.Size(66, 21);
            this.NameRadioButtonPatient.TabIndex = 26;
            this.NameRadioButtonPatient.TabStop = true;
            this.NameRadioButtonPatient.Text = "Name";
            this.NameRadioButtonPatient.UseVisualStyleBackColor = true;
            // 
            // AgeradioButtonPat
            // 
            this.AgeradioButtonPat.AutoSize = true;
            this.AgeradioButtonPat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeradioButtonPat.Location = new System.Drawing.Point(473, 351);
            this.AgeradioButtonPat.Name = "AgeradioButtonPat";
            this.AgeradioButtonPat.Size = new System.Drawing.Size(52, 21);
            this.AgeradioButtonPat.TabIndex = 30;
            this.AgeradioButtonPat.TabStop = true;
            this.AgeradioButtonPat.Text = "Age";
            this.AgeradioButtonPat.UseVisualStyleBackColor = true;
            // 
            // ArearadioButtonPat
            // 
            this.ArearadioButtonPat.AutoSize = true;
            this.ArearadioButtonPat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArearadioButtonPat.Location = new System.Drawing.Point(411, 350);
            this.ArearadioButtonPat.Name = "ArearadioButtonPat";
            this.ArearadioButtonPat.Size = new System.Drawing.Size(56, 21);
            this.ArearadioButtonPat.TabIndex = 28;
            this.ArearadioButtonPat.TabStop = true;
            this.ArearadioButtonPat.Text = "Area";
            this.ArearadioButtonPat.UseVisualStyleBackColor = true;
            // 
            // DocIDradioButtonPat
            // 
            this.DocIDradioButtonPat.AutoSize = true;
            this.DocIDradioButtonPat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocIDradioButtonPat.Location = new System.Drawing.Point(611, 350);
            this.DocIDradioButtonPat.Name = "DocIDradioButtonPat";
            this.DocIDradioButtonPat.Size = new System.Drawing.Size(66, 21);
            this.DocIDradioButtonPat.TabIndex = 34;
            this.DocIDradioButtonPat.TabStop = true;
            this.DocIDradioButtonPat.Text = "DocID";
            this.DocIDradioButtonPat.UseVisualStyleBackColor = true;
            // 
            // GenderradioButtonPat
            // 
            this.GenderradioButtonPat.AutoSize = true;
            this.GenderradioButtonPat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderradioButtonPat.Location = new System.Drawing.Point(531, 351);
            this.GenderradioButtonPat.Name = "GenderradioButtonPat";
            this.GenderradioButtonPat.Size = new System.Drawing.Size(74, 21);
            this.GenderradioButtonPat.TabIndex = 32;
            this.GenderradioButtonPat.TabStop = true;
            this.GenderradioButtonPat.Text = "Gender";
            this.GenderradioButtonPat.UseVisualStyleBackColor = true;
            // 
            // MedCampIDradioButtonPat
            // 
            this.MedCampIDradioButtonPat.AutoSize = true;
            this.MedCampIDradioButtonPat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedCampIDradioButtonPat.Location = new System.Drawing.Point(683, 351);
            this.MedCampIDradioButtonPat.Name = "MedCampIDradioButtonPat";
            this.MedCampIDradioButtonPat.Size = new System.Drawing.Size(109, 21);
            this.MedCampIDradioButtonPat.TabIndex = 100;
            this.MedCampIDradioButtonPat.TabStop = true;
            this.MedCampIDradioButtonPat.Text = "MedCampID";
            this.MedCampIDradioButtonPat.UseVisualStyleBackColor = true;
            // 
            // PatientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 544);
            this.Controls.Add(this.MedCampIDradioButtonPat);
            this.Controls.Add(this.DocIDradioButtonPat);
            this.Controls.Add(this.GenderradioButtonPat);
            this.Controls.Add(this.ArearadioButtonPat);
            this.Controls.Add(this.AgeradioButtonPat);
            this.Controls.Add(this.NameRadioButtonPatient);
            this.Controls.Add(this.txtBoxSearchPatient);
            this.Controls.Add(this.lblSearchDoc);
            this.Controls.Add(this.MedCampIdcomboBox_Patient);
            this.Controls.Add(this.MedCampIdlabel_Patient);
            this.Controls.Add(this.DocIdcomboBox_Patient);
            this.Controls.Add(this.DoctorIdlabel_Patient);
            this.Controls.Add(this.btnClear_Patient);
            this.Controls.Add(this.btnUpdate_Patient);
            this.Controls.Add(this.btnDelete_Patient);
            this.Controls.Add(this.btnAdd_Patient);
            this.Controls.Add(this.GendercomboBox_Patient);
            this.Controls.Add(this.Genderlabel_Patient);
            this.Controls.Add(this.AreatextBox_Patient);
            this.Controls.Add(this.Arealabel_Patient);
            this.Controls.Add(this.PhonetextBox_Patient);
            this.Controls.Add(this.Phonelabel_Patient);
            this.Controls.Add(this.AgetextBox_Patient);
            this.Controls.Add(this.Agelabel_Patient);
            this.Controls.Add(this.NameTextBox_Patient);
            this.Controls.Add(this.Namelabel_Patient);
            this.Controls.Add(this.dataGridView_Patient);
            this.Controls.Add(this.txtBoxPatientId);
            this.Controls.Add(this.PatientIdlabel);
            this.Name = "PatientsForm";
            this.Text = "PatientsForm";
            this.Load += new System.EventHandler(this.PatientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Patient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MedCampIdcomboBox_Patient;
        private System.Windows.Forms.Label MedCampIdlabel_Patient;
        private System.Windows.Forms.ComboBox DocIdcomboBox_Patient;
        private System.Windows.Forms.Label DoctorIdlabel_Patient;
        private System.Windows.Forms.Button btnClear_Patient;
        private System.Windows.Forms.Button btnUpdate_Patient;
        private System.Windows.Forms.Button btnDelete_Patient;
        private System.Windows.Forms.Button btnAdd_Patient;
        private System.Windows.Forms.ComboBox GendercomboBox_Patient;
        private System.Windows.Forms.Label Genderlabel_Patient;
        private System.Windows.Forms.TextBox AreatextBox_Patient;
        private System.Windows.Forms.Label Arealabel_Patient;
        private System.Windows.Forms.TextBox PhonetextBox_Patient;
        private System.Windows.Forms.Label Phonelabel_Patient;
        private System.Windows.Forms.TextBox AgetextBox_Patient;
        private System.Windows.Forms.Label Agelabel_Patient;
        private System.Windows.Forms.TextBox NameTextBox_Patient;
        private System.Windows.Forms.Label Namelabel_Patient;
        private System.Windows.Forms.DataGridView dataGridView_Patient;
        private System.Windows.Forms.TextBox txtBoxPatientId;
        private System.Windows.Forms.Label PatientIdlabel;
        private System.Windows.Forms.TextBox txtBoxSearchPatient;
        private System.Windows.Forms.Label lblSearchDoc;
        private System.Windows.Forms.RadioButton NameRadioButtonPatient;
        private System.Windows.Forms.RadioButton AgeradioButtonPat;
        private System.Windows.Forms.RadioButton ArearadioButtonPat;
        private System.Windows.Forms.RadioButton DocIDradioButtonPat;
        private System.Windows.Forms.RadioButton GenderradioButtonPat;
        private System.Windows.Forms.RadioButton MedCampIDradioButtonPat;
    }
}