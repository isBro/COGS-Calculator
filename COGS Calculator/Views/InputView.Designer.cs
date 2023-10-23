namespace COGS_Calculator.Views
{
    partial class InputView
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
            InputTextBox = new TextBox();
            Submit_Button = new Button();
            Ingredient_Label = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 84);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Ingredient Quantity";
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(168, 129);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.PlaceholderText = "1.0";
            InputTextBox.Size = new Size(100, 23);
            InputTextBox.TabIndex = 1;
            // 
            // Submit_Button
            // 
            Submit_Button.Location = new Point(182, 179);
            Submit_Button.Name = "Submit_Button";
            Submit_Button.Size = new Size(75, 23);
            Submit_Button.TabIndex = 2;
            Submit_Button.Text = "Submit";
            Submit_Button.UseVisualStyleBackColor = true;
            Submit_Button.Click += Submit_Button_Click;
            // 
            // Ingredient_Label
            // 
            Ingredient_Label.AutoSize = true;
            Ingredient_Label.Location = new Point(95, 132);
            Ingredient_Label.Name = "Ingredient_Label";
            Ingredient_Label.Size = new Size(67, 15);
            Ingredient_Label.TabIndex = 3;
            Ingredient_Label.Text = "Ingredient: ";
            // 
            // InputView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 450);
            Controls.Add(Ingredient_Label);
            Controls.Add(Submit_Button);
            Controls.Add(InputTextBox);
            Controls.Add(label1);
            Name = "InputView";
            Text = "InputView";
            Load += InputView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox InputTextBox;
        private Button Submit_Button;
        private Label Ingredient_Label;
    }
}