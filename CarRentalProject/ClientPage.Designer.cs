namespace CarRentalProject
{
    partial class ClientPage
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
            this.Name_label = new System.Windows.Forms.Label();
            this.memberextra_lbl = new System.Windows.Forms.Label();
            this.summary_lbl = new System.Windows.Forms.Label();
            this.Refuel_btn = new System.Windows.Forms.Button();
            this.Car_label = new System.Windows.Forms.Label();
            this.Type_label = new System.Windows.Forms.Label();
            this.Time_label = new System.Windows.Forms.Label();
            this.Taxi_btn = new System.Windows.Forms.Button();
            this.Restaurant_btn = new System.Windows.Forms.Button();
            this.Guide_btn = new System.Windows.Forms.Button();
            this.Driver_btn = new System.Windows.Forms.Button();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name_label
            // 
            this.Name_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name_label.Location = new System.Drawing.Point(17, 9);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(771, 93);
            this.Name_label.TabIndex = 0;
            this.Name_label.Text = "name and membership level";
            // 
            // memberextra_lbl
            // 
            this.memberextra_lbl.AutoSize = true;
            this.memberextra_lbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.memberextra_lbl.Location = new System.Drawing.Point(499, 102);
            this.memberextra_lbl.Name = "memberextra_lbl";
            this.memberextra_lbl.Size = new System.Drawing.Size(179, 74);
            this.memberextra_lbl.TabIndex = 1;
            this.memberextra_lbl.Text = "Membership\r\nIncludes: ";
            // 
            // summary_lbl
            // 
            this.summary_lbl.AutoSize = true;
            this.summary_lbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.summary_lbl.Location = new System.Drawing.Point(6, 19);
            this.summary_lbl.Name = "summary_lbl";
            this.summary_lbl.Size = new System.Drawing.Size(235, 37);
            this.summary_lbl.TabIndex = 2;
            this.summary_lbl.Text = "Order Summary: ";
            // 
            // Refuel_btn
            // 
            this.Refuel_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Refuel_btn.Location = new System.Drawing.Point(417, 237);
            this.Refuel_btn.Name = "Refuel_btn";
            this.Refuel_btn.Size = new System.Drawing.Size(112, 90);
            this.Refuel_btn.TabIndex = 3;
            this.Refuel_btn.Text = "Pay For Refuel";
            this.Refuel_btn.UseVisualStyleBackColor = true;
            this.Refuel_btn.Visible = false;
            this.Refuel_btn.Click += new System.EventHandler(this.Refuel_btn_Click);
            // 
            // Car_label
            // 
            this.Car_label.AutoSize = true;
            this.Car_label.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Car_label.Location = new System.Drawing.Point(5, 73);
            this.Car_label.Name = "Car_label";
            this.Car_label.Size = new System.Drawing.Size(149, 32);
            this.Car_label.TabIndex = 6;
            this.Car_label.Text = "Rented Car: ";
            // 
            // Type_label
            // 
            this.Type_label.AutoSize = true;
            this.Type_label.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Type_label.Location = new System.Drawing.Point(6, 119);
            this.Type_label.Name = "Type_label";
            this.Type_label.Size = new System.Drawing.Size(78, 32);
            this.Type_label.TabIndex = 7;
            this.Type_label.Text = "Type: ";
            // 
            // Time_label
            // 
            this.Time_label.AutoSize = true;
            this.Time_label.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Time_label.Location = new System.Drawing.Point(5, 168);
            this.Time_label.Name = "Time_label";
            this.Time_label.Size = new System.Drawing.Size(209, 32);
            this.Time_label.TabIndex = 8;
            this.Time_label.Text = "Remaining Time:  ";
            // 
            // Taxi_btn
            // 
            this.Taxi_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Taxi_btn.Location = new System.Drawing.Point(653, 200);
            this.Taxi_btn.Name = "Taxi_btn";
            this.Taxi_btn.Size = new System.Drawing.Size(112, 90);
            this.Taxi_btn.TabIndex = 9;
            this.Taxi_btn.Text = "Set Taxi Pickup";
            this.Taxi_btn.UseVisualStyleBackColor = true;
            this.Taxi_btn.Visible = false;
            this.Taxi_btn.Click += new System.EventHandler(this.Taxi_btn_Click);
            // 
            // Restaurant_btn
            // 
            this.Restaurant_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Restaurant_btn.Location = new System.Drawing.Point(535, 296);
            this.Restaurant_btn.Name = "Restaurant_btn";
            this.Restaurant_btn.Size = new System.Drawing.Size(112, 90);
            this.Restaurant_btn.TabIndex = 10;
            this.Restaurant_btn.Text = "Restaurant Discount";
            this.Restaurant_btn.UseVisualStyleBackColor = true;
            this.Restaurant_btn.Visible = false;
            this.Restaurant_btn.Click += new System.EventHandler(this.Restaurant_btn_Click);
            // 
            // Guide_btn
            // 
            this.Guide_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Guide_btn.Location = new System.Drawing.Point(535, 200);
            this.Guide_btn.Name = "Guide_btn";
            this.Guide_btn.Size = new System.Drawing.Size(112, 90);
            this.Guide_btn.TabIndex = 11;
            this.Guide_btn.Text = "Contact Our Guide";
            this.Guide_btn.UseVisualStyleBackColor = true;
            this.Guide_btn.Visible = false;
            this.Guide_btn.Click += new System.EventHandler(this.Guide_btn_Click);
            // 
            // Driver_btn
            // 
            this.Driver_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Driver_btn.Location = new System.Drawing.Point(653, 296);
            this.Driver_btn.Name = "Driver_btn";
            this.Driver_btn.Size = new System.Drawing.Size(112, 90);
            this.Driver_btn.TabIndex = 12;
            this.Driver_btn.Text = "Manage Drivers";
            this.Driver_btn.UseVisualStyleBackColor = true;
            this.Driver_btn.Visible = false;
            this.Driver_btn.Click += new System.EventHandler(this.Driver_btn_Click);
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.summary_lbl);
            this.groupbox.Controls.Add(this.Car_label);
            this.groupbox.Controls.Add(this.Type_label);
            this.groupbox.Controls.Add(this.Time_label);
            this.groupbox.Location = new System.Drawing.Point(12, 127);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(399, 259);
            this.groupbox.TabIndex = 13;
            this.groupbox.TabStop = false;
            // 
            // ClientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupbox);
            this.Controls.Add(this.Driver_btn);
            this.Controls.Add(this.Guide_btn);
            this.Controls.Add(this.Restaurant_btn);
            this.Controls.Add(this.Taxi_btn);
            this.Controls.Add(this.Refuel_btn);
            this.Controls.Add(this.memberextra_lbl);
            this.Controls.Add(this.Name_label);
            this.Name = "ClientPage";
            this.Text = "ClientPage";
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Name_label;
        private Label memberextra_lbl;
        private Label summary_lbl;
        private Button Refuel_btn;
        private Label Car_label;
        private Label Type_label;
        private Label Time_label;
        private Button Taxi_btn;
        private Button Restaurant_btn;
        private Button Guide_btn;
        private Button Driver_btn;
        private GroupBox groupbox;
    }
}