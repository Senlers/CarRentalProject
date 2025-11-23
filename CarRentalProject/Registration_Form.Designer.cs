namespace CarRentalProject
{
    partial class Registration_Form
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_newusername = new TextBox();
            txt_newpassword = new TextBox();
            txt_newemail = new TextBox();
            txt_newdriverid = new TextBox();
            datatime_dt1 = new DateTimePicker();
            signup_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(149, 31);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(366, 30);
            label1.TabIndex = 0;
            label1.Text = "Join us and enjoy our car services!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(57, 103);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 1;
            label2.Text = "Username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(65, 130);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 19);
            label3.TabIndex = 2;
            label3.Text = "Password :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(91, 157);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(48, 19);
            label4.TabIndex = 3;
            label4.Text = "Email :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(11, 184);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(128, 19);
            label6.TabIndex = 5;
            label6.Text = "Driver's License ID :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(50, 229);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(82, 19);
            label7.TabIndex = 6;
            label7.Text = "Day of birth";
            // 
            // txt_newusername
            // 
            txt_newusername.Location = new Point(149, 99);
            txt_newusername.Margin = new Padding(2);
            txt_newusername.MaxLength = 16;
            txt_newusername.Name = "txt_newusername";
            txt_newusername.Size = new Size(130, 23);
            txt_newusername.TabIndex = 7;
            // 
            // txt_newpassword
            // 
            txt_newpassword.Location = new Point(149, 126);
            txt_newpassword.Margin = new Padding(2);
            txt_newpassword.MaxLength = 16;
            txt_newpassword.Name = "txt_newpassword";
            txt_newpassword.Size = new Size(130, 23);
            txt_newpassword.TabIndex = 8;
            // 
            // txt_newemail
            // 
            txt_newemail.Location = new Point(149, 153);
            txt_newemail.Margin = new Padding(2);
            txt_newemail.MaxLength = 36;
            txt_newemail.Name = "txt_newemail";
            txt_newemail.Size = new Size(130, 23);
            txt_newemail.TabIndex = 9;
            // 
            // txt_newdriverid
            // 
            txt_newdriverid.Location = new Point(149, 180);
            txt_newdriverid.Margin = new Padding(2);
            txt_newdriverid.MaxLength = 9;
            txt_newdriverid.Name = "txt_newdriverid";
            txt_newdriverid.Size = new Size(130, 23);
            txt_newdriverid.TabIndex = 11;
            // 
            // datatime_dt1
            // 
            datatime_dt1.Location = new Point(149, 225);
            datatime_dt1.Margin = new Padding(2);
            datatime_dt1.MaxDate = new DateTime(2002, 1, 1, 0, 0, 0, 0);
            datatime_dt1.MinDate = new DateTime(1920, 1, 1, 0, 0, 0, 0);
            datatime_dt1.Name = "datatime_dt1";
            datatime_dt1.Size = new Size(211, 23);
            datatime_dt1.TabIndex = 12;
            datatime_dt1.Value = new DateTime(2002, 1, 1, 0, 0, 0, 0);
            // 
            // signup_button
            // 
            signup_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            signup_button.Location = new Point(271, 313);
            signup_button.Name = "signup_button";
            signup_button.Size = new Size(146, 61);
            signup_button.TabIndex = 13;
            signup_button.Text = "Sign up";
            signup_button.UseVisualStyleBackColor = true;
            signup_button.Click += signup_button_Click;
            // 
            // Registration_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 424);
            Controls.Add(signup_button);
            Controls.Add(datatime_dt1);
            Controls.Add(txt_newdriverid);
            Controls.Add(txt_newemail);
            Controls.Add(txt_newpassword);
            Controls.Add(txt_newusername);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Registration_Form";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox txt_newusername;
        private TextBox txt_newpassword;
        private TextBox txt_newemail;
        private TextBox txt_newdriverid;
        private DateTimePicker datatime_dt1;
        private Button signup_button;
    }
}