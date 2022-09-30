namespace Wonforms3
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.lblbEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lBoxStudents = new System.Windows.Forms.ListBox();
            this.lblStudents = new System.Windows.Forms.Label();
            this.btnAddS = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 130);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblColor.Location = new System.Drawing.Point(272, 9);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(54, 21);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "Empty";
            // 
            // btnColor
            // 
            this.btnColor.AutoSize = true;
            this.btnColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnColor.Location = new System.Drawing.Point(191, 157);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 31);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "Add";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 29);
            this.textBox1.TabIndex = 3;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(409, 26);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 4;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            this.monthCalendar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.monthCalendar_MouseDown);
            // 
            // lblbEndDate
            // 
            this.lblbEndDate.AutoSize = true;
            this.lblbEndDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblbEndDate.Location = new System.Drawing.Point(561, 197);
            this.lblbEndDate.Name = "lblbEndDate";
            this.lblbEndDate.Size = new System.Drawing.Size(72, 21);
            this.lblbEndDate.TabIndex = 1;
            this.lblbEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStartDate.Location = new System.Drawing.Point(409, 197);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(78, 21);
            this.lblStartDate.TabIndex = 1;
            this.lblStartDate.Text = "Start Date";
            // 
            // lBoxStudents
            // 
            this.lBoxStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lBoxStudents.FormattingEnabled = true;
            this.lBoxStudents.ItemHeight = 21;
            this.lBoxStudents.Location = new System.Drawing.Point(12, 265);
            this.lBoxStudents.Name = "lBoxStudents";
            this.lBoxStudents.Size = new System.Drawing.Size(254, 151);
            this.lBoxStudents.TabIndex = 5;
            this.lBoxStudents.SelectedIndexChanged += new System.EventHandler(this.lBoxStudents_SelectedIndexChanged);
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudents.Location = new System.Drawing.Point(272, 265);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(54, 21);
            this.lblStudents.TabIndex = 1;
            this.lblStudents.Text = "Empty";
            // 
            // btnAddS
            // 
            this.btnAddS.AutoSize = true;
            this.btnAddS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddS.Location = new System.Drawing.Point(12, 426);
            this.btnAddS.Name = "btnAddS";
            this.btnAddS.Size = new System.Drawing.Size(73, 46);
            this.btnAddS.TabIndex = 2;
            this.btnAddS.Text = "Add";
            this.btnAddS.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.Location = new System.Drawing.Point(97, 426);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(77, 46);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Reomve";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.AutoSize = true;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoad.Location = new System.Drawing.Point(191, 426);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(73, 46);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 484);
            this.Controls.Add(this.lBoxStudents);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddS);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblbEndDate);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private Label lblColor;
        private Button btnColor;
        private TextBox textBox1;
        private MonthCalendar monthCalendar;
        private Label lblbEndDate;
        private Label lblStartDate;
        private ListBox lBoxStudents;
        private Label lblStudents;
        private Button btnAddS;
        private Button btnRemove;
        private Button btnLoad;
    }
}