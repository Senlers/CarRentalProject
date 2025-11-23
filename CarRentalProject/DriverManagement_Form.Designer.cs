namespace CarRentalProject
{
    partial class DriverManagement_Form
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
            ID_combo = new ComboBox();
            ID_label = new Label();
            Name_label = new Label();
            Family_label = new Label();
            Remove_button = new Button();
            DynFamily_label = new Label();
            DynDriver_label = new Label();
            Add_button = new Button();
            SuspendLayout();
            // 
            // ID_combo
            // 
            ID_combo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            ID_combo.FormattingEnabled = true;
            ID_combo.Location = new Point(275, 61);
            ID_combo.Name = "ID_combo";
            ID_combo.Size = new Size(250, 38);
            ID_combo.TabIndex = 22;
            ID_combo.SelectedIndexChanged += Driver_combo_SelectedIndexChanged;
            // 
            // ID_label
            // 
            ID_label.AutoSize = true;
            ID_label.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            ID_label.Location = new Point(91, 62);
            ID_label.Name = "ID_label";
            ID_label.Size = new Size(159, 37);
            ID_label.TabIndex = 23;
            ID_label.Text = "Driver's ID:";
            // 
            // Name_label
            // 
            Name_label.AutoSize = true;
            Name_label.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            Name_label.Location = new Point(30, 138);
            Name_label.Name = "Name_label";
            Name_label.Size = new Size(107, 37);
            Name_label.TabIndex = 24;
            Name_label.Text = "Name :";
            // 
            // Family_label
            // 
            Family_label.AutoSize = true;
            Family_label.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            Family_label.Location = new Point(30, 203);
            Family_label.Name = "Family_label";
            Family_label.Size = new Size(191, 37);
            Family_label.TabIndex = 25;
            Family_label.Text = "Family Name:";
            // 
            // Remove_button
            // 
            Remove_button.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Remove_button.Location = new Point(42, 303);
            Remove_button.Name = "Remove_button";
            Remove_button.Size = new Size(208, 98);
            Remove_button.TabIndex = 26;
            Remove_button.Text = "Remove";
            Remove_button.UseVisualStyleBackColor = true;
            Remove_button.Click += Remove_button_Click;
            // 
            // DynFamily_label
            // 
            DynFamily_label.AutoSize = true;
            DynFamily_label.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            DynFamily_label.Location = new Point(227, 203);
            DynFamily_label.Name = "DynFamily_label";
            DynFamily_label.Size = new Size(179, 37);
            DynFamily_label.TabIndex = 28;
            DynFamily_label.Text = "Family name";
            // 
            // DynDriver_label
            // 
            DynDriver_label.AutoSize = true;
            DynDriver_label.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            DynDriver_label.Location = new Point(143, 138);
            DynDriver_label.Name = "DynDriver_label";
            DynDriver_label.Size = new Size(187, 37);
            DynDriver_label.TabIndex = 27;
            DynDriver_label.Text = "Drivers name";
            // 
            // Add_button
            // 
            Add_button.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Add_button.Location = new Point(513, 303);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(208, 98);
            Add_button.TabIndex = 30;
            Add_button.Text = "Add";
            Add_button.UseVisualStyleBackColor = true;
            Add_button.Click += Add_button_Click;
            // 
            // DriverManagement_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Add_button);
            Controls.Add(DynFamily_label);
            Controls.Add(DynDriver_label);
            Controls.Add(Remove_button);
            Controls.Add(Family_label);
            Controls.Add(Name_label);
            Controls.Add(ID_label);
            Controls.Add(ID_combo);
            Name = "DriverManagement_Form";
            Text = "DriverManagement_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ID_combo;
        private Label ID_label;
        private Label Name_label;
        private Label Family_label;
        private Button Remove_button;
        private Label DynFamily_label;
        private Label DynDriver_label;
        private Button Add_button;
    }
}