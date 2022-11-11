
namespace UniversityManagementSystem_B_
{
    partial class Teacher
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
            this.btnTback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TName = new System.Windows.Forms.TextBox();
            this.TId = new System.Windows.Forms.TextBox();
            this.Salary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GenderCb = new System.Windows.Forms.ComboBox();
            this.DataGridViewT = new System.Windows.Forms.DataGridView();
            this.btnTAdd = new System.Windows.Forms.Button();
            this.btnTedit = new System.Windows.Forms.Button();
            this.btnTdelete = new System.Windows.Forms.Button();
            this.DeptCb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewT)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(822, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTback
            // 
            this.btnTback.BackColor = System.Drawing.Color.Red;
            this.btnTback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTback.Location = new System.Drawing.Point(-6, 0);
            this.btnTback.Name = "btnTback";
            this.btnTback.Size = new System.Drawing.Size(102, 40);
            this.btnTback.TabIndex = 1;
            this.btnTback.Text = "Back";
            this.btnTback.UseVisualStyleBackColor = false;
            this.btnTback.Click += new System.EventHandler(this.btnTback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(301, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SandyBrown;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(334, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 32);
            this.label7.TabIndex = 8;
            this.label7.Text = "Teacher List";
            // 
            // TName
            // 
            this.TName.Location = new System.Drawing.Point(137, 60);
            this.TName.Multiline = true;
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(117, 22);
            this.TName.TabIndex = 9;
            this.TName.TextChanged += new System.EventHandler(this.TName_TextChanged);
            // 
            // TId
            // 
            this.TId.Location = new System.Drawing.Point(137, 127);
            this.TId.Name = "TId";
            this.TId.Size = new System.Drawing.Size(117, 22);
            this.TId.TabIndex = 10;
            this.TId.TextChanged += new System.EventHandler(this.TId_TextChanged);
            // 
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(678, 90);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(117, 22);
            this.Salary.TabIndex = 15;
            this.Salary.TextChanged += new System.EventHandler(this.Salary_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(588, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(597, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 13;
            // 
            // GenderCb
            // 
            this.GenderCb.FormattingEnabled = true;
            this.GenderCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderCb.Location = new System.Drawing.Point(433, 121);
            this.GenderCb.Name = "GenderCb";
            this.GenderCb.Size = new System.Drawing.Size(121, 24);
            this.GenderCb.TabIndex = 16;
            this.GenderCb.SelectedIndexChanged += new System.EventHandler(this.GenderCb_SelectedIndexChanged);
            // 
            // DataGridViewT
            // 
            this.DataGridViewT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridViewT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewT.Location = new System.Drawing.Point(93, 276);
            this.DataGridViewT.Name = "DataGridViewT";
            this.DataGridViewT.RowHeadersWidth = 51;
            this.DataGridViewT.RowTemplate.Height = 24;
            this.DataGridViewT.Size = new System.Drawing.Size(676, 207);
            this.DataGridViewT.TabIndex = 17;
            this.DataGridViewT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewT_CellContentClick);
            // 
            // btnTAdd
            // 
            this.btnTAdd.BackColor = System.Drawing.Color.Cyan;
            this.btnTAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTAdd.Location = new System.Drawing.Point(40, 187);
            this.btnTAdd.Name = "btnTAdd";
            this.btnTAdd.Size = new System.Drawing.Size(77, 40);
            this.btnTAdd.TabIndex = 18;
            this.btnTAdd.Text = "Add";
            this.btnTAdd.UseVisualStyleBackColor = false;
            this.btnTAdd.Click += new System.EventHandler(this.btnTAdd_Click);
            // 
            // btnTedit
            // 
            this.btnTedit.BackColor = System.Drawing.Color.Cyan;
            this.btnTedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTedit.Location = new System.Drawing.Point(177, 187);
            this.btnTedit.Name = "btnTedit";
            this.btnTedit.Size = new System.Drawing.Size(77, 40);
            this.btnTedit.TabIndex = 19;
            this.btnTedit.Text = "Edit";
            this.btnTedit.UseVisualStyleBackColor = false;
            this.btnTedit.Click += new System.EventHandler(this.btnTedit_Click);
            // 
            // btnTdelete
            // 
            this.btnTdelete.BackColor = System.Drawing.Color.Cyan;
            this.btnTdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTdelete.Location = new System.Drawing.Point(305, 187);
            this.btnTdelete.Name = "btnTdelete";
            this.btnTdelete.Size = new System.Drawing.Size(77, 40);
            this.btnTdelete.TabIndex = 20;
            this.btnTdelete.Text = "Delete";
            this.btnTdelete.UseVisualStyleBackColor = false;
            this.btnTdelete.Click += new System.EventHandler(this.btnTdelete_Click);
            // 
            // DeptCb
            // 
            this.DeptCb.FormattingEnabled = true;
            this.DeptCb.Items.AddRange(new object[] {
            "CSE",
            "BBA",
            "EEE"});
            this.DeptCb.Location = new System.Drawing.Point(433, 61);
            this.DeptCb.Name = "DeptCb";
            this.DeptCb.Size = new System.Drawing.Size(121, 24);
            this.DeptCb.TabIndex = 21;
            this.DeptCb.SelectedIndexChanged += new System.EventHandler(this.DeptCb_SelectedIndexChanged);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 495);
            this.Controls.Add(this.DeptCb);
            this.Controls.Add(this.btnTdelete);
            this.Controls.Add(this.btnTedit);
            this.Controls.Add(this.btnTAdd);
            this.Controls.Add(this.DataGridViewT);
            this.Controls.Add(this.GenderCb);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TId);
            this.Controls.Add(this.TName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTback);
            this.Controls.Add(this.button1);
            this.Name = "Teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.Teacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TName;
        private System.Windows.Forms.TextBox TId;
        private System.Windows.Forms.TextBox Salary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox GenderCb;
        private System.Windows.Forms.DataGridView DataGridViewT;
        private System.Windows.Forms.Button btnTAdd;
        private System.Windows.Forms.Button btnTedit;
        private System.Windows.Forms.Button btnTdelete;
        private System.Windows.Forms.ComboBox DeptCb;
    }
}