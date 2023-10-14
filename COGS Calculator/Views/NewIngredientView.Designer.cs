namespace COGS_Calculator.Views
{
    partial class NewIngredientView
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
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            SaveIngredientButton = new Button();
            IngredientNameTextBox = new TextBox();
            UoMTextBox = new TextBox();
            QuantityTextBox = new TextBox();
            CostTextBox = new TextBox();
            BackButton = new Button();
            CategoryLabel = new Label();
            CategoryTextBox = new TextBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 211);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 28;
            label7.Text = "Unit Cost";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 173);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 27;
            label6.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 126);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 26;
            label4.Text = "UoM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 89);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 24;
            label2.Text = "Name";
            // 
            // SaveIngredientButton
            // 
            SaveIngredientButton.Location = new Point(106, 298);
            SaveIngredientButton.Name = "SaveIngredientButton";
            SaveIngredientButton.Size = new Size(75, 23);
            SaveIngredientButton.TabIndex = 23;
            SaveIngredientButton.Text = "Save";
            SaveIngredientButton.UseVisualStyleBackColor = true;
            SaveIngredientButton.Click += SaveIngredientButton_Click;
            // 
            // IngredientNameTextBox
            // 
            IngredientNameTextBox.Location = new Point(106, 86);
            IngredientNameTextBox.Name = "IngredientNameTextBox";
            IngredientNameTextBox.Size = new Size(100, 23);
            IngredientNameTextBox.TabIndex = 21;
            // 
            // UoMTextBox
            // 
            UoMTextBox.Location = new Point(106, 123);
            UoMTextBox.Name = "UoMTextBox";
            UoMTextBox.Size = new Size(100, 23);
            UoMTextBox.TabIndex = 20;
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Location = new Point(106, 170);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(100, 23);
            QuantityTextBox.TabIndex = 19;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(106, 208);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(100, 23);
            CostTextBox.TabIndex = 18;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 29;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(44, 255);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(55, 15);
            CategoryLabel.TabIndex = 31;
            CategoryLabel.Text = "Category";
            // 
            // CategoryTextBox
            // 
            CategoryTextBox.Location = new Point(106, 252);
            CategoryTextBox.Name = "CategoryTextBox";
            CategoryTextBox.Size = new Size(100, 23);
            CategoryTextBox.TabIndex = 30;
            // 
            // NewIngredientView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 450);
            Controls.Add(CategoryLabel);
            Controls.Add(CategoryTextBox);
            Controls.Add(BackButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(SaveIngredientButton);
            Controls.Add(IngredientNameTextBox);
            Controls.Add(UoMTextBox);
            Controls.Add(QuantityTextBox);
            Controls.Add(CostTextBox);
            Name = "NewIngredientView";
            Text = "NewIngredientView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Label label4;
        private Label label2;
        private Button SaveIngredientButton;
        private TextBox IngredientNameTextBox;
        private TextBox UoMTextBox;
        private TextBox QuantityTextBox;
        private TextBox CostTextBox;
        private Button BackButton;
        private Label CategoryLabel;
        private TextBox CategoryTextBox;
    }
}