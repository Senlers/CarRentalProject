namespace CarRentalProject
{
    partial class TaxiTimePick
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
            picker_date = new DateTimePicker();
            arrive_lbl = new Label();
            ar_time_lbl = new Label();
            picker_time = new DateTimePicker();
            pickup_btn = new Button();
            SuspendLayout();
            // 
            // memberextra_lbl
            // 
            memberextra_lbl.AutoSize = true;
            memberextra_lbl.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            memberextra_lbl.Location = new Point(12, 18);
            memberextra_lbl.Name = "memberextra_lbl";
            memberextra_lbl.Size = new Size(588, 111);
            memberextra_lbl.TabIndex = 3;
            memberextra_lbl.Text = "Tell us when will you be arriving\r\n and we will send a taxi driver to pick you up\r\n and drop you at CarASAP counter";
            // 
            // picker_date
            // 
            picker_date.Location = new Point(183, 215);
            picker_date.Name = "picker_date";
            picker_date.Size = new Size(281, 23);
            picker_date.TabIndex = 4;
            picker_date.ValueChanged += picker_date_ValueChanged;
            // 
            // arrive_lbl
            // 
            arrive_lbl.AutoSize = true;
            arrive_lbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            arrive_lbl.Location = new Point(11, 209);
            arrive_lbl.Margin = new Padding(2, 0, 2, 0);
            arrive_lbl.Name = "arrive_lbl";
            arrive_lbl.Size = new Size(141, 30);
            arrive_lbl.TabIndex = 9;
            arrive_lbl.Text = "Arriving day";
            // 
            // ar_time_lbl
            // 
            ar_time_lbl.AutoSize = true;
            ar_time_lbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            ar_time_lbl.Location = new Point(12, 282);
            ar_time_lbl.Margin = new Padding(2, 0, 2, 0);
            ar_time_lbl.Name = "ar_time_lbl";
            ar_time_lbl.Size = new Size(150, 30);
            ar_time_lbl.TabIndex = 10;
            ar_time_lbl.Text = "Arriving time";
            // 
            // picker_time
            // 
            picker_time.Format = DateTimePickerFormat.Time;
            picker_time.Location = new Point(183, 288);
            picker_time.Name = "picker_time";
            picker_time.Size = new Size(104, 23);
            picker_time.TabIndex = 11;
            picker_time.ValueChanged += picker_time_ValueChanged;
            // 
            // pickup_btn
            // 
            pickup_btn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            pickup_btn.Location = new Point(563, 302);
            pickup_btn.Name = "pickup_btn";
            pickup_btn.Size = new Size(131, 122);
            pickup_btn.TabIndex = 12;
            pickup_btn.Text = "Press to confirm";
            pickup_btn.UseVisualStyleBackColor = true;
            pickup_btn.Visible = false;
            pickup_btn.Click += pickup_btn_Click;
            // 
            // TaxiTimePick
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pickup_btn);
            Controls.Add(picker_time);
            Controls.Add(ar_time_lbl);
            Controls.Add(arrive_lbl);
            Controls.Add(picker_date);
            Controls.Add(memberextra_lbl);
            Name = "TaxiTimePick";
            Text = "TaxiTimePick";
            Load += TaxiTimePick_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label memberextra_lbl;
        private DateTimePicker picker_date;
        private Label arrive_lbl;
        private Label ar_time_lbl;
        private DateTimePicker picker_time;
        private Button pickup_btn;
    }
}