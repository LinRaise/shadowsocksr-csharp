namespace Shadowsocks.View
{
    partial class InputPassword
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
            this.textPassword = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.pwdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textPassword
            // 
            this.textPassword.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textPassword.Location = new System.Drawing.Point(113, 23);
            this.textPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(215, 25);
            this.textPassword.TabIndex = 0;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(139, 56);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(189, 35);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // pwdLabel
            // 
            this.pwdLabel.AutoSize = true;
            this.pwdLabel.Location = new System.Drawing.Point(34, 26);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(72, 17);
            this.pwdLabel.TabIndex = 3;
            this.pwdLabel.Text = "password";
            // 
            // InputPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(339, 104);
            this.Controls.Add(this.pwdLabel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textPassword);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputPassword";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputPassword_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label pwdLabel;
    }
}