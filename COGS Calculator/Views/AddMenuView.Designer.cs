namespace COGS_Calculator
{
    partial class AddMenuView
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
            NotesTextBox = new TextBox();
            label3 = new Label();
            PersonCountTextBox = new TextBox();
            label1 = new Label();
            MenuNameTextBox = new TextBox();
            label2 = new Label();
            AllMenu_ItemDataGrid = new DataGridView();
            CurrentMenu_ItemDataGrid = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            AddMenu_Item_Button = new Button();
            Remove_Menu_Item_Button = new Button();
            Save_Menu_Button = new Button();
            CancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)AllMenu_ItemDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CurrentMenu_ItemDataGrid).BeginInit();
            SuspendLayout();
            // 
            // NotesTextBox
            // 
            NotesTextBox.Location = new Point(89, 166);
            NotesTextBox.Margin = new Padding(3, 2, 3, 2);
            NotesTextBox.Multiline = true;
            NotesTextBox.Name = "NotesTextBox";
            NotesTextBox.Size = new Size(349, 72);
            NotesTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 169);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "Notes";
            // 
            // PersonCountTextBox
            // 
            PersonCountTextBox.Location = new Point(198, 86);
            PersonCountTextBox.Margin = new Padding(3, 2, 3, 2);
            PersonCountTextBox.Name = "PersonCountTextBox";
            PersonCountTextBox.Size = new Size(51, 23);
            PersonCountTextBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 88);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 8;
            label1.Text = "No. of Guests";
            // 
            // MenuNameTextBox
            // 
            MenuNameTextBox.Location = new Point(430, 36);
            MenuNameTextBox.Margin = new Padding(3, 2, 3, 2);
            MenuNameTextBox.Name = "MenuNameTextBox";
            MenuNameTextBox.Size = new Size(170, 23);
            MenuNameTextBox.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(336, 38);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 10;
            label2.Text = "Menu Name";
            // 
            // AllMenu_ItemDataGrid
            // 
            AllMenu_ItemDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllMenu_ItemDataGrid.Location = new Point(534, 97);
            AllMenu_ItemDataGrid.Margin = new Padding(3, 2, 3, 2);
            AllMenu_ItemDataGrid.Name = "AllMenu_ItemDataGrid";
            AllMenu_ItemDataGrid.RowHeadersWidth = 51;
            AllMenu_ItemDataGrid.RowTemplate.Height = 29;
            AllMenu_ItemDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllMenu_ItemDataGrid.Size = new Size(427, 141);
            AllMenu_ItemDataGrid.TabIndex = 12;
            AllMenu_ItemDataGrid.Click += AllMenu_ItemDataGrid_Clicked;
            // 
            // CurrentMenu_ItemDataGrid
            // 
            CurrentMenu_ItemDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CurrentMenu_ItemDataGrid.Location = new Point(534, 346);
            CurrentMenu_ItemDataGrid.Margin = new Padding(3, 2, 3, 2);
            CurrentMenu_ItemDataGrid.Name = "CurrentMenu_ItemDataGrid";
            CurrentMenu_ItemDataGrid.RowHeadersWidth = 51;
            CurrentMenu_ItemDataGrid.RowTemplate.Height = 29;
            CurrentMenu_ItemDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CurrentMenu_ItemDataGrid.Size = new Size(427, 141);
            CurrentMenu_ItemDataGrid.TabIndex = 13;
            CurrentMenu_ItemDataGrid.Click += CurrentMenu_ItemDataGrid_Clicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(711, 65);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 14;
            label4.Text = "All Products";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(711, 313);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 15;
            label5.Text = "Menu Items";
            // 
            // AddMenu_Item_Button
            // 
            AddMenu_Item_Button.Location = new Point(580, 255);
            AddMenu_Item_Button.Margin = new Padding(3, 2, 3, 2);
            AddMenu_Item_Button.Name = "AddMenu_Item_Button";
            AddMenu_Item_Button.Size = new Size(82, 22);
            AddMenu_Item_Button.TabIndex = 16;
            AddMenu_Item_Button.Text = "Add";
            AddMenu_Item_Button.UseVisualStyleBackColor = true;
            AddMenu_Item_Button.Click += AddMenu_Item_Button_Click;
            // 
            // Remove_Menu_Item_Button
            // 
            Remove_Menu_Item_Button.Location = new Point(580, 502);
            Remove_Menu_Item_Button.Margin = new Padding(3, 2, 3, 2);
            Remove_Menu_Item_Button.Name = "Remove_Menu_Item_Button";
            Remove_Menu_Item_Button.Size = new Size(82, 22);
            Remove_Menu_Item_Button.TabIndex = 17;
            Remove_Menu_Item_Button.Text = "Remove";
            Remove_Menu_Item_Button.UseVisualStyleBackColor = true;
            Remove_Menu_Item_Button.Click += Remove_Menu_Item_Button_Click;
            // 
            // Save_Menu_Button
            // 
            Save_Menu_Button.Location = new Point(174, 421);
            Save_Menu_Button.Name = "Save_Menu_Button";
            Save_Menu_Button.Size = new Size(75, 23);
            Save_Menu_Button.TabIndex = 18;
            Save_Menu_Button.Text = "Save Menu";
            Save_Menu_Button.UseVisualStyleBackColor = true;
            Save_Menu_Button.Click += Save_Menu_Button_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(303, 421);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 19;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddMenuView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 542);
            Controls.Add(CancelButton);
            Controls.Add(Save_Menu_Button);
            Controls.Add(Remove_Menu_Item_Button);
            Controls.Add(AddMenu_Item_Button);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(CurrentMenu_ItemDataGrid);
            Controls.Add(AllMenu_ItemDataGrid);
            Controls.Add(MenuNameTextBox);
            Controls.Add(label2);
            Controls.Add(PersonCountTextBox);
            Controls.Add(label1);
            Controls.Add(NotesTextBox);
            Controls.Add(label3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddMenuView";
            Text = "AddMenuView";
            Activated += AddMenuView_Activated;
            ((System.ComponentModel.ISupportInitialize)AllMenu_ItemDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)CurrentMenu_ItemDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NotesTextBox;
        private Label label3;
        private TextBox PersonCountTextBox;
        private Label label1;
        private TextBox MenuNameTextBox;
        private Label label2;
        private DataGridView AllMenu_ItemDataGrid;
        private DataGridView CurrentMenu_ItemDataGrid;
        private Label label4;
        private Label label5;
        private Button AddMenu_Item_Button;
        private Button Remove_Menu_Item_Button;
        private Button Save_Menu_Button;
        private Button CancelButton;
    }
}