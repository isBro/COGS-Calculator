﻿namespace COGS_Calculator
{
    partial class ManageIngredientsView
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
            CostTextBox = new TextBox();
            QuantityTextBox = new TextBox();
            UoMTextBox = new TextBox();
            IngredientNameTextBox = new TextBox();
            IdTextBox = new TextBox();
            label1 = new Label();
            IngredientsDataGridView1 = new DataGridView();
            SaveIngredientButton = new Button();
            BackButton = new Button();
            EditIngredientButton = new Button();
            DeleteIngredientButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)IngredientsDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(124, 208);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(100, 23);
            CostTextBox.TabIndex = 0;
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Location = new Point(124, 170);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(100, 23);
            QuantityTextBox.TabIndex = 1;
            // 
            // UoMTextBox
            // 
            UoMTextBox.Location = new Point(124, 123);
            UoMTextBox.Name = "UoMTextBox";
            UoMTextBox.Size = new Size(100, 23);
            UoMTextBox.TabIndex = 3;
            // 
            // IngredientNameTextBox
            // 
            IngredientNameTextBox.Location = new Point(225, 70);
            IngredientNameTextBox.Name = "IngredientNameTextBox";
            IngredientNameTextBox.Size = new Size(100, 23);
            IngredientNameTextBox.TabIndex = 4;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(124, 70);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(38, 23);
            IdTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(362, 14);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 6;
            label1.Text = "Manage Ingredients";
            // 
            // IngredientsDataGridView1
            // 
            IngredientsDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IngredientsDataGridView1.Location = new Point(411, 57);
            IngredientsDataGridView1.Name = "IngredientsDataGridView1";
            IngredientsDataGridView1.RowTemplate.Height = 25;
            IngredientsDataGridView1.Size = new Size(436, 225);
            IngredientsDataGridView1.TabIndex = 7;
            // 
            // SaveIngredientButton
            // 
            SaveIngredientButton.Location = new Point(124, 298);
            SaveIngredientButton.Name = "SaveIngredientButton";
            SaveIngredientButton.Size = new Size(75, 23);
            SaveIngredientButton.TabIndex = 8;
            SaveIngredientButton.Text = "Save";
            SaveIngredientButton.UseVisualStyleBackColor = true;
            SaveIngredientButton.Click += SaveIngredientButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(16, 10);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 9;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            // 
            // EditIngredientButton
            // 
            EditIngredientButton.Location = new Point(461, 298);
            EditIngredientButton.Name = "EditIngredientButton";
            EditIngredientButton.Size = new Size(75, 23);
            EditIngredientButton.TabIndex = 10;
            EditIngredientButton.Text = "Edit";
            EditIngredientButton.UseVisualStyleBackColor = true;
            // 
            // DeleteIngredientButton
            // 
            DeleteIngredientButton.Location = new Point(684, 298);
            DeleteIngredientButton.Name = "DeleteIngredientButton";
            DeleteIngredientButton.Size = new Size(75, 23);
            DeleteIngredientButton.TabIndex = 11;
            DeleteIngredientButton.Text = "Delete";
            DeleteIngredientButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 78);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 12;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 78);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 13;
            label3.Text = "Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 126);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 14;
            label4.Text = "UoM";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 173);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 16;
            label6.Text = "Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(62, 211);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 17;
            label7.Text = "Unit Cost";
            // 
            // ManageIngredientsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(DeleteIngredientButton);
            Controls.Add(EditIngredientButton);
            Controls.Add(BackButton);
            Controls.Add(SaveIngredientButton);
            Controls.Add(IngredientsDataGridView1);
            Controls.Add(label1);
            Controls.Add(IdTextBox);
            Controls.Add(IngredientNameTextBox);
            Controls.Add(UoMTextBox);
            Controls.Add(QuantityTextBox);
            Controls.Add(CostTextBox);
            Name = "ManageIngredientsView";
            Text = "ManageIngredientsView";
            ((System.ComponentModel.ISupportInitialize)IngredientsDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion



        private TextBox CostTextBox;
        private TextBox QuantityTextBox;
        private TextBox UoMTextBox;
        private TextBox IngredientNameTextBox;
        private TextBox IdTextBox;
        private Label label1;
        private DataGridView IngredientsDataGridView1;
        private Button SaveIngredientButton;
        private Button BackButton;
        private Button EditIngredientButton;
        private Button DeleteIngredientButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}