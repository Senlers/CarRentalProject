namespace CarRentalProject
{
    partial class AddEdit_Form
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
            Name_label = new Label();
            ID_label = new Label();
            Submit_button = new Button();
            Name_txt = new TextBox();
            ID_txt = new TextBox();
            Family_label = new Label();
            DynFamily_txt = new TextBox();
            SuspendLayout();
            // 
            // Name_label
            // 
            Name_label.AutoSize = true;
            Name_label.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            Name_label.Location = new Point(108, 52);
            Name_label.Name = "Name_label";
            Name_label.Size = new Size(107, 37);
            Name_label.TabIndex = 25;
            Name_label.Text = "Name :";
            // 
            // ID_label
            // 
            ID_label.AutoSize = true;
            ID_label.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            ID_label.Location = new Point(108, 199);
            ID_label.Name = "ID_label";
            ID_label.Size = new Size(147, 37);
            ID_label.TabIndex = 26;
            ID_label.Text = "ID license:";
            // 
            // Submit_button
            // 
            Submit_button.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Submit_button.Location = new Point(519, 306);
            Submit_button.Name = "Submit_button";
            Submit_button.Size = new Size(208, 98);
            Submit_button.TabIndex = 34;
            Submit_button.Text = "Submit";
            Submit_button.UseVisualStyleBackColor = true;
            Submit_button.Click += Submit_button_Click;
            // 
            // Name_txt
            // 
            Name_txt.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            Name_txt.Location = new Point(305, 49);
            Name_txt.MaxLength = 32;
            Name_txt.Name = "Name_txt";
            Name_txt.Size = new Size(319, 43);
            Name_txt.TabIndex = 31;
            Name_txt.KeyPress += Name_txt_KeyPress;
            // 
            // ID_txt
            // 
            ID_txt.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            ID_txt.Location = new Point(305, 193);
            ID_txt.MaxLength = 9;
            ID_txt.Name = "ID_txt";
            ID_txt.Size = new Size(319, 43);
            ID_txt.TabIndex = 33;
            ID_txt.KeyPress += ID_txt_KeyPress;
            // 
            // Family_label
            // 
            Family_label.AutoSize = true;
            Family_label.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            Family_label.Location = new Point(108, 122);
            Family_label.Name = "Family_label";
            Family_label.Size = new Size(191, 37);
            Family_label.TabIndex = 34;
            Family_label.Text = "Family Name:";
            // 
            // DynFamily_txt
            // 
            DynFamily_txt.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            DynFamily_txt.Location = new Point(305, 119);
            DynFamily_txt.MaxLength = 32;
            DynFamily_txt.Name = "DynFamily_txt";
            DynFamily_txt.Size = new Size(319, 43);
            DynFamily_txt.TabIndex = 32;
            DynFamily_txt.KeyPress += DynFamily_txt_KeyPress;
            // 
            // AddEdit_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DynFamily_txt);
            Controls.Add(Family_label);
            Controls.Add(ID_txt);
            Controls.Add(Name_txt);
            Controls.Add(Submit_button);
            Controls.Add(ID_label);
            Controls.Add(Name_label);
            Name = "AddEdit_Form";
            Text = "AddEdit_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Name_label;
        private Label ID_label;
        private Button Submit_button;
        private TextBox Name_txt;
        private TextBox ID_txt;
        private Label Family_label;
        private TextBox DynFamily_txt;
    }
}