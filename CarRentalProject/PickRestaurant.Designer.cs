namespace CarRentalProject
{
    partial class PickRestaurant
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
            memberextra_lbl = new Label();
            north_radio = new RadioButton();
            meat_radio = new RadioButton();
            south_radio = new RadioButton();
            pick_rest_btn = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // memberextra_lbl
            // 
            memberextra_lbl.AutoSize = true;
            memberextra_lbl.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            memberextra_lbl.Location = new Point(153, 25);
            memberextra_lbl.Name = "memberextra_lbl";
            memberextra_lbl.Size = new Size(459, 74);
            memberextra_lbl.TabIndex = 2;
            memberextra_lbl.Text = "Pick a restaurant from the list and \r\nget 20% off your first meal there!";
            // 
            // north_radio
            // 
            north_radio.AutoSize = true;
            north_radio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            north_radio.Location = new Point(6, 35);
            north_radio.Name = "north_radio";
            north_radio.Size = new Size(172, 25);
            north_radio.TabIndex = 3;
            north_radio.TabStop = true;
            north_radio.Text = "The Northen Sailor";
            north_radio.UseVisualStyleBackColor = true;
            north_radio.CheckedChanged += north_radio_CheckedChanged;
            // 
            // meat_radio
            // 
            meat_radio.AutoSize = true;
            meat_radio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            meat_radio.Location = new Point(6, 90);
            meat_radio.Name = "meat_radio";
            meat_radio.Size = new Size(184, 25);
            meat_radio.TabIndex = 4;
            meat_radio.TabStop = true;
            meat_radio.Text = "The Meat of the seas";
            meat_radio.UseVisualStyleBackColor = true;
            meat_radio.CheckedChanged += meat_radio_CheckedChanged;
            // 
            // south_radio
            // 
            south_radio.AutoSize = true;
            south_radio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            south_radio.Location = new Point(6, 147);
            south_radio.Name = "south_radio";
            south_radio.Size = new Size(182, 25);
            south_radio.TabIndex = 5;
            south_radio.TabStop = true;
            south_radio.Text = "Southern Dutchman";
            south_radio.UseVisualStyleBackColor = true;
            south_radio.CheckedChanged += south_radio_CheckedChanged;
            // 
            // pick_rest_btn
            // 
            pick_rest_btn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            pick_rest_btn.Location = new Point(541, 336);
            pick_rest_btn.Name = "pick_rest_btn";
            pick_rest_btn.Size = new Size(131, 122);
            pick_rest_btn.TabIndex = 6;
            pick_rest_btn.Text = "Press to confirm";
            pick_rest_btn.UseVisualStyleBackColor = true;
            pick_rest_btn.Visible = false;
            pick_rest_btn.Click += pick_rest_btn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(north_radio);
            groupBox1.Controls.Add(meat_radio);
            groupBox1.Controls.Add(south_radio);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(277, 135);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(206, 194);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pick one!";
            // 
            // PickRestaurant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 484);
            Controls.Add(groupBox1);
            Controls.Add(pick_rest_btn);
            Controls.Add(memberextra_lbl);
            Name = "PickRestaurant";
            Text = "PickRestaurant";
            Load += PickRestaurant_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label memberextra_lbl;
        private RadioButton north_radio;
        private RadioButton meat_radio;
        private RadioButton south_radio;
        private Button pick_rest_btn;
        private GroupBox groupBox1;
    }
}