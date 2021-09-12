
namespace UPS.WindowsForm.Forms
{
    partial class MessageForm
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
            this.l_message = new System.Windows.Forms.Label();
            this.b_close = new System.Windows.Forms.Button();
            this.p_bodyBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_bodyBase
            // 
            this.p_bodyBase.Controls.Add(this.b_close);
            this.p_bodyBase.Controls.Add(this.l_message);
            this.p_bodyBase.Size = new System.Drawing.Size(475, 131);
            // 
            // l_message
            // 
            this.l_message.AutoSize = true;
            this.l_message.BackColor = System.Drawing.Color.White;
            this.l_message.ForeColor = System.Drawing.Color.Black;
            this.l_message.Location = new System.Drawing.Point(34, 31);
            this.l_message.Name = "l_message";
            this.l_message.Size = new System.Drawing.Size(56, 15);
            this.l_message.TabIndex = 0;
            this.l_message.Text = "Message.";
            // 
            // b_close
            // 
            this.b_close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.b_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_close.ForeColor = System.Drawing.Color.Black;
            this.b_close.Location = new System.Drawing.Point(185, 86);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(99, 31);
            this.b_close.TabIndex = 1;
            this.b_close.Text = "Ok";
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 198);
            this.Name = "MessageForm";
            this.Text = "MessageForm";
            this.p_bodyBase.ResumeLayout(false);
            this.p_bodyBase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label l_message;
        private System.Windows.Forms.Button b_close;
    }
}