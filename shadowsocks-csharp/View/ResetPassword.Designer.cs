namespace Shadowsocks.View
{
    partial class ResetPassword
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.textOld = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textPassword2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DescLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.OldPasswordLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(280, 128);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 29);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textOld
            // 
            this.textOld.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textOld.Location = new System.Drawing.Point(137, 29);
            this.textOld.Margin = new System.Windows.Forms.Padding(4);
            this.textOld.Name = "textOld";
            this.textOld.Size = new System.Drawing.Size(243, 25);
            this.textOld.TabIndex = 0;
            this.textOld.UseSystemPasswordChar = true;
            // 
            // textPassword
            // 
            this.textPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPassword.Location = new System.Drawing.Point(137, 62);
            this.textPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(243, 25);
            this.textPassword.TabIndex = 1;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // textPassword2
            // 
            this.textPassword2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPassword2.Location = new System.Drawing.Point(137, 95);
            this.textPassword2.Margin = new System.Windows.Forms.Padding(4);
            this.textPassword2.Name = "textPassword2";
            this.textPassword2.Size = new System.Drawing.Size(243, 25);
            this.textPassword2.TabIndex = 2;
            this.textPassword2.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 199);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.DescLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textPassword2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textPassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textOld, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ConfirmPasswordLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.NewPasswordLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.OldPasswordLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonOK, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 14);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 177);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DescLabel
            // 
            this.DescLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DescLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.DescLabel, 2);
            this.DescLabel.Location = new System.Drawing.Point(3, 5);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(143, 15);
            this.DescLabel.TabIndex = 7;
            this.DescLabel.Text = "ResetPasword Desc";
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(3, 100);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(127, 15);
            this.ConfirmPasswordLabel.TabIndex = 6;
            this.ConfirmPasswordLabel.Text = "ConfirmPassword";
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Location = new System.Drawing.Point(35, 67);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(95, 15);
            this.NewPasswordLabel.TabIndex = 5;
            this.NewPasswordLabel.Text = "NewPassword";
            // 
            // OldPasswordLabel
            // 
            this.OldPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OldPasswordLabel.AutoSize = true;
            this.OldPasswordLabel.Location = new System.Drawing.Point(35, 34);
            this.OldPasswordLabel.Name = "OldPasswordLabel";
            this.OldPasswordLabel.Size = new System.Drawing.Size(95, 15);
            this.OldPasswordLabel.TabIndex = 4;
            this.OldPasswordLabel.Text = "OldPassword";
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 223);
            this.Controls.Add(this.groupBox1);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPassword";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ResetPassword_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textOld;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textPassword2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label OldPasswordLabel;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.Label DescLabel;
    }
}