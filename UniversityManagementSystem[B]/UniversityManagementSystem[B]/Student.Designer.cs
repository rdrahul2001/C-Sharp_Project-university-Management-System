
namespace UniversityManagementSystem_B_
{
    partial class Student
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnSback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StdId = new System.Windows.Forms.TextBox();
            this.StdName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.stdGendreCb = new System.Windows.Forms.ComboBox();
            this.stdDate = new System.Windows.Forms.DateTimePicker();
            this.stdFeesTb = new System.Windows.Forms.TextBox();
            this.btnSadd = new System.Windows.Forms.Button();
            this.studentEditButton = new System.Windows.Forms.Button();
            this.studentDeleteButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.stdDataGridView1 = new System.Windows.Forms.DataGridView();
            this.stdDepartCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.stdDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(796, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSback
            // 
            this.btnSback.BackColor = System.Drawing.Color.Red;
            this.btnSback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSback.Location = new System.Drawing.Point(-3, 2);
            this.btnSback.Name = "btnSback";
            this.btnSback.Size = new System.Drawing.Size(88, 35);
            this.btnSback.TabIndex = 1;
            this.btnSback.Text = "Back";
            this.btnSback.UseVisualStyleBackColor = false;
            this.btnSback.Click += new System.EventHandler(this.btnSback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Department";
            // 
            // StdId
            // 
            this.StdId.Location = new System.Drawing.Point(138, 116);
            this.StdId.Multiline = true;
            this.StdId.Name = "StdId";
            this.StdId.Size = new System.Drawing.Size(137, 22);
            this.StdId.TabIndex = 6;
            this.StdId.TextChanged += new System.EventHandler(this.textSid_TextChanged);
            // 
            // StdName
            // 
            this.StdName.Location = new System.Drawing.Point(138, 179);
            this.StdName.Multiline = true;
            this.StdName.Name = "StdName";
            this.StdName.Size = new System.Drawing.Size(137, 22);
            this.StdName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(306, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dob";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(306, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Pay fee";
            // 
            // stdGendreCb
            // 
            this.stdGendreCb.FormattingEnabled = true;
            this.stdGendreCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.stdGendreCb.Location = new System.Drawing.Point(392, 118);
            this.stdGendreCb.Name = "stdGendreCb";
            this.stdGendreCb.Size = new System.Drawing.Size(121, 24);
            this.stdGendreCb.TabIndex = 12;
            // 
            // stdDate
            // 
            this.stdDate.Location = new System.Drawing.Point(392, 181);
            this.stdDate.Name = "stdDate";
            this.stdDate.Size = new System.Drawing.Size(220, 22);
            this.stdDate.TabIndex = 13;
            this.stdDate.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // stdFeesTb
            // 
            this.stdFeesTb.Location = new System.Drawing.Point(392, 258);
            this.stdFeesTb.Multiline = true;
            this.stdFeesTb.Name = "stdFeesTb";
            this.stdFeesTb.Size = new System.Drawing.Size(156, 22);
            this.stdFeesTb.TabIndex = 14;
            // 
            // btnSadd
            // 
            this.btnSadd.BackColor = System.Drawing.Color.Cyan;
            this.btnSadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSadd.Location = new System.Drawing.Point(16, 304);
            this.btnSadd.Name = "btnSadd";
            this.btnSadd.Size = new System.Drawing.Size(94, 47);
            this.btnSadd.TabIndex = 18;
            this.btnSadd.Text = "Add";
            this.btnSadd.UseVisualStyleBackColor = false;
            this.btnSadd.Click += new System.EventHandler(this.btnSadd_Click);
            // 
            // studentEditButton
            // 
            this.studentEditButton.BackColor = System.Drawing.Color.Cyan;
            this.studentEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentEditButton.Location = new System.Drawing.Point(138, 304);
            this.studentEditButton.Name = "studentEditButton";
            this.studentEditButton.Size = new System.Drawing.Size(94, 47);
            this.studentEditButton.TabIndex = 19;
            this.studentEditButton.Text = "Edit";
            this.studentEditButton.UseVisualStyleBackColor = false;
            this.studentEditButton.Click += new System.EventHandler(this.studentEditButton_Click);
            // 
            // studentDeleteButton
            // 
            this.studentDeleteButton.BackColor = System.Drawing.Color.Cyan;
            this.studentDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDeleteButton.Location = new System.Drawing.Point(274, 304);
            this.studentDeleteButton.Name = "studentDeleteButton";
            this.studentDeleteButton.Size = new System.Drawing.Size(94, 47);
            this.studentDeleteButton.TabIndex = 20;
            this.studentDeleteButton.Text = "Delete";
            this.studentDeleteButton.UseVisualStyleBackColor = false;
            this.studentDeleteButton.Click += new System.EventHandler(this.studentDeleteButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.MistyRose;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(375, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 29);
            this.label9.TabIndex = 21;
            this.label9.Text = "Student List";
            // 
            // stdDataGridView1
            // 
            this.stdDataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stdDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stdDataGridView1.Location = new System.Drawing.Point(-3, 394);
            this.stdDataGridView1.Name = "stdDataGridView1";
            this.stdDataGridView1.RowHeadersWidth = 51;
            this.stdDataGridView1.RowTemplate.Height = 24;
            this.stdDataGridView1.Size = new System.Drawing.Size(928, 200);
            this.stdDataGridView1.TabIndex = 22;
            this.stdDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stdDataGridView1_CellContentClick);
            // 
            // stdDepartCB
            // 
            this.stdDepartCB.FormattingEnabled = true;
            this.stdDepartCB.Items.AddRange(new object[] {
            "EEE",
            "CSE",
            "COE"});
            this.stdDepartCB.Location = new System.Drawing.Point(154, 254);
            this.stdDepartCB.Name = "stdDepartCB";
            this.stdDepartCB.Size = new System.Drawing.Size(121, 24);
            this.stdDepartCB.TabIndex = 24;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 619);
            this.Controls.Add(this.stdDepartCB);
            this.Controls.Add(this.stdDataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.studentDeleteButton);
            this.Controls.Add(this.studentEditButton);
            this.Controls.Add(this.btnSadd);
            this.Controls.Add(this.stdFeesTb);
            this.Controls.Add(this.stdDate);
            this.Controls.Add(this.stdGendreCb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StdName);
            this.Controls.Add(this.StdId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSback);
            this.Controls.Add(this.button1);
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stdDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StdId;
        private System.Windows.Forms.TextBox StdName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox stdGendreCb;
        private System.Windows.Forms.DateTimePicker stdDate;
        private System.Windows.Forms.TextBox stdFeesTb;
        private System.Windows.Forms.Button btnSadd;
        private System.Windows.Forms.Button studentEditButton;
        private System.Windows.Forms.Button studentDeleteButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView stdDataGridView1;
        private System.Windows.Forms.ComboBox stdDepartCB;
    }
}