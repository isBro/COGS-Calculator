namespace COGS_Calculator.Views
{
    partial class NewMenuItemView
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            Back_Button = new Button();
            Recipe_Remove_Button = new Button();
            Recipe_Add_Button = new Button();
            IsPopular_Button = new RadioButton();
            TotalCost_TextBox = new TextBox();
            Name_TextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            MenuItem_Save_Button = new Button();
            All_Recipe_IngredientsView = new DataGridView();
            All_IngredientsView = new DataGridView();
            Edit_Quantity_Button = new Button();
            Search_Label = new Label();
            Menu_Item_SearchBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)All_Recipe_IngredientsView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)All_IngredientsView).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(527, 331);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 35;
            label6.Text = "Recipe Ingredients";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(527, 62);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 34;
            label5.Text = "All Ingredients";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(303, 20);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 33;
            label4.Text = "Add New Menu Item";
            // 
            // Back_Button
            // 
            Back_Button.Location = new Point(21, 20);
            Back_Button.Name = "Back_Button";
            Back_Button.Size = new Size(75, 23);
            Back_Button.TabIndex = 31;
            Back_Button.Text = "Back";
            Back_Button.UseVisualStyleBackColor = true;
            Back_Button.Click += Back_Button_Click;
            // 
            // Recipe_Remove_Button
            // 
            Recipe_Remove_Button.Location = new Point(598, 532);
            Recipe_Remove_Button.Name = "Recipe_Remove_Button";
            Recipe_Remove_Button.Size = new Size(75, 23);
            Recipe_Remove_Button.TabIndex = 30;
            Recipe_Remove_Button.Text = "Remove";
            Recipe_Remove_Button.UseVisualStyleBackColor = true;
            Recipe_Remove_Button.Click += Recipe_Remove_Button_Click;
            // 
            // Recipe_Add_Button
            // 
            Recipe_Add_Button.Location = new Point(535, 260);
            Recipe_Add_Button.Name = "Recipe_Add_Button";
            Recipe_Add_Button.Size = new Size(75, 23);
            Recipe_Add_Button.TabIndex = 29;
            Recipe_Add_Button.Text = "Add";
            Recipe_Add_Button.UseVisualStyleBackColor = true;
            Recipe_Add_Button.Click += Recipe_Add_Button_Click;
            // 
            // IsPopular_Button
            // 
            IsPopular_Button.AutoSize = true;
            IsPopular_Button.Location = new Point(95, 197);
            IsPopular_Button.Name = "IsPopular_Button";
            IsPopular_Button.Size = new Size(66, 19);
            IsPopular_Button.TabIndex = 28;
            IsPopular_Button.TabStop = true;
            IsPopular_Button.Text = "Popular";
            IsPopular_Button.UseVisualStyleBackColor = true;
            // 
            // TotalCost_TextBox
            // 
            TotalCost_TextBox.Location = new Point(95, 155);
            TotalCost_TextBox.Name = "TotalCost_TextBox";
            TotalCost_TextBox.Size = new Size(59, 23);
            TotalCost_TextBox.TabIndex = 27;
            // 
            // Name_TextBox
            // 
            Name_TextBox.Location = new Point(95, 123);
            Name_TextBox.Name = "Name_TextBox";
            Name_TextBox.Size = new Size(100, 23);
            Name_TextBox.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 155);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 25;
            label3.Text = "Total Cost";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 126);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 24;
            label2.Text = "Name";
            // 
            // MenuItem_Save_Button
            // 
            MenuItem_Save_Button.Location = new Point(95, 255);
            MenuItem_Save_Button.Name = "MenuItem_Save_Button";
            MenuItem_Save_Button.Size = new Size(75, 23);
            MenuItem_Save_Button.TabIndex = 22;
            MenuItem_Save_Button.Text = "Save";
            MenuItem_Save_Button.UseVisualStyleBackColor = true;
            MenuItem_Save_Button.Click += MenuItem_Save_Button_Click;
            // 
            // All_Recipe_IngredientsView
            // 
            All_Recipe_IngredientsView.AllowUserToAddRows = false;
            All_Recipe_IngredientsView.AllowUserToDeleteRows = false;
            All_Recipe_IngredientsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            All_Recipe_IngredientsView.Location = new Point(407, 361);
            All_Recipe_IngredientsView.MultiSelect = false;
            All_Recipe_IngredientsView.Name = "All_Recipe_IngredientsView";
            All_Recipe_IngredientsView.RowTemplate.Height = 25;
            All_Recipe_IngredientsView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            All_Recipe_IngredientsView.Size = new Size(329, 165);
            All_Recipe_IngredientsView.TabIndex = 20;
            All_Recipe_IngredientsView.Click += Current_Ingredient_Row_Clicked;
            // 
            // All_IngredientsView
            // 
            All_IngredientsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            All_IngredientsView.Location = new Point(407, 95);
            All_IngredientsView.MultiSelect = false;
            All_IngredientsView.Name = "All_IngredientsView";
            All_IngredientsView.RowTemplate.Height = 25;
            All_IngredientsView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            All_IngredientsView.Size = new Size(329, 150);
            All_IngredientsView.TabIndex = 19;
            All_IngredientsView.Click += All_Ingredients_Row_Clicked;
            // 
            // Edit_Quantity_Button
            // 
            Edit_Quantity_Button.Location = new Point(450, 532);
            Edit_Quantity_Button.Name = "Edit_Quantity_Button";
            Edit_Quantity_Button.Size = new Size(75, 23);
            Edit_Quantity_Button.TabIndex = 36;
            Edit_Quantity_Button.Text = "Edit";
            Edit_Quantity_Button.UseVisualStyleBackColor = true;
            Edit_Quantity_Button.Click += Edit_Quantity_Button_Click;
            // 
            // Search_Label
            // 
            Search_Label.AutoSize = true;
            Search_Label.Location = new Point(577, 20);
            Search_Label.Name = "Search_Label";
            Search_Label.Size = new Size(42, 15);
            Search_Label.TabIndex = 44;
            Search_Label.Text = "Search";
            // 
            // Menu_Item_SearchBox
            // 
            Menu_Item_SearchBox.Location = new Point(636, 17);
            Menu_Item_SearchBox.Name = "Menu_Item_SearchBox";
            Menu_Item_SearchBox.Size = new Size(100, 23);
            Menu_Item_SearchBox.TabIndex = 43;
            // 
            // NewMenuItemView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 569);
            Controls.Add(Search_Label);
            Controls.Add(Menu_Item_SearchBox);
            Controls.Add(Edit_Quantity_Button);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Back_Button);
            Controls.Add(Recipe_Remove_Button);
            Controls.Add(Recipe_Add_Button);
            Controls.Add(IsPopular_Button);
            Controls.Add(TotalCost_TextBox);
            Controls.Add(Name_TextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(MenuItem_Save_Button);
            Controls.Add(All_Recipe_IngredientsView);
            Controls.Add(All_IngredientsView);
            Name = "NewMenuItemView";
            Text = "NewMenuItemView";
            Activated += New_Menu_ItemView_Activated;
            VisibleChanged += NewMenuItemView_Visibility_Changed;
            ((System.ComponentModel.ISupportInitialize)All_Recipe_IngredientsView).EndInit();
            ((System.ComponentModel.ISupportInitialize)All_IngredientsView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Button Back_Button;
        private Button Recipe_Remove_Button;
        private Button Recipe_Add_Button;
        private RadioButton IsPopular_Button;
        private TextBox TotalCost_TextBox;
        private TextBox Name_TextBox;
        private Label label3;
        private Label label2;
        private Button MenuItem_Save_Button;
        private DataGridView All_Recipe_IngredientsView;
        private DataGridView All_IngredientsView;
        private Button Edit_Quantity_Button;
        private Label Search_Label;
        private TextBox Menu_Item_SearchBox;
    }
}