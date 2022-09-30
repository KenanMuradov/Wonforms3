namespace Task
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.btnAddEdit = new System.Windows.Forms.Button();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lBoxUsers = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.gbForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbForm
            // 
            this.gbForm.Controls.Add(this.btnAddEdit);
            this.gbForm.Controls.Add(this.birthDatePicker);
            this.gbForm.Controls.Add(this.txtPhone);
            this.gbForm.Controls.Add(this.txtEmail);
            this.gbForm.Controls.Add(this.txtSurname);
            this.gbForm.Controls.Add(this.txtName);
            this.gbForm.Controls.Add(this.lblBirthDate);
            this.gbForm.Controls.Add(this.lblPhone);
            this.gbForm.Controls.Add(this.lblEmail);
            this.gbForm.Controls.Add(this.lblSurname);
            this.gbForm.Controls.Add(this.lblName);
            this.gbForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbForm.Location = new System.Drawing.Point(12, 12);
            this.gbForm.Name = "gbForm";
            this.gbForm.Size = new System.Drawing.Size(381, 270);
            this.gbForm.TabIndex = 0;
            this.gbForm.TabStop = false;
            this.gbForm.Text = "Form";
            // 
            // btnAddEdit
            // 
            this.btnAddEdit.AutoSize = true;
            this.btnAddEdit.Location = new System.Drawing.Point(263, 217);
            this.btnAddEdit.Name = "btnAddEdit";
            this.btnAddEdit.Size = new System.Drawing.Size(75, 31);
            this.btnAddEdit.TabIndex = 3;
            this.btnAddEdit.Text = "Add";
            this.btnAddEdit.UseVisualStyleBackColor = true;
            this.btnAddEdit.Click += new System.EventHandler(this.btnAddEdit_Click);
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.CustomFormat = "dd/MM/yyyy";
            this.birthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDatePicker.Location = new System.Drawing.Point(174, 171);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(164, 29);
            this.birthDatePicker.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(174, 128);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(164, 29);
            this.txtPhone.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(174, 93);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(164, 29);
            this.txtEmail.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(174, 58);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(164, 29);
            this.txtSurname.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(174, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 29);
            this.txtName.TabIndex = 1;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(6, 177);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(79, 21);
            this.lblBirthDate.TabIndex = 0;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 129);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(54, 21);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 96);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 21);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(6, 61);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(73, 21);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lBoxUsers
            // 
            this.lBoxUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lBoxUsers.FormattingEnabled = true;
            this.lBoxUsers.ItemHeight = 21;
            this.lBoxUsers.Location = new System.Drawing.Point(399, 12);
            this.lBoxUsers.Name = "lBoxUsers";
            this.lBoxUsers.Size = new System.Drawing.Size(189, 298);
            this.lBoxUsers.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.AutoSize = true;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoad.Location = new System.Drawing.Point(399, 351);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(90, 31);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(495, 351);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 31);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnAddEdit_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFileName.Location = new System.Drawing.Point(399, 316);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(189, 29);
            this.txtFileName.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lBoxUsers);
            this.Controls.Add(this.gbForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbForm.ResumeLayout(false);
            this.gbForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbForm;
        private Button btnAddEdit;
        private DateTimePicker birthDatePicker;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtSurname;
        private TextBox txtName;
        private Label lblBirthDate;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblSurname;
        private Label lblName;
        private ListBox lBoxUsers;
        private Button btnLoad;
        private Button btnSave;
        private TextBox txtFileName;
    }
}