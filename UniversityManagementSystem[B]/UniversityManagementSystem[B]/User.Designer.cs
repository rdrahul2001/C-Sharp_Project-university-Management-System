
namespace UniversityManagementSystem_B_
{
    partial class User
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
            this.UidTb = new System.Windows.Forms.TextBox();
            this.UnameTb = new System.Windows.Forms.TextBox();
            this.UpassTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UserDataGridView = new System.Windows.Forms.DataGridView();
            this.btnUAdd = new System.Windows.Forms.Button();
            this.btnUEdit = new System.Windows.Forms.Button();
            this.btnUDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(725, -4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTback
            // 
            this.btnTback.BackColor = System.Drawing.Color.Red;
            this.btnTback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTback.Location = new System.Drawing.Point(-2, -4);
            this.btnTback.Name = "btnTback";
            this.btnTback.Size = new System.Drawing.Size(102, 40);
            this.btnTback.TabIndex = 2;
            this.btnTback.Text = "Back";
            this.btnTback.UseVisualStyleBackColor = false;
            this.btnTback.Click += new System.EventHandler(this.btnTback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Users";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // UidTb
            // 
            this.UidTb.Location = new System.Drawing.Point(209, 150);
            this.UidTb.Multiline = true;
            this.UidTb.Name = "UidTb";
            this.UidTb.Size = new System.Drawing.Size(119, 22);
            this.UidTb.TabIndex = 7;
            // 
            // UnameTb
            // 
            this.UnameTb.Location = new System.Drawing.Point(209, 214);
            this.UnameTb.Multiline = true;
            this.UnameTb.Name = "UnameTb";
            this.UnameTb.Size = new System.Drawing.Size(119, 22);
            this.UnameTb.TabIndex = 8;
            // 
            // UpassTb
            // 
            this.UpassTb.Location = new System.Drawing.Point(209, 284);
            this.UpassTb.Multiline = true;
            this.UpassTb.Name = "UpassTb";
            this.UpassTb.Size = new System.Drawing.Size(119, 22);
            this.UpassTb.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSalmon;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(531, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "Users List";
            // 
            // UserDataGridView
            // 
            this.UserDataGridView.AllowUserToAddRows = false;
            this.UserDataGridView.AllowUserToDeleteRows = false;
            this.UserDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataGridView.Location = new System.Drawing.Point(389, 175);
            this.UserDataGridView.Name = "UserDataGridView";
            this.UserDataGridView.ReadOnly = true;
            this.UserDataGridView.RowHeadersWidth = 51;
            this.UserDataGridView.RowTemplate.Height = 24;
            this.UserDataGridView.Size = new System.Drawing.Size(411, 270);
            this.UserDataGridView.TabIndex = 11;
            this.UserDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDataGridView_CellContentClick);
            // 
            // btnUAdd
            // 
            this.btnUAdd.BackColor = System.Drawing.Color.GreenYellow;
            this.btnUAdd.Location = new System.Drawing.Point(65, 352);
            this.btnUAdd.Name = "btnUAdd";
            this.btnUAdd.Size = new System.Drawing.Size(75, 39);
            this.btnUAdd.TabIndex = 12;
            this.btnUAdd.Text = "Add";
            this.btnUAdd.UseVisualStyleBackColor = false;
            this.btnUAdd.Click += new System.EventHandler(this.btnUAdd_Click);
            // 
            // btnUEdit
            // 
            this.btnUEdit.BackColor = System.Drawing.Color.GreenYellow;
            this.btnUEdit.Location = new System.Drawing.Point(181, 352);
            this.btnUEdit.Name = "btnUEdit";
            this.btnUEdit.Size = new System.Drawing.Size(75, 39);
            this.btnUEdit.TabIndex = 13;
            this.btnUEdit.Text = "Edit";
            this.btnUEdit.UseVisualStyleBackColor = false;
            this.btnUEdit.Click += new System.EventHandler(this.btnUEdit_Click);
            // 
            // btnUDelete
            // 
            this.btnUDelete.BackColor = System.Drawing.Color.GreenYellow;
            this.btnUDelete.Location = new System.Drawing.Point(303, 352);
            this.btnUDelete.Name = "btnUDelete";
            this.btnUDelete.Size = new System.Drawing.Size(75, 39);
            this.btnUDelete.TabIndex = 14;
            this.btnUDelete.Text = "Delete";
            this.btnUDelete.UseVisualStyleBackColor = false;
            this.btnUDelete.Click += new System.EventHandler(this.btnUDelete_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUDelete);
            this.Controls.Add(this.btnUEdit);
            this.Controls.Add(this.btnUAdd);
            this.Controls.Add(this.UserDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UpassTb);
            this.Controls.Add(this.UnameTb);
            this.Controls.Add(this.UidTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTback);
            this.Controls.Add(this.button1);
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).EndInit();
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
        private System.Windows.Forms.TextBox UidTb;
        private System.Windows.Forms.TextBox UnameTb;
        private System.Windows.Forms.TextBox UpassTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView UserDataGridView;
        private System.Windows.Forms.Button btnUAdd;
        private System.Windows.Forms.Button btnUEdit;
        private System.Windows.Forms.Button btnUDelete;
    }
}