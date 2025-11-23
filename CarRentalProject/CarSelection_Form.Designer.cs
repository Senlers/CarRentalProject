namespace CarRentalProject
{
    partial class CarSelection_Form
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
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            start_pickdate = new DateTimePicker();
            end_pickdate = new DateTimePicker();
            btn_nxtpay = new Button();
            btn_clearcars = new Button();
            Username_label = new Label();
            Category_combo = new ComboBox();
            Model_combo = new ComboBox();
            Manufacturer_combo = new ComboBox();
            label10 = new Label();
            Membership_combo = new ComboBox();
            Membership_label = new Label();
            Seats_label = new Label();
            Dyn_seats_label = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(181, 33);
            label1.Name = "label1";
            label1.Size = new Size(125, 55);
            label1.TabIndex = 1;
            label1.Text = "Dear ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(541, 33);
            label2.Name = "label2";
            label2.Size = new Size(422, 55);
            label2.TabIndex = 3;
            label2.Text = "pick the car you like!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(40, 153);
            label3.Name = "label3";
            label3.Size = new Size(216, 45);
            label3.TabIndex = 4;
            label3.Text = "Car Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(40, 260);
            label4.Name = "label4";
            label4.Size = new Size(224, 45);
            label4.TabIndex = 5;
            label4.Text = "Manufacturer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(40, 365);
            label5.Name = "label5";
            label5.Size = new Size(117, 45);
            label5.TabIndex = 6;
            label5.Text = "Model";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(40, 558);
            label7.Name = "label7";
            label7.Size = new Size(193, 45);
            label7.TabIndex = 8;
            label7.Text = "Picking day";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(477, 350);
            label8.Name = "label8";
            label8.Size = new Size(0, 45);
            label8.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(40, 647);
            label9.Name = "label9";
            label9.Size = new Size(231, 45);
            label9.TabIndex = 10;
            label9.Text = "Returning day";
            // 
            // start_pickdate
            // 
            start_pickdate.Location = new Point(274, 570);
            start_pickdate.Margin = new Padding(4, 5, 4, 5);
            start_pickdate.MinDate = new DateTime(2023, 5, 8, 0, 0, 0, 0);
            start_pickdate.Name = "start_pickdate";
            start_pickdate.Size = new Size(300, 31);
            start_pickdate.TabIndex = 15;
            start_pickdate.ValueChanged += start_pickdate_ValueChanged;
            // 
            // end_pickdate
            // 
            end_pickdate.Location = new Point(274, 658);
            end_pickdate.Margin = new Padding(4, 5, 4, 5);
            end_pickdate.Name = "end_pickdate";
            end_pickdate.Size = new Size(300, 31);
            end_pickdate.TabIndex = 16;
            // 
            // btn_nxtpay
            // 
            btn_nxtpay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_nxtpay.Location = new Point(1034, 873);
            btn_nxtpay.Margin = new Padding(4, 5, 4, 5);
            btn_nxtpay.Name = "btn_nxtpay";
            btn_nxtpay.Size = new Size(317, 100);
            btn_nxtpay.TabIndex = 18;
            btn_nxtpay.Text = "Next -> Pay";
            btn_nxtpay.UseVisualStyleBackColor = true;
            btn_nxtpay.Click += btn_nxtpay_Click;
            // 
            // btn_clearcars
            // 
            btn_clearcars.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_clearcars.Location = new Point(86, 873);
            btn_clearcars.Margin = new Padding(4, 5, 4, 5);
            btn_clearcars.Name = "btn_clearcars";
            btn_clearcars.Size = new Size(317, 100);
            btn_clearcars.TabIndex = 19;
            btn_clearcars.Text = "Clear";
            btn_clearcars.UseVisualStyleBackColor = true;
            btn_clearcars.Click += btn_clearcars_Click;
            // 
            // Username_label
            // 
            Username_label.AutoSize = true;
            Username_label.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Username_label.Location = new Point(310, 23);
            Username_label.Margin = new Padding(4, 0, 4, 0);
            Username_label.Name = "Username_label";
            Username_label.Size = new Size(194, 65);
            Username_label.TabIndex = 20;
            Username_label.Text = "label10";
            // 
            // Category_combo
            // 
            Category_combo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Category_combo.FormattingEnabled = true;
            Category_combo.Location = new Point(261, 153);
            Category_combo.Margin = new Padding(4, 5, 4, 5);
            Category_combo.Name = "Category_combo";
            Category_combo.Size = new Size(355, 53);
            Category_combo.TabIndex = 21;
            Category_combo.SelectedIndexChanged += Category_combo_SelectedIndexChanged;
            // 
            // Model_combo
            // 
            Model_combo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Model_combo.FormattingEnabled = true;
            Model_combo.Location = new Point(261, 345);
            Model_combo.Margin = new Padding(4, 5, 4, 5);
            Model_combo.Name = "Model_combo";
            Model_combo.Size = new Size(355, 53);
            Model_combo.TabIndex = 22;
            Model_combo.SelectedIndexChanged += Model_combo_SelectedIndexChanged;
            // 
            // Manufacturer_combo
            // 
            Manufacturer_combo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Manufacturer_combo.FormattingEnabled = true;
            Manufacturer_combo.Location = new Point(261, 247);
            Manufacturer_combo.Margin = new Padding(4, 5, 4, 5);
            Manufacturer_combo.Name = "Manufacturer_combo";
            Manufacturer_combo.Size = new Size(355, 53);
            Manufacturer_combo.TabIndex = 23;
            Manufacturer_combo.SelectedIndexChanged += Manufacturer_combo_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(697, 153);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(209, 45);
            label10.TabIndex = 25;
            label10.Text = "Membership";
            // 
            // Membership_combo
            // 
            Membership_combo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Membership_combo.FormattingEnabled = true;
            Membership_combo.Location = new Point(911, 148);
            Membership_combo.Margin = new Padding(4, 5, 4, 5);
            Membership_combo.Name = "Membership_combo";
            Membership_combo.Size = new Size(360, 48);
            Membership_combo.TabIndex = 26;
            Membership_combo.SelectedIndexChanged += Membership_combo_SelectedIndexChanged;
            // 
            // Membership_label
            // 
            Membership_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Membership_label.Location = new Point(697, 223);
            Membership_label.Margin = new Padding(4, 0, 4, 0);
            Membership_label.MaximumSize = new Size(214, 750);
            Membership_label.MinimumSize = new Size(643, 250);
            Membership_label.Name = "Membership_label";
            Membership_label.Size = new Size(643, 297);
            Membership_label.TabIndex = 27;
            Membership_label.Text = "label11";
            // 
            // Seats_label
            // 
            Seats_label.AutoSize = true;
            Seats_label.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Seats_label.Location = new Point(40, 470);
            Seats_label.Name = "Seats_label";
            Seats_label.Size = new Size(285, 45);
            Seats_label.TabIndex = 28;
            Seats_label.Text = "Number of seats :";
            // 
            // Dyn_seats_label
            // 
            Dyn_seats_label.AutoSize = true;
            Dyn_seats_label.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Dyn_seats_label.Location = new Point(326, 470);
            Dyn_seats_label.Name = "Dyn_seats_label";
            Dyn_seats_label.Size = new Size(93, 45);
            Dyn_seats_label.TabIndex = 29;
            Dyn_seats_label.Text = "Num";
            // 
            // CarSelection_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1441, 1075);
            Controls.Add(Dyn_seats_label);
            Controls.Add(Seats_label);
            Controls.Add(Membership_label);
            Controls.Add(Membership_combo);
            Controls.Add(label10);
            Controls.Add(Manufacturer_combo);
            Controls.Add(Model_combo);
            Controls.Add(Category_combo);
            Controls.Add(Username_label);
            Controls.Add(btn_clearcars);
            Controls.Add(btn_nxtpay);
            Controls.Add(end_pickdate);
            Controls.Add(start_pickdate);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CarSelection_Form";
            Text = "CarSelection";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private DateTimePicker start_pickdate;
        private DateTimePicker end_pickdate;
        private Button btn_nxtpay;
        private Button btn_clearcars;
        private Label Username_label;
        private ComboBox Category_combo;
        private ComboBox Model_combo;
        private ComboBox Manufacturer_combo;
        private Label label10;
        private ComboBox Membership_combo;
        private Label Membership_label;
        private Label Seats_label;
        private Label Dyn_seats_label;
    }
}