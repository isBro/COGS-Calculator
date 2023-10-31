namespace COGS_Calculator
{
    partial class ManageMenuItemView
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
            All_IngredientsView = new DataGridView();
            All_Recipe_IngredientsView = new DataGridView();
            label1 = new Label();
            MenuItem_Save_Button = new Button();
            ID_TextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Name_TextBox = new TextBox();
            TotalCost_TextBox = new TextBox();
            IsPopular_Button = new RadioButton();
            Recipe_Add_Button = new Button();
            Recipe_Remove_Button = new Button();
            Back_Button = new Button();
            New_MenuItem_Button = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Edit_Quantity_Button = new Button();
            label7 = new Label();
            All_Menu_Items_View = new DataGridView();
            Menu_Item_SearchBox = new TextBox();
            Search_Label = new Label();
            ((System.ComponentModel.ISupportInitialize)All_IngredientsView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)All_Recipe_IngredientsView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)All_Menu_Items_View).BeginInit();
            SuspendLayout();
            // 
            // All_IngredientsView
            // 
            All_IngredientsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            All_IngredientsView.Location = new Point(672, 337);
            All_IngredientsView.Name = "All_IngredientsView";
            All_IngredientsView.RowTemplate.Height = 25;
            All_IngredientsView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            All_IngredientsView.Size = new Size(381, 179);
            All_IngredientsView.TabIndex = 0;
            All_IngredientsView.Click += All_Ingredients_Clicked;
            // 
            // All_Recipe_IngredientsView
            // 
            All_Recipe_IngredientsView.AllowUserToAddRows = false;
            All_Recipe_IngredientsView.AllowUserToDeleteRows = false;
            All_Recipe_IngredientsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            All_Recipe_IngredientsView.Location = new Point(278, 337);
            All_Recipe_IngredientsView.Name = "All_Recipe_IngredientsView";
            All_Recipe_IngredientsView.RowTemplate.Height = 25;
            All_Recipe_IngredientsView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            All_Recipe_IngredientsView.Size = new Size(353, 179);
            All_Recipe_IngredientsView.TabIndex = 1;
            All_Recipe_IngredientsView.Click += Current_Recipe_Ingredient_Row_Clicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 142);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // MenuItem_Save_Button
            // 
            MenuItem_Save_Button.Location = new Point(91, 304);
            MenuItem_Save_Button.Name = "MenuItem_Save_Button";
            MenuItem_Save_Button.Size = new Size(75, 23);
            MenuItem_Save_Button.TabIndex = 3;
            MenuItem_Save_Button.Text = "Save";
            MenuItem_Save_Button.UseVisualStyleBackColor = true;
            MenuItem_Save_Button.Click += MenuItem_Save_Button_Click;
            // 
            // ID_TextBox
            // 
            ID_TextBox.Enabled = false;
            ID_TextBox.Location = new Point(91, 139);
            ID_TextBox.Name = "ID_TextBox";
            ID_TextBox.Size = new Size(28, 23);
            ID_TextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 175);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 204);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 6;
            label3.Text = "Total Cost";
            // 
            // Name_TextBox
            // 
            Name_TextBox.Enabled = false;
            Name_TextBox.Location = new Point(91, 172);
            Name_TextBox.Name = "Name_TextBox";
            Name_TextBox.Size = new Size(100, 23);
            Name_TextBox.TabIndex = 8;
            // 
            // TotalCost_TextBox
            // 
            TotalCost_TextBox.Location = new Point(91, 204);
            TotalCost_TextBox.Name = "TotalCost_TextBox";
            TotalCost_TextBox.Size = new Size(59, 23);
            TotalCost_TextBox.TabIndex = 10;
            // 
            // IsPopular_Button
            // 
            IsPopular_Button.AutoSize = true;
            IsPopular_Button.Location = new Point(91, 246);
            IsPopular_Button.Name = "IsPopular_Button";
            IsPopular_Button.Size = new Size(66, 19);
            IsPopular_Button.TabIndex = 11;
            IsPopular_Button.TabStop = true;
            IsPopular_Button.Text = "Popular";
            IsPopular_Button.UseVisualStyleBackColor = true;
            // 
            // Recipe_Add_Button
            // 
            Recipe_Add_Button.Location = new Point(816, 522);
            Recipe_Add_Button.Name = "Recipe_Add_Button";
            Recipe_Add_Button.Size = new Size(75, 23);
            Recipe_Add_Button.TabIndex = 12;
            Recipe_Add_Button.Text = "Add";
            Recipe_Add_Button.UseVisualStyleBackColor = true;
            Recipe_Add_Button.Click += Recipe_Add_Button_Click;
            // 
            // Recipe_Remove_Button
            // 
            Recipe_Remove_Button.Location = new Point(479, 522);
            Recipe_Remove_Button.Name = "Recipe_Remove_Button";
            Recipe_Remove_Button.Size = new Size(75, 23);
            Recipe_Remove_Button.TabIndex = 13;
            Recipe_Remove_Button.Text = "Remove";
            Recipe_Remove_Button.UseVisualStyleBackColor = true;
            Recipe_Remove_Button.Click += Recipe_Remove_Button_Click;
            // 
            // Back_Button
            // 
            Back_Button.Location = new Point(27, 22);
            Back_Button.Name = "Back_Button";
            Back_Button.Size = new Size(75, 23);
            Back_Button.TabIndex = 14;
            Back_Button.Text = "Back";
            Back_Button.UseVisualStyleBackColor = true;
            Back_Button.Click += Back_Button_Click;
            // 
            // New_MenuItem_Button
            // 
            New_MenuItem_Button.Location = new Point(145, 22);
            New_MenuItem_Button.Name = "New_MenuItem_Button";
            New_MenuItem_Button.Size = new Size(75, 23);
            New_MenuItem_Button.TabIndex = 15;
            New_MenuItem_Button.Text = "New";
            New_MenuItem_Button.UseVisualStyleBackColor = true;
            New_MenuItem_Button.Click += New_MenuItem_Button_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(423, 22);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 16;
            label4.Text = "Manage Menu Items";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(808, 304);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 17;
            label5.Text = "All Ingredients";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(397, 308);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 18;
            label6.Text = "Recipe Ingredients";
            // 
            // Edit_Quantity_Button
            // 
            Edit_Quantity_Button.Location = new Point(326, 522);
            Edit_Quantity_Button.Name = "Edit_Quantity_Button";
            Edit_Quantity_Button.Size = new Size(75, 23);
            Edit_Quantity_Button.TabIndex = 19;
            Edit_Quantity_Button.Text = "Edit";
            Edit_Quantity_Button.UseVisualStyleBackColor = true;
            Edit_Quantity_Button.Click += Edit_Quantity_Button_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(414, 107);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 40;
            label7.Text = "All Menu Items";
            // 
            // All_Menu_Items_View
            // 
            All_Menu_Items_View.AllowUserToAddRows = false;
            All_Menu_Items_View.AllowUserToDeleteRows = false;
            All_Menu_Items_View.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            All_Menu_Items_View.Location = new Point(278, 139);
            All_Menu_Items_View.Name = "All_Menu_Items_View";
            All_Menu_Items_View.ReadOnly = true;
            All_Menu_Items_View.RowTemplate.Height = 25;
            All_Menu_Items_View.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            All_Menu_Items_View.Size = new Size(353, 150);
            All_Menu_Items_View.TabIndex = 39;
            All_Menu_Items_View.Click += All_Menu_Item_Row_Clicked;
            // 
            // Menu_Item_SearchBox
            // 
            Menu_Item_SearchBox.Location = new Point(838, 19);
            Menu_Item_SearchBox.Name = "Menu_Item_SearchBox";
            Menu_Item_SearchBox.Size = new Size(100, 23);
            Menu_Item_SearchBox.TabIndex = 41;
            Menu_Item_SearchBox.TextChanged += Menu_ItemSearch_Text_Changed;
            // 
            // Search_Label
            // 
            Search_Label.AutoSize = true;
            Search_Label.Location = new Point(779, 22);
            Search_Label.Name = "Search_Label";
            Search_Label.Size = new Size(42, 15);
            Search_Label.TabIndex = 42;
            Search_Label.Text = "Search";
            // 
            // ManageMenuItemView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 558);
            Controls.Add(Search_Label);
            Controls.Add(Menu_Item_SearchBox);
            Controls.Add(label7);
            Controls.Add(All_Menu_Items_View);
            Controls.Add(Edit_Quantity_Button);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(New_MenuItem_Button);
            Controls.Add(Back_Button);
            Controls.Add(Recipe_Remove_Button);
            Controls.Add(Recipe_Add_Button);
            Controls.Add(IsPopular_Button);
            Controls.Add(TotalCost_TextBox);
            Controls.Add(Name_TextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ID_TextBox);
            Controls.Add(MenuItem_Save_Button);
            Controls.Add(label1);
            Controls.Add(All_Recipe_IngredientsView);
            Controls.Add(All_IngredientsView);
            Name = "ManageMenuItemView";
            Text = "ManageMenuItemView";
            Activated += ManageMenuItemView_Activated;
            Load += ManageMenuItemView_Load;
            ((System.ComponentModel.ISupportInitialize)All_IngredientsView).EndInit();
            ((System.ComponentModel.ISupportInitialize)All_Recipe_IngredientsView).EndInit();
            ((System.ComponentModel.ISupportInitialize)All_Menu_Items_View).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView All_IngredientsView;
        private DataGridView All_Recipe_IngredientsView;
        private Label label1;
        private Button MenuItem_Save_Button;
        private TextBox ID_TextBox;
        private Label label2;
        private Label label3;
        private TextBox Name_TextBox;
        private TextBox TotalCost_TextBox;
        private RadioButton IsPopular_Button;
        private Button Recipe_Add_Button;
        private Button Recipe_Remove_Button;
        private Button Back_Button;
        private Button New_MenuItem_Button;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button Edit_Quantity_Button;
        private Label label7;
        private DataGridView All_Menu_Items_View;
        private TextBox Menu_Item_SearchBox;
        private Label Search_Label;
    }
}