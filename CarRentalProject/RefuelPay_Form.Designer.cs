namespace CarRentalProject
{
    partial class RefuelPay_Form
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
            Remaining_label = new Label();
            Pay_txt = new TextBox();
            Submit_button = new Button();
            SuspendLayout();
            // 
            // Remaining_label
            // 
            Remaining_label.AutoSize = true;
            Remaining_label.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            Remaining_label.Location = new Point(306, 66);
            Remaining_label.Name = "Remaining_label";
            Remaining_label.Size = new Size(224, 37);
            Remaining_label.TabIndex = 28;
            Remaining_label.Text = "Remaining label";
            // 
            // Pay_txt
            // 
            Pay_txt.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            Pay_txt.Location = new Point(272, 171);
            Pay_txt.Name = "Pay_txt";
            Pay_txt.Size = new Size(304, 43);
            Pay_txt.TabIndex = 29;
            Pay_txt.KeyPress += Pay_txt_KeyPress;
            // 
            // Submit_button
            // 
            Submit_button.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Submit_button.Location = new Point(322, 266);
            Submit_button.Name = "Submit_button";
            Submit_button.Size = new Size(208, 98);
            Submit_button.TabIndex = 35;
            Submit_button.Text = "Submit";
            Submit_button.UseVisualStyleBackColor = true;
            Submit_button.Click += Submit_button_Click;
            // 
            // RefuelPay_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Submit_button);
            Controls.Add(Pay_txt);
            Controls.Add(Remaining_label);
            Name = "RefuelPay_Form";
            Text = "RefuelPay_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Remaining_label;
        private TextBox Pay_txt;
        private Button Submit_button;
    }
}