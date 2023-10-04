namespace COGS_Calculator
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
            this.CostTextBox = new TextBox();
            this.QuantityTextBox = new TextBox();
            this.UoMTextBox = new TextBox();
            this.IngredientNameTextBox = new TextBox();
            this.IdTextBox = new TextBox();
            label1 = new Label();
            this.IngredientsDataGridView1 = new DataGridView();
            this.SaveIngredientButton = new Button();
            this.BackButton = new Button();
            this.EditIngredientButton = new Button();
            DeleteIngredientButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)this.IngredientsDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new Point(124, 208);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new Size(100, 23);
            this.CostTextBox.TabIndex = 0;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new Point(124, 170);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new Size(100, 23);
            this.QuantityTextBox.TabIndex = 1;
            // 
            // UoMTextBox
            // 
            this.UoMTextBox.Location = new Point(124, 123);
            this.UoMTextBox.Name = "UoMTextBox";
            this.UoMTextBox.Size = new Size(100, 23);
            this.UoMTextBox.TabIndex = 3;
            // 
            // IngredientNameTextBox
            // 
            this.IngredientNameTextBox.Location = new Point(225, 70);
            this.IngredientNameTextBox.Name = "IngredientNameTextBox";
            this.IngredientNameTextBox.Size = new Size(100, 23);
            this.IngredientNameTextBox.TabIndex = 4;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new Point(124, 70);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new Size(38, 23);
            this.IdTextBox.TabIndex = 5;
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
            this.IngredientsDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IngredientsDataGridView1.Location = new Point(411, 57);
            this.IngredientsDataGridView1.Name = "IngredientsDataGridView1";
            this.IngredientsDataGridView1.RowTemplate.Height = 25;
            this.IngredientsDataGridView1.Size = new Size(436, 225);
            this.IngredientsDataGridView1.TabIndex = 7;
            // 
            // SaveIngredientButton
            // 
            this.SaveIngredientButton.Location = new Point(124, 298);
            this.SaveIngredientButton.Name = "SaveIngredientButton";
            this.SaveIngredientButton.Size = new Size(75, 23);
            this.SaveIngredientButton.TabIndex = 8;
            this.SaveIngredientButton.Text = "Save";
            this.SaveIngredientButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Location = new Point(16, 10);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new Size(75, 23);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // EditIngredientButton
            // 
            this.EditIngredientButton.Location = new Point(461, 298);
            this.EditIngredientButton.Name = "EditIngredientButton";
            this.EditIngredientButton.Size = new Size(75, 23);
            this.EditIngredientButton.TabIndex = 10;
            this.EditIngredientButton.Text = "Edit";
            this.EditIngredientButton.UseVisualStyleBackColor = true;
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
            Controls.Add(this.EditIngredientButton);
            Controls.Add(this.BackButton);
            Controls.Add(this.SaveIngredientButton);
            Controls.Add(this.IngredientsDataGridView1);
            Controls.Add(label1);
            Controls.Add(this.IdTextBox);
            Controls.Add(this.IngredientNameTextBox);
            Controls.Add(this.UoMTextBox);
            Controls.Add(this.QuantityTextBox);
            Controls.Add(this.CostTextBox);
            Name = "ManageIngredientsView";
            Text = "ManageIngredientsView";
            ((System.ComponentModel.ISupportInitialize)this.IngredientsDataGridView1).EndInit();
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