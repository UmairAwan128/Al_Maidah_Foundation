namespace Al_Maidah_Foundation.Al_Maidah_Forms
{
    partial class OtherExpenseForm
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
            this.DetailTextBox_Expense = new System.Windows.Forms.TextBox();
            this.Detaillabel_Expense = new System.Windows.Forms.Label();
            this.btnClear_Expense = new System.Windows.Forms.Button();
            this.btnUpdate_Expense = new System.Windows.Forms.Button();
            this.btnDelete_Expense = new System.Windows.Forms.Button();
            this.btnAdd_Expense = new System.Windows.Forms.Button();
            this.DatedatePicker_Expense = new System.Windows.Forms.DateTimePicker();
            this.Datelabel_Expense = new System.Windows.Forms.Label();
            this.AmountTextBox_Expense = new System.Windows.Forms.TextBox();
            this.Amountlabel_Expense = new System.Windows.Forms.Label();
            this.dataGridView_Expense = new System.Windows.Forms.DataGridView();
            this.txtBoxExpenseId = new System.Windows.Forms.TextBox();
            this.ExpenseIdlabel = new System.Windows.Forms.Label();
            this.txtBoxSearchExpense = new System.Windows.Forms.TextBox();
            this.lblSearchDoc = new System.Windows.Forms.Label();
            this.DateradioButtonExp = new System.Windows.Forms.RadioButton();
            this.DetailsRadioButtonExp = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Expense)).BeginInit();
            this.SuspendLayout();
            // 
            // DetailTextBox_Expense
            // 
            this.DetailTextBox_Expense.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailTextBox_Expense.Location = new System.Drawing.Point(114, 120);
            this.DetailTextBox_Expense.Multiline = true;
            this.DetailTextBox_Expense.Name = "DetailTextBox_Expense";
            this.DetailTextBox_Expense.Size = new System.Drawing.Size(662, 55);
            this.DetailTextBox_Expense.TabIndex = 2;
            // 
            // Detaillabel_Expense
            // 
            this.Detaillabel_Expense.AutoSize = true;
            this.Detaillabel_Expense.BackColor = System.Drawing.Color.Transparent;
            this.Detaillabel_Expense.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detaillabel_Expense.Location = new System.Drawing.Point(16, 123);
            this.Detaillabel_Expense.Name = "Detaillabel_Expense";
            this.Detaillabel_Expense.Size = new System.Drawing.Size(57, 20);
            this.Detaillabel_Expense.TabIndex = 177;
            this.Detaillabel_Expense.Text = "Details";
            // 
            // btnClear_Expense
            // 
            this.btnClear_Expense.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnClear_Expense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear_Expense.ForeColor = System.Drawing.Color.White;
            this.btnClear_Expense.Location = new System.Drawing.Point(664, 279);
            this.btnClear_Expense.Name = "btnClear_Expense";
            this.btnClear_Expense.Size = new System.Drawing.Size(112, 37);
            this.btnClear_Expense.TabIndex = 14;
            this.btnClear_Expense.Text = "Clear";
            this.btnClear_Expense.UseVisualStyleBackColor = false;
            this.btnClear_Expense.Click += new System.EventHandler(this.btnClear_Expense_Click);
            // 
            // btnUpdate_Expense
            // 
            this.btnUpdate_Expense.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate_Expense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_Expense.ForeColor = System.Drawing.Color.White;
            this.btnUpdate_Expense.Location = new System.Drawing.Point(256, 279);
            this.btnUpdate_Expense.Name = "btnUpdate_Expense";
            this.btnUpdate_Expense.Size = new System.Drawing.Size(112, 37);
            this.btnUpdate_Expense.TabIndex = 12;
            this.btnUpdate_Expense.Text = "Update";
            this.btnUpdate_Expense.UseVisualStyleBackColor = false;
            this.btnUpdate_Expense.Click += new System.EventHandler(this.btnUpdate_Expense_Click);
            // 
            // btnDelete_Expense
            // 
            this.btnDelete_Expense.BackColor = System.Drawing.Color.Red;
            this.btnDelete_Expense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_Expense.ForeColor = System.Drawing.Color.White;
            this.btnDelete_Expense.Location = new System.Drawing.Point(138, 279);
            this.btnDelete_Expense.Name = "btnDelete_Expense";
            this.btnDelete_Expense.Size = new System.Drawing.Size(112, 37);
            this.btnDelete_Expense.TabIndex = 10;
            this.btnDelete_Expense.Text = "Delete";
            this.btnDelete_Expense.UseVisualStyleBackColor = false;
            this.btnDelete_Expense.Click += new System.EventHandler(this.btnDelete_Expense_Click);
            // 
            // btnAdd_Expense
            // 
            this.btnAdd_Expense.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAdd_Expense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_Expense.ForeColor = System.Drawing.Color.White;
            this.btnAdd_Expense.Location = new System.Drawing.Point(20, 279);
            this.btnAdd_Expense.Name = "btnAdd_Expense";
            this.btnAdd_Expense.Size = new System.Drawing.Size(112, 37);
            this.btnAdd_Expense.TabIndex = 8;
            this.btnAdd_Expense.Text = "Add";
            this.btnAdd_Expense.UseVisualStyleBackColor = false;
            this.btnAdd_Expense.Click += new System.EventHandler(this.btnAdd_Expense_Click);
            // 
            // DatedatePicker_Expense
            // 
            this.DatedatePicker_Expense.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatedatePicker_Expense.Location = new System.Drawing.Point(115, 231);
            this.DatedatePicker_Expense.Name = "DatedatePicker_Expense";
            this.DatedatePicker_Expense.Size = new System.Drawing.Size(661, 26);
            this.DatedatePicker_Expense.TabIndex = 6;
            // 
            // Datelabel_Expense
            // 
            this.Datelabel_Expense.AutoSize = true;
            this.Datelabel_Expense.BackColor = System.Drawing.Color.Transparent;
            this.Datelabel_Expense.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelabel_Expense.Location = new System.Drawing.Point(16, 231);
            this.Datelabel_Expense.Name = "Datelabel_Expense";
            this.Datelabel_Expense.Size = new System.Drawing.Size(45, 20);
            this.Datelabel_Expense.TabIndex = 171;
            this.Datelabel_Expense.Text = "Date";
            // 
            // AmountTextBox_Expense
            // 
            this.AmountTextBox_Expense.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountTextBox_Expense.Location = new System.Drawing.Point(114, 190);
            this.AmountTextBox_Expense.Name = "AmountTextBox_Expense";
            this.AmountTextBox_Expense.Size = new System.Drawing.Size(662, 26);
            this.AmountTextBox_Expense.TabIndex = 4;
            this.AmountTextBox_Expense.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountTextBox_Expense_KeyPress);
            // 
            // Amountlabel_Expense
            // 
            this.Amountlabel_Expense.AutoSize = true;
            this.Amountlabel_Expense.BackColor = System.Drawing.Color.Transparent;
            this.Amountlabel_Expense.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amountlabel_Expense.Location = new System.Drawing.Point(16, 193);
            this.Amountlabel_Expense.Name = "Amountlabel_Expense";
            this.Amountlabel_Expense.Size = new System.Drawing.Size(70, 20);
            this.Amountlabel_Expense.TabIndex = 169;
            this.Amountlabel_Expense.Text = "Amount ";
            // 
            // dataGridView_Expense
            // 
            this.dataGridView_Expense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Expense.Location = new System.Drawing.Point(20, 375);
            this.dataGridView_Expense.Name = "dataGridView_Expense";
            this.dataGridView_Expense.Size = new System.Drawing.Size(756, 157);
            this.dataGridView_Expense.TabIndex = 22;
            this.dataGridView_Expense.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Expense_RowHeaderMouseClick);
            // 
            // txtBoxExpenseId
            // 
            this.txtBoxExpenseId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxExpenseId.Location = new System.Drawing.Point(114, 78);
            this.txtBoxExpenseId.Name = "txtBoxExpenseId";
            this.txtBoxExpenseId.ReadOnly = true;
            this.txtBoxExpenseId.Size = new System.Drawing.Size(219, 26);
            this.txtBoxExpenseId.TabIndex = 167;
            // 
            // ExpenseIdlabel
            // 
            this.ExpenseIdlabel.AutoSize = true;
            this.ExpenseIdlabel.BackColor = System.Drawing.Color.Transparent;
            this.ExpenseIdlabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseIdlabel.Location = new System.Drawing.Point(12, 81);
            this.ExpenseIdlabel.Name = "ExpenseIdlabel";
            this.ExpenseIdlabel.Size = new System.Drawing.Size(89, 20);
            this.ExpenseIdlabel.TabIndex = 166;
            this.ExpenseIdlabel.Text = "Expense ID";
            // 
            // txtBoxSearchExpense
            // 
            this.txtBoxSearchExpense.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchExpense.Location = new System.Drawing.Point(83, 338);
            this.txtBoxSearchExpense.Name = "txtBoxSearchExpense";
            this.txtBoxSearchExpense.Size = new System.Drawing.Size(285, 26);
            this.txtBoxSearchExpense.TabIndex = 16;
            this.txtBoxSearchExpense.TextChanged += new System.EventHandler(this.txtBoxSearchDonation_TextChanged);
            // 
            // lblSearchDoc
            // 
            this.lblSearchDoc.AutoSize = true;
            this.lblSearchDoc.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchDoc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchDoc.Location = new System.Drawing.Point(16, 341);
            this.lblSearchDoc.Name = "lblSearchDoc";
            this.lblSearchDoc.Size = new System.Drawing.Size(64, 21);
            this.lblSearchDoc.TabIndex = 183;
            this.lblSearchDoc.Text = "Search";
            this.lblSearchDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateradioButtonExp
            // 
            this.DateradioButtonExp.AutoSize = true;
            this.DateradioButtonExp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateradioButtonExp.Location = new System.Drawing.Point(480, 340);
            this.DateradioButtonExp.Name = "DateradioButtonExp";
            this.DateradioButtonExp.Size = new System.Drawing.Size(63, 24);
            this.DateradioButtonExp.TabIndex = 20;
            this.DateradioButtonExp.TabStop = true;
            this.DateradioButtonExp.Text = "Date";
            this.DateradioButtonExp.UseVisualStyleBackColor = true;
            // 
            // DetailsRadioButtonExp
            // 
            this.DetailsRadioButtonExp.AutoSize = true;
            this.DetailsRadioButtonExp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsRadioButtonExp.Location = new System.Drawing.Point(390, 340);
            this.DetailsRadioButtonExp.Name = "DetailsRadioButtonExp";
            this.DetailsRadioButtonExp.Size = new System.Drawing.Size(75, 24);
            this.DetailsRadioButtonExp.TabIndex = 18;
            this.DetailsRadioButtonExp.TabStop = true;
            this.DetailsRadioButtonExp.Text = "Details";
            this.DetailsRadioButtonExp.UseVisualStyleBackColor = true;
            // 
            // OtherExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 544);
            this.Controls.Add(this.DateradioButtonExp);
            this.Controls.Add(this.DetailsRadioButtonExp);
            this.Controls.Add(this.txtBoxSearchExpense);
            this.Controls.Add(this.lblSearchDoc);
            this.Controls.Add(this.DetailTextBox_Expense);
            this.Controls.Add(this.Detaillabel_Expense);
            this.Controls.Add(this.btnClear_Expense);
            this.Controls.Add(this.btnUpdate_Expense);
            this.Controls.Add(this.btnDelete_Expense);
            this.Controls.Add(this.btnAdd_Expense);
            this.Controls.Add(this.DatedatePicker_Expense);
            this.Controls.Add(this.Datelabel_Expense);
            this.Controls.Add(this.AmountTextBox_Expense);
            this.Controls.Add(this.Amountlabel_Expense);
            this.Controls.Add(this.dataGridView_Expense);
            this.Controls.Add(this.txtBoxExpenseId);
            this.Controls.Add(this.ExpenseIdlabel);
            this.Name = "OtherExpenseForm";
            this.Text = "OtherExpenseForm";
            this.Load += new System.EventHandler(this.OtherExpenseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Expense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DetailTextBox_Expense;
        private System.Windows.Forms.Label Detaillabel_Expense;
        private System.Windows.Forms.Button btnClear_Expense;
        private System.Windows.Forms.Button btnUpdate_Expense;
        private System.Windows.Forms.Button btnDelete_Expense;
        private System.Windows.Forms.Button btnAdd_Expense;
        private System.Windows.Forms.DateTimePicker DatedatePicker_Expense;
        private System.Windows.Forms.Label Datelabel_Expense;
        private System.Windows.Forms.TextBox AmountTextBox_Expense;
        private System.Windows.Forms.Label Amountlabel_Expense;
        private System.Windows.Forms.DataGridView dataGridView_Expense;
        private System.Windows.Forms.TextBox txtBoxExpenseId;
        private System.Windows.Forms.Label ExpenseIdlabel;
        private System.Windows.Forms.TextBox txtBoxSearchExpense;
        private System.Windows.Forms.Label lblSearchDoc;
        private System.Windows.Forms.RadioButton DateradioButtonExp;
        private System.Windows.Forms.RadioButton DetailsRadioButtonExp;
    }
}