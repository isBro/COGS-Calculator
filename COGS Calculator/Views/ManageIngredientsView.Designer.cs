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
            CostTextBox = new TextBox();
            QuantityTextBox = new TextBox();
            IngredientNameTextBox = new TextBox();
            IdTextBox = new TextBox();
            label1 = new Label();
            IngredientsDataGridView1 = new DataGridView();
            SaveIngredientButton = new Button();
            BackButton = new Button();
            DeleteIngredientButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            NewIngredientButton = new Button();
            CategoryLabel = new Label();
            UoMComboBox = new ComboBox();
            CategoryComboBox = new ComboBox();
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
            // IngredientNameTextBox
            // 
            IngredientNameTextBox.Enabled = false;
            IngredientNameTextBox.Location = new Point(225, 70);
            IngredientNameTextBox.Name = "IngredientNameTextBox";
            IngredientNameTextBox.Size = new Size(100, 23);
            IngredientNameTextBox.TabIndex = 4;
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
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
            IngredientsDataGridView1.AllowUserToAddRows = false;
            IngredientsDataGridView1.AllowUserToDeleteRows = false;
            IngredientsDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IngredientsDataGridView1.Location = new Point(411, 57);
            IngredientsDataGridView1.MultiSelect = false;
            IngredientsDataGridView1.Name = "IngredientsDataGridView1";
            IngredientsDataGridView1.ReadOnly = true;
            IngredientsDataGridView1.RowTemplate.Height = 25;
            IngredientsDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            IngredientsDataGridView1.Size = new Size(436, 225);
            IngredientsDataGridView1.TabIndex = 7;
            IngredientsDataGridView1.CellClick += IngredientView_Row_Clicked;
            IngredientsDataGridView1.SelectionChanged += Ingredient_View_Selection_Changed;
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
            BackButton.Click += BackButton_Click;
            // 
            // DeleteIngredientButton
            // 
            DeleteIngredientButton.Location = new Point(596, 298);
            DeleteIngredientButton.Name = "DeleteIngredientButton";
            DeleteIngredientButton.Size = new Size(75, 23);
            DeleteIngredientButton.TabIndex = 11;
            DeleteIngredientButton.Text = "Delete";
            DeleteIngredientButton.UseVisualStyleBackColor = true;
            DeleteIngredientButton.Click += DeleteIngredientButton_Click;
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
            // NewIngredientButton
            // 
            NewIngredientButton.Location = new Point(186, 10);
            NewIngredientButton.Name = "NewIngredientButton";
            NewIngredientButton.Size = new Size(75, 23);
            NewIngredientButton.TabIndex = 18;
            NewIngredientButton.Text = "New";
            NewIngredientButton.UseVisualStyleBackColor = true;
            NewIngredientButton.Click += NewIngredientButton_Click;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(62, 252);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(55, 15);
            CategoryLabel.TabIndex = 33;
            CategoryLabel.Text = "Category";
            // 
            // UoMComboBox
            // 
            UoMComboBox.FormattingEnabled = true;
            UoMComboBox.Location = new Point(124, 123);
            UoMComboBox.Name = "UoMComboBox";
            UoMComboBox.Size = new Size(101, 23);
            UoMComboBox.TabIndex = 34;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(125, 252);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(100, 23);
            CategoryComboBox.TabIndex = 35;
            // 
            // ManageIngredientsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 450);
            Controls.Add(CategoryComboBox);
            Controls.Add(UoMComboBox);
            Controls.Add(CategoryLabel);
            Controls.Add(NewIngredientButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(DeleteIngredientButton);
            Controls.Add(BackButton);
            Controls.Add(SaveIngredientButton);
            Controls.Add(IngredientsDataGridView1);
            Controls.Add(label1);
            Controls.Add(IdTextBox);
            Controls.Add(IngredientNameTextBox);
            Controls.Add(QuantityTextBox);
            Controls.Add(CostTextBox);
            Name = "ManageIngredientsView";
            Text = "ManageIngredientsView";
            Load += ManageIngredientsViewLoaded;
            ((System.ComponentModel.ISupportInitialize)IngredientsDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion



        private TextBox CostTextBox;
        private TextBox QuantityTextBox;
        private TextBox IngredientNameTextBox;
        private TextBox IdTextBox;
        private Label label1;
        private DataGridView IngredientsDataGridView1;
        private Button SaveIngredientButton;
        private Button BackButton;
        private Button DeleteIngredientButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button NewIngredientButton;
        private Label CategoryLabel;
        private ComboBox UoMComboBox;
        private ComboBox CategoryComboBox;
    }
}