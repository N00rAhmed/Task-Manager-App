﻿namespace TASK_APP
{
    partial class AdminData
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.TasksBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserIDField = new System.Windows.Forms.TextBox();
            this.UserID = new System.Windows.Forms.Label();
            this.DeleteUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(27, 64);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(553, 305);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(652, 23);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(106, 39);
            this.logoutBtn.TabIndex = 6;
            this.logoutBtn.Text = "logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // TasksBtn
            // 
            this.TasksBtn.Location = new System.Drawing.Point(653, 138);
            this.TasksBtn.Name = "TasksBtn";
            this.TasksBtn.Size = new System.Drawing.Size(105, 47);
            this.TasksBtn.TabIndex = 7;
            this.TasksBtn.Text = "Tasks";
            this.TasksBtn.UseVisualStyleBackColor = true;
            this.TasksBtn.Click += new System.EventHandler(this.TasksBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TASK_APP.Properties.Resources.tree_736885__480;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 449);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // UserIDField
            // 
            this.UserIDField.Location = new System.Drawing.Point(641, 248);
            this.UserIDField.Name = "UserIDField";
            this.UserIDField.Size = new System.Drawing.Size(67, 20);
            this.UserIDField.TabIndex = 9;
            this.UserIDField.TextChanged += new System.EventHandler(this.UderIDField_TextChanged);
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Location = new System.Drawing.Point(595, 251);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(40, 13);
            this.UserID.TabIndex = 10;
            this.UserID.Text = "UserID";
            // 
            // DeleteUser
            // 
            this.DeleteUser.Location = new System.Drawing.Point(714, 241);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(74, 33);
            this.DeleteUser.TabIndex = 11;
            this.DeleteUser.Text = "Delete";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // AdminData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.UserIDField);
            this.Controls.Add(this.TasksBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AdminData";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button TasksBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox UserIDField;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Button DeleteUser;
    }
}