namespace COGS_Calculator.Views
{
    partial class EditIngredientView
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
            CategoryComboBox = new ComboBox();
            UoMComboBox = new ComboBox();
            CategoryLabel = new Label();
            BackButton = new Button();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            SaveIngredientButton = new Button();
            IngredientNameTextBox = new TextBox();
            QuantityTextBox = new TextBox();
            CostTextBox = new TextBox();
            SuspendLayout();
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(112, 255);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(100, 23);
            CategoryComboBox.TabIndex = 45;
            // 
            // UoMComboBox
            // 
            UoMComboBox.FormattingEnabled = true;
            UoMComboBox.Location = new Point(112, 126);
            UoMComboBox.Name = "UoMComboBox";
            UoMComboBox.Size = new Size(100, 23);
            UoMComboBox.TabIndex = 44;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(50, 258);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(55, 15);
            CategoryLabel.TabIndex = 43;
            CategoryLabel.Text = "Category";
            // 
            // BackButton
            // 
            BackButton.Location = new Point(18, 15);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 42;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 214);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 41;
            label7.Text = "Unit Cost";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 176);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 40;
            label6.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 129);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 39;
            label4.Text = "UoM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 92);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 38;
            label2.Text = "Name";
            // 
            // SaveIngredientButton
            // 
            SaveIngredientButton.Location = new Point(112, 301);
            SaveIngredientButton.Name = "SaveIngredientButton";
            SaveIngredientButton.Size = new Size(75, 23);
            SaveIngredientButton.TabIndex = 37;
            SaveIngredientButton.Text = "Save";
            SaveIngredientButton.UseVisualStyleBackColor = true;
            SaveIngredientButton.Click += SaveIngredientButton_Click;
            // 
            // IngredientNameTextBox
            // 
            IngredientNameTextBox.Location = new Point(112, 89);
            IngredientNameTextBox.Name = "IngredientNameTextBox";
            IngredientNameTextBox.Size = new Size(100, 23);
            IngredientNameTextBox.TabIndex = 36;
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Location = new Point(112, 173);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(100, 23);
            QuantityTextBox.TabIndex = 35;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(112, 211);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(100, 23);
            CostTextBox.TabIndex = 34;
            // 
            // EditIngredientView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 387);
            Controls.Add(CategoryComboBox);
            Controls.Add(UoMComboBox);
            Controls.Add(CategoryLabel);
            Controls.Add(BackButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(SaveIngredientButton);
            Controls.Add(IngredientNameTextBox);
            Controls.Add(QuantityTextBox);
            Controls.Add(CostTextBox);
            Name = "EditIngredientView";
            Text = "EditIngredientView";
            Load += EditIngredientView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CategoryComboBox;
        private ComboBox UoMComboBox;
        private Label CategoryLabel;
        private Button BackButton;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label2;
        private Button SaveIngredientButton;
        private TextBox IngredientNameTextBox;
        private TextBox QuantityTextBox;
        private TextBox CostTextBox;
    }
}