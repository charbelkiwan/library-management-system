namespace Library
{
    partial class SignUpForm
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
            this.btnSignin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_firstname = new System.Windows.Forms.TextBox();
            this.textBox_lastname = new System.Windows.Forms.TextBox();
            this.textBox_emailsignup = new System.Windows.Forms.TextBox();
            this.textBox_passwordsignup = new System.Windows.Forms.TextBox();
            this.btnbacktostart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSignin
            // 
            this.btnSignin.Location = new System.Drawing.Point(147, 258);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(75, 23);
            this.btnSignin.TabIndex = 1;
            this.btnSignin.Text = "Sign in";
            this.btnSignin.UseVisualStyleBackColor = true;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(118, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(118, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(118, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(118, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // textBox_firstname
            // 
            this.textBox_firstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_firstname.Location = new System.Drawing.Point(118, 44);
            this.textBox_firstname.Name = "textBox_firstname";
            this.textBox_firstname.Size = new System.Drawing.Size(138, 23);
            this.textBox_firstname.TabIndex = 6;
            // 
            // textBox_lastname
            // 
            this.textBox_lastname.Location = new System.Drawing.Point(118, 97);
            this.textBox_lastname.Name = "textBox_lastname";
            this.textBox_lastname.Size = new System.Drawing.Size(138, 23);
            this.textBox_lastname.TabIndex = 7;
            // 
            // textBox_emailsignup
            // 
            this.textBox_emailsignup.Location = new System.Drawing.Point(118, 154);
            this.textBox_emailsignup.Name = "textBox_emailsignup";
            this.textBox_emailsignup.Size = new System.Drawing.Size(138, 23);
            this.textBox_emailsignup.TabIndex = 8;
            // 
            // textBox_passwordsignup
            // 
            this.textBox_passwordsignup.Location = new System.Drawing.Point(118, 213);
            this.textBox_passwordsignup.Name = "textBox_passwordsignup";
            this.textBox_passwordsignup.Size = new System.Drawing.Size(138, 23);
            this.textBox_passwordsignup.TabIndex = 9;
            // 
            // btnbacktostart
            // 
            this.btnbacktostart.Location = new System.Drawing.Point(147, 313);
            this.btnbacktostart.Name = "btnbacktostart";
            this.btnbacktostart.Size = new System.Drawing.Size(75, 23);
            this.btnbacktostart.TabIndex = 10;
            this.btnbacktostart.Text = "back";
            this.btnbacktostart.UseVisualStyleBackColor = true;
            this.btnbacktostart.Click += new System.EventHandler(this.btnbacktostart_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnbacktostart);
            this.Controls.Add(this.textBox_passwordsignup);
            this.Controls.Add(this.textBox_emailsignup);
            this.Controls.Add(this.textBox_lastname);
            this.Controls.Add(this.textBox_firstname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSignin);
            this.Name = "SignUpForm";
            this.Text = "Sign up Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnSignin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox_firstname;
        private TextBox textBox_lastname;
        private TextBox textBox_emailsignup;
        private TextBox textBox_passwordsignup;
        private Button btnbacktostart;
    }
}