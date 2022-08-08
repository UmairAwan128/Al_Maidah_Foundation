namespace Al_Maidah_Foundation.Al_Maidah_Forms
{
    partial class MedDepForm
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
            this.MedDepNameTextBox_MedDep = new System.Windows.Forms.TextBox();
            this.MedDepNamelabel_MedDep = new System.Windows.Forms.Label();
            this.btnClear_MedDep = new System.Windows.Forms.Button();
            this.btnUpdate_MedDep = new System.Windows.Forms.Button();
            this.btnDelete_MedDep = new System.Windows.Forms.Button();
            this.btnAdd_MedDep = new System.Windows.Forms.Button();
            this.dataGridView_MedDep = new System.Windows.Forms.DataGridView();
            this.txtBoxMedDepID = new System.Windows.Forms.TextBox();
            this.MedDepIdlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MedDep)).BeginInit();
            this.SuspendLayout();
            // 
            // MedDepNameTextBox_MedDep
            // 
            this.MedDepNameTextBox_MedDep.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedDepNameTextBox_MedDep.Location = new System.Drawing.Point(141, 119);
            this.MedDepNameTextBox_MedDep.Name = "MedDepNameTextBox_MedDep";
            this.MedDepNameTextBox_MedDep.Size = new System.Drawing.Size(215, 26);
            this.MedDepNameTextBox_MedDep.TabIndex = 4;
            // 
            // MedDepNamelabel_MedDep
            // 
            this.MedDepNamelabel_MedDep.AutoSize = true;
            this.MedDepNamelabel_MedDep.BackColor = System.Drawing.Color.Transparent;
            this.MedDepNamelabel_MedDep.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedDepNamelabel_MedDep.Location = new System.Drawing.Point(8, 122);
            this.MedDepNamelabel_MedDep.Name = "MedDepNamelabel_MedDep";
            this.MedDepNamelabel_MedDep.Size = new System.Drawing.Size(127, 20);
            this.MedDepNamelabel_MedDep.TabIndex = 0;
            this.MedDepNamelabel_MedDep.Text = "Med Dep Name";
            // 
            // btnClear_MedDep
            // 
            this.btnClear_MedDep.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnClear_MedDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear_MedDep.ForeColor = System.Drawing.Color.White;
            this.btnClear_MedDep.Location = new System.Drawing.Point(244, 151);
            this.btnClear_MedDep.Name = "btnClear_MedDep";
            this.btnClear_MedDep.Size = new System.Drawing.Size(112, 37);
            this.btnClear_MedDep.TabIndex = 6;
            this.btnClear_MedDep.Text = "Clear";
            this.btnClear_MedDep.UseVisualStyleBackColor = false;
            this.btnClear_MedDep.Click += new System.EventHandler(this.btnClear_Donation_Click);
            // 
            // btnUpdate_MedDep
            // 
            this.btnUpdate_MedDep.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate_MedDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_MedDep.ForeColor = System.Drawing.Color.White;
            this.btnUpdate_MedDep.Location = new System.Drawing.Point(244, 204);
            this.btnUpdate_MedDep.Name = "btnUpdate_MedDep";
            this.btnUpdate_MedDep.Size = new System.Drawing.Size(112, 37);
            this.btnUpdate_MedDep.TabIndex = 12;
            this.btnUpdate_MedDep.Text = "Update";
            this.btnUpdate_MedDep.UseVisualStyleBackColor = false;
            this.btnUpdate_MedDep.Click += new System.EventHandler(this.btnUpdate_Donation_Click);
            // 
            // btnDelete_MedDep
            // 
            this.btnDelete_MedDep.BackColor = System.Drawing.Color.Red;
            this.btnDelete_MedDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_MedDep.ForeColor = System.Drawing.Color.White;
            this.btnDelete_MedDep.Location = new System.Drawing.Point(126, 204);
            this.btnDelete_MedDep.Name = "btnDelete_MedDep";
            this.btnDelete_MedDep.Size = new System.Drawing.Size(112, 37);
            this.btnDelete_MedDep.TabIndex = 10;
            this.btnDelete_MedDep.Text = "Delete";
            this.btnDelete_MedDep.UseVisualStyleBackColor = false;
            this.btnDelete_MedDep.Click += new System.EventHandler(this.btnDelete_Donation_Click);
            // 
            // btnAdd_MedDep
            // 
            this.btnAdd_MedDep.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAdd_MedDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_MedDep.ForeColor = System.Drawing.Color.White;
            this.btnAdd_MedDep.Location = new System.Drawing.Point(8, 204);
            this.btnAdd_MedDep.Name = "btnAdd_MedDep";
            this.btnAdd_MedDep.Size = new System.Drawing.Size(112, 37);
            this.btnAdd_MedDep.TabIndex = 8;
            this.btnAdd_MedDep.Text = "Add";
            this.btnAdd_MedDep.UseVisualStyleBackColor = false;
            this.btnAdd_MedDep.Click += new System.EventHandler(this.btnAdd_Donation_Click);
            // 
            // dataGridView_MedDep
            // 
            this.dataGridView_MedDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MedDep.Location = new System.Drawing.Point(12, 257);
            this.dataGridView_MedDep.Name = "dataGridView_MedDep";
            this.dataGridView_MedDep.Size = new System.Drawing.Size(344, 121);
            this.dataGridView_MedDep.TabIndex = 14;
            this.dataGridView_MedDep.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_MedDep_RowHeaderMouseClick);
            // 
            // txtBoxMedDepID
            // 
            this.txtBoxMedDepID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMedDepID.Location = new System.Drawing.Point(141, 82);
            this.txtBoxMedDepID.Name = "txtBoxMedDepID";
            this.txtBoxMedDepID.ReadOnly = true;
            this.txtBoxMedDepID.Size = new System.Drawing.Size(215, 26);
            this.txtBoxMedDepID.TabIndex = 2;
            // 
            // MedDepIdlabel
            // 
            this.MedDepIdlabel.AutoSize = true;
            this.MedDepIdlabel.BackColor = System.Drawing.Color.Transparent;
            this.MedDepIdlabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedDepIdlabel.Location = new System.Drawing.Point(8, 85);
            this.MedDepIdlabel.Name = "MedDepIdlabel";
            this.MedDepIdlabel.Size = new System.Drawing.Size(99, 20);
            this.MedDepIdlabel.TabIndex = 187;
            this.MedDepIdlabel.Text = "Med Dep ID";
            // 
            // MedDepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 396);
            this.Controls.Add(this.MedDepNameTextBox_MedDep);
            this.Controls.Add(this.MedDepNamelabel_MedDep);
            this.Controls.Add(this.btnClear_MedDep);
            this.Controls.Add(this.btnUpdate_MedDep);
            this.Controls.Add(this.btnDelete_MedDep);
            this.Controls.Add(this.btnAdd_MedDep);
            this.Controls.Add(this.dataGridView_MedDep);
            this.Controls.Add(this.txtBoxMedDepID);
            this.Controls.Add(this.MedDepIdlabel);
            this.MaximizeBox = false;
            this.Name = "MedDepForm";
            this.Text = "MedicalDepartmentForm";
            this.Load += new System.EventHandler(this.MedDepForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MedDep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox MedDepNameTextBox_MedDep;
        private System.Windows.Forms.Label MedDepNamelabel_MedDep;
        private System.Windows.Forms.Button btnClear_MedDep;
        private System.Windows.Forms.Button btnUpdate_MedDep;
        private System.Windows.Forms.Button btnDelete_MedDep;
        private System.Windows.Forms.Button btnAdd_MedDep;
        private System.Windows.Forms.DataGridView dataGridView_MedDep;
        private System.Windows.Forms.TextBox txtBoxMedDepID;
        private System.Windows.Forms.Label MedDepIdlabel;
    }
}