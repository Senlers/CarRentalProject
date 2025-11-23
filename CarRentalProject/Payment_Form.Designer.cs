namespace CarRentalProject
{
    partial class Payment_Form
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
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.Name_Label = new System.Windows.Forms.Label();
            this.CardNum_Label = new System.Windows.Forms.Label();
            this.CVC_Label = new System.Windows.Forms.Label();
            this.Expiration_Label = new System.Windows.Forms.Label();
            this.CardNum_txt = new System.Windows.Forms.TextBox();
            this.CVC_txt = new System.Windows.Forms.TextBox();
            this.Expiration_txt = new System.Windows.Forms.TextBox();
            this.pay_btn = new System.Windows.Forms.Button();
            this.Amount_label = new System.Windows.Forms.Label();
            this.Cost_label = new System.Windows.Forms.Label();
            this.Voucher_label = new System.Windows.Forms.Label();
            this.VoucherCost_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.payment_combo = new System.Windows.Forms.ComboBox();
            this.installment_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name_txt
            // 
            this.Name_txt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name_txt.Location = new System.Drawing.Point(212, 48);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(383, 36);
            this.Name_txt.TabIndex = 0;
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name_Label.Location = new System.Drawing.Point(212, 24);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(119, 21);
            this.Name_Label.TabIndex = 1;
            this.Name_Label.Text = "Name on Card";
            // 
            // CardNum_Label
            // 
            this.CardNum_Label.AutoSize = true;
            this.CardNum_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CardNum_Label.Location = new System.Drawing.Point(212, 87);
            this.CardNum_Label.Name = "CardNum_Label";
            this.CardNum_Label.Size = new System.Drawing.Size(112, 21);
            this.CardNum_Label.TabIndex = 2;
            this.CardNum_Label.Text = "Card Number";
            // 
            // CVC_Label
            // 
            this.CVC_Label.AutoSize = true;
            this.CVC_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CVC_Label.Location = new System.Drawing.Point(212, 187);
            this.CVC_Label.Name = "CVC_Label";
            this.CVC_Label.Size = new System.Drawing.Size(41, 21);
            this.CVC_Label.TabIndex = 3;
            this.CVC_Label.Text = "CVC";
            // 
            // Expiration_Label
            // 
            this.Expiration_Label.AutoSize = true;
            this.Expiration_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Expiration_Label.Location = new System.Drawing.Point(350, 187);
            this.Expiration_Label.Name = "Expiration_Label";
            this.Expiration_Label.Size = new System.Drawing.Size(89, 21);
            this.Expiration_Label.TabIndex = 4;
            this.Expiration_Label.Text = "Expiration";
            // 
            // CardNum_txt
            // 
            this.CardNum_txt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CardNum_txt.Location = new System.Drawing.Point(212, 111);
            this.CardNum_txt.MaxLength = 16;
            this.CardNum_txt.Name = "CardNum_txt";
            this.CardNum_txt.Size = new System.Drawing.Size(383, 36);
            this.CardNum_txt.TabIndex = 5;
            // 
            // CVC_txt
            // 
            this.CVC_txt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CVC_txt.Location = new System.Drawing.Point(259, 177);
            this.CVC_txt.MaxLength = 3;
            this.CVC_txt.Name = "CVC_txt";
            this.CVC_txt.Size = new System.Drawing.Size(65, 36);
            this.CVC_txt.TabIndex = 6;
            // 
            // Expiration_txt
            // 
            this.Expiration_txt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Expiration_txt.Location = new System.Drawing.Point(445, 177);
            this.Expiration_txt.MaxLength = 5;
            this.Expiration_txt.Name = "Expiration_txt";
            this.Expiration_txt.Size = new System.Drawing.Size(89, 36);
            this.Expiration_txt.TabIndex = 7;
            // 
            // pay_btn
            // 
            this.pay_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pay_btn.Location = new System.Drawing.Point(550, 280);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(177, 77);
            this.pay_btn.TabIndex = 8;
            this.pay_btn.Text = "Pay";
            this.pay_btn.UseVisualStyleBackColor = true;
            this.pay_btn.Click += new System.EventHandler(this.Pay);
            // 
            // Amount_label
            // 
            this.Amount_label.AutoSize = true;
            this.Amount_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Amount_label.Location = new System.Drawing.Point(64, 249);
            this.Amount_label.Name = "Amount_label";
            this.Amount_label.Size = new System.Drawing.Size(135, 37);
            this.Amount_label.TabIndex = 9;
            this.Amount_label.Text = "Amount :";
            // 
            // Cost_label
            // 
            this.Cost_label.AutoSize = true;
            this.Cost_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cost_label.Location = new System.Drawing.Point(212, 249);
            this.Cost_label.Name = "Cost_label";
            this.Cost_label.Size = new System.Drawing.Size(74, 37);
            this.Cost_label.TabIndex = 10;
            this.Cost_label.Text = "Cost";
            // 
            // Voucher_label
            // 
            this.Voucher_label.AutoSize = true;
            this.Voucher_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Voucher_label.Location = new System.Drawing.Point(62, 412);
            this.Voucher_label.Name = "Voucher_label";
            this.Voucher_label.Size = new System.Drawing.Size(191, 25);
            this.Voucher_label.TabIndex = 11;
            this.Voucher_label.Text = "Refueling Voucher : ";
            // 
            // VoucherCost_label
            // 
            this.VoucherCost_label.AutoSize = true;
            this.VoucherCost_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VoucherCost_label.Location = new System.Drawing.Point(244, 412);
            this.VoucherCost_label.Name = "VoucherCost_label";
            this.VoucherCost_label.Size = new System.Drawing.Size(51, 25);
            this.VoucherCost_label.TabIndex = 12;
            this.VoucherCost_label.Text = "Cost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Payments:";
            // 
            // payment_combo
            // 
            this.payment_combo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.payment_combo.FormattingEnabled = true;
            this.payment_combo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.payment_combo.Location = new System.Drawing.Point(177, 310);
            this.payment_combo.Name = "payment_combo";
            this.payment_combo.Size = new System.Drawing.Size(52, 38);
            this.payment_combo.TabIndex = 22;
            this.payment_combo.SelectedIndexChanged += new System.EventHandler(this.payment_combo_SelectedIndexChanged);
            // 
            // installment_txt
            // 
            this.installment_txt.AutoSize = true;
            this.installment_txt.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.installment_txt.Location = new System.Drawing.Point(62, 361);
            this.installment_txt.Name = "installment_txt";
            this.installment_txt.Size = new System.Drawing.Size(162, 37);
            this.installment_txt.TabIndex = 23;
            this.installment_txt.Text = "installment";
            this.installment_txt.Visible = false;
            // 
            // Payment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.installment_txt);
            this.Controls.Add(this.payment_combo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VoucherCost_label);
            this.Controls.Add(this.Voucher_label);
            this.Controls.Add(this.Cost_label);
            this.Controls.Add(this.Amount_label);
            this.Controls.Add(this.pay_btn);
            this.Controls.Add(this.Expiration_txt);
            this.Controls.Add(this.CVC_txt);
            this.Controls.Add(this.CardNum_txt);
            this.Controls.Add(this.Expiration_Label);
            this.Controls.Add(this.CVC_Label);
            this.Controls.Add(this.CardNum_Label);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.Name_txt);
            this.Name = "Payment_Form";
            this.Text = "Payment_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Name_txt;
        private Label Name_Label;
        private Label CardNum_Label;
        private Label CVC_Label;
        private Label Expiration_Label;
        private TextBox CardNum_txt;
        private TextBox CVC_txt;
        private TextBox Expiration_txt;
        private Button pay_btn;
        private Label Amount_label;
        private Label Cost_label;
        private Label Voucher_label;
        private Label VoucherCost_label;
        private Label label1;
        private ComboBox payment_combo;
        private Label installment_txt;
    }
}