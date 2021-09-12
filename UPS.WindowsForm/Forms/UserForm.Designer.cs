
namespace UPS.WindowsForm.Forms
{
    partial class UserForm
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
            this.l_userId = new System.Windows.Forms.Label();
            this.l_gender = new System.Windows.Forms.Label();
            this.l_email = new System.Windows.Forms.Label();
            this.l_LastName = new System.Windows.Forms.Label();
            this.l_firstName = new System.Windows.Forms.Label();
            this.l_status = new System.Windows.Forms.Label();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.tb_userId = new System.Windows.Forms.TextBox();
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.b_userSave = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.p_bodyBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_bodyBase
            // 
            this.p_bodyBase.Controls.Add(this.b_cancel);
            this.p_bodyBase.Controls.Add(this.b_userSave);
            this.p_bodyBase.Controls.Add(this.tb_firstName);
            this.p_bodyBase.Controls.Add(this.tb_userId);
            this.p_bodyBase.Controls.Add(this.tb_lastName);
            this.p_bodyBase.Controls.Add(this.tb_email);
            this.p_bodyBase.Controls.Add(this.cb_status);
            this.p_bodyBase.Controls.Add(this.cb_gender);
            this.p_bodyBase.Controls.Add(this.l_status);
            this.p_bodyBase.Controls.Add(this.l_firstName);
            this.p_bodyBase.Controls.Add(this.l_LastName);
            this.p_bodyBase.Controls.Add(this.l_email);
            this.p_bodyBase.Controls.Add(this.l_gender);
            this.p_bodyBase.Controls.Add(this.l_userId);
            this.p_bodyBase.Size = new System.Drawing.Size(408, 369);
            // 
            // l_userId
            // 
            this.l_userId.AutoSize = true;
            this.l_userId.ForeColor = System.Drawing.Color.Black;
            this.l_userId.Location = new System.Drawing.Point(19, 31);
            this.l_userId.Name = "l_userId";
            this.l_userId.Size = new System.Drawing.Size(49, 15);
            this.l_userId.TabIndex = 0;
            this.l_userId.Text = "User Id: ";
            // 
            // l_gender
            // 
            this.l_gender.AutoSize = true;
            this.l_gender.ForeColor = System.Drawing.Color.Black;
            this.l_gender.Location = new System.Drawing.Point(20, 190);
            this.l_gender.Name = "l_gender";
            this.l_gender.Size = new System.Drawing.Size(51, 15);
            this.l_gender.TabIndex = 1;
            this.l_gender.Text = "Gender: ";
            // 
            // l_email
            // 
            this.l_email.AutoSize = true;
            this.l_email.ForeColor = System.Drawing.Color.Black;
            this.l_email.Location = new System.Drawing.Point(20, 151);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(42, 15);
            this.l_email.TabIndex = 2;
            this.l_email.Text = "Email: ";
            // 
            // l_LastName
            // 
            this.l_LastName.AutoSize = true;
            this.l_LastName.ForeColor = System.Drawing.Color.Black;
            this.l_LastName.Location = new System.Drawing.Point(20, 109);
            this.l_LastName.Name = "l_LastName";
            this.l_LastName.Size = new System.Drawing.Size(69, 15);
            this.l_LastName.TabIndex = 3;
            this.l_LastName.Text = "Last Name: ";
            // 
            // l_firstName
            // 
            this.l_firstName.AutoSize = true;
            this.l_firstName.ForeColor = System.Drawing.Color.Black;
            this.l_firstName.Location = new System.Drawing.Point(19, 71);
            this.l_firstName.Name = "l_firstName";
            this.l_firstName.Size = new System.Drawing.Size(70, 15);
            this.l_firstName.TabIndex = 4;
            this.l_firstName.Text = "First Name: ";
            // 
            // l_status
            // 
            this.l_status.AutoSize = true;
            this.l_status.ForeColor = System.Drawing.Color.Black;
            this.l_status.Location = new System.Drawing.Point(19, 228);
            this.l_status.Name = "l_status";
            this.l_status.Size = new System.Drawing.Size(45, 15);
            this.l_status.TabIndex = 5;
            this.l_status.Text = "Status: ";
            // 
            // cb_gender
            // 
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Location = new System.Drawing.Point(95, 187);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(245, 23);
            this.cb_gender.TabIndex = 5;
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(95, 225);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(245, 23);
            this.cb_status.TabIndex = 6;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(95, 148);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(245, 23);
            this.tb_email.TabIndex = 4;
            // 
            // tb_lastName
            // 
            this.tb_lastName.Location = new System.Drawing.Point(95, 106);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(245, 23);
            this.tb_lastName.TabIndex = 3;
            // 
            // tb_userId
            // 
            this.tb_userId.Enabled = false;
            this.tb_userId.Location = new System.Drawing.Point(95, 28);
            this.tb_userId.Name = "tb_userId";
            this.tb_userId.Size = new System.Drawing.Size(245, 23);
            this.tb_userId.TabIndex = 1;
            // 
            // tb_firstName
            // 
            this.tb_firstName.Location = new System.Drawing.Point(95, 68);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(245, 23);
            this.tb_firstName.TabIndex = 2;
            // 
            // b_userSave
            // 
            this.b_userSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.b_userSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_userSave.ForeColor = System.Drawing.Color.White;
            this.b_userSave.Location = new System.Drawing.Point(239, 278);
            this.b_userSave.Name = "b_userSave";
            this.b_userSave.Size = new System.Drawing.Size(101, 33);
            this.b_userSave.TabIndex = 7;
            this.b_userSave.Text = "Save";
            this.b_userSave.UseVisualStyleBackColor = false;
            this.b_userSave.Click += new System.EventHandler(this.b_userSave_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.BackColor = System.Drawing.Color.White;
            this.b_cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.b_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_cancel.ForeColor = System.Drawing.Color.Black;
            this.b_cancel.Location = new System.Drawing.Point(95, 278);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(99, 31);
            this.b_cancel.TabIndex = 8;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = false;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 436);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.p_bodyBase.ResumeLayout(false);
            this.p_bodyBase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label l_firstName;
        private System.Windows.Forms.Label l_LastName;
        private System.Windows.Forms.Label l_email;
        private System.Windows.Forms.Label l_gender;
        private System.Windows.Forms.Label l_userId;
        private System.Windows.Forms.TextBox tb_firstName;
        private System.Windows.Forms.TextBox tb_userId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.Label l_status;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox tb_lastName;
        private System.Windows.Forms.Button b_userSave;
        private System.Windows.Forms.Button b_cancel;
    }
}